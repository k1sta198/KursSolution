﻿using System;
using System.IO;
using System.Windows.Forms;

namespace Crypto
{
    public partial class FormAuth : Form
    {
        public static bool IsAuth { get; private set; }
        private Datebase db = null;

        // конструктор формы
        public FormAuth()
        {
            IsAuth = false;
            // инициализация компонентов
            InitializeComponent();
        }

        // закрузка формы
        private void FormAuth_Load(object sender, EventArgs e)
        {
            // настроим подключение к бд
            db = new Datebase("Data Source=dateBase.db; Version = 3;");
            // при отсутсвии бд создадим её
            if (!File.Exists($"{Application.StartupPath}\\dataBase.db"))
                db.InitializeDatabase();
        }

        // закрыть коннект к бд при закрытии формы
        private void FormAuth_FormClosing(object sender, FormClosingEventArgs e) => db.CloseDB();

        // проверка поля на доступные условия
        private bool CheckData(TextBox text, string name = "Логин")
        {
            // проверка на отсутствие текста
            if (string.IsNullOrWhiteSpace(text.Text))
            {
                MessageBox.Show($"{name} не задан! Укажите {name.ToLower()} вашей учётной записи...");
                return false;
            }
            // проверка на минимально допустимый размер
            if (text.Text.Length < 3)
            {
                MessageBox.Show($"{name} не удовлетворяет условиям! Укажите верный {name.ToLower()}...");
                return false;
            }
            return true;
        }

        // кнопка вход
        private void bIn_Click(object sender, EventArgs e)
        {
            // проверки
            if (!CheckData(tLoginIn)) return;
            if (!CheckData(tPassIn, "Пароль")) return;
            if (!db.CheckUser(tLoginIn.Text, tPassIn.Text, false))
            {
                MessageBox.Show("Указанные данные для авторизации не верны!");
                tPassIn.Text = "";
                tPassIn.Focus();
                return;
            }
            // удачный вход
            IsAuth = true;
            // закрыть окно авторизации
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormReg().ShowDialog();
        }
    }
}

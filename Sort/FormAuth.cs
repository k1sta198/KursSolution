using System;
using System.IO;
using System.Windows.Forms;

namespace Sort
{
    public partial class FormAuth : Form
    {
        private Database db = null;

        // конструктор формы
        public FormAuth()
        {
            InitializeComponent();
        }

        // загрузка формы
        private void FormAuth_Load(object sender, EventArgs e)
        {
            // настроим подключение к бд
            db = new Database("Data Source=dateBase.db; Version = 3;");
            // при отсутсвии бд создадим её
            if (!File.Exists($"{Application.StartupPath}\\dataBase.db"))
                db.InitializeDatabase();
        }

        // закрыть соединение с бд при закрытии формы
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
            if (text.Text.Length < 4)
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
            if (!CheckData(textboxLoginIn)) return;
            if (!CheckData(textboxPassIn, "Пароль")) return;
            if (!db.CheckUser(textboxLoginIn.Text, textboxPassIn.Text, false))
            {
                MessageBox.Show("Указанные данные для авторизации неверные!");
                textboxPassIn.Text = "";
                textboxPassIn.Focus();
                return;
            }
            // удачный вход
            this.DialogResult = DialogResult.OK;
            // закрыть окно авторизации
            Close();
        }
        // кнопка регистрация
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult regResult = new FormReg().ShowDialog();
            if (regResult == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

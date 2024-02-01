using System;
using System.Windows.Forms;

namespace Sort
{
    public partial class FormReg : Form
    {
        private Database db = null;
        public FormReg()
        {
            InitializeComponent();
        }

        // проверка поля на доступные условия
        private bool CheckData(TextBox text, string name = "Логин")
        {
            // проверка на отсутствие текста
            if (string.IsNullOrWhiteSpace(text.Text))
            {
                MessageBox.Show($"{name} не задан! Придумайте {name.ToLower()} для вашей учётной записи.");
                return false;
            }
            // проверка на минимально допустимый размер
            if (text.Text.Length < 4)
            {
                MessageBox.Show($"{name} не удовлетворяет условиям! Длина пароля должна быть не менее 4 символов.");
                return false;
            }
            return true;
        }


        private void bReg_Click(object sender, EventArgs e)
        {
            // проверки
            if (!CheckData(textbox_LoginReg)) return;
            if (db.CheckUser(textbox_LoginReg.Text, textbox_PassReg1.Text, true))
            {
                MessageBox.Show("Указанный логин уже используется! Придумайте новый логин.");
                return;
            }
            if (!CheckData(textbox_PassReg1, "Пароль")) return;
            if (textbox_PassReg1.Text != textbox_PassReg2.Text)
            {
                MessageBox.Show("Пароли не совпадают. Попробуйте еще раз.");
                return;
            }
            // создание пользователя
            if (db.CreateUser(textbox_LoginReg.Text, textbox_PassReg1.Text))
            {
                MessageBox.Show("Вы успешно зарегистрировались!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void FormReg_Load(object sender, EventArgs e)
        {
            // настроим подключение к бд
            db = new Database("Data Source=dateBase.db; Version = 3;");
        }
    }
}

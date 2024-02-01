using System.Windows.Forms;

namespace Crypto
{
    public partial class Work : Form
    {
        private Gronsfeld alg = new Gronsfeld();
      
        // конструктор формы
        public Work()
        {
            InitializeComponent();
        }

        // загрузка формы
        private void Work_Load(object sender, System.EventArgs e) => alg.Key = textBox1.Text;

        // изменение ключа
        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            alg.Key = textBox1.Text;
            textBox3.Text = "";
        }

        // зашифровать
        private void bCrypt_Click(object sender, System.EventArgs e)
        {
            textBox3.Text = alg.Crypt(textBox2.Text);
        }

        // расшифровать
        private void bDecode_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(alg.Decrypt(textBox3.Text),"Расшифровка по ключу "+alg.Key);
        }
    }
}

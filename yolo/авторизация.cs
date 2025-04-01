using System.Windows.Forms;
using завод_игрпушек;

namespace yolo
{
    public partial class авторизация : Form
    {
        public авторизация()
        {
            InitializeComponent();
            Helper.цветДляПереходов(createAccount);
        }

        private void createAccount_Click(object sender, System.EventArgs e)
        {
            Helper.переход(this, new создание_аккаунта());
        }

        private void logInUser_Click(object sender, System.EventArgs e)
        {
            Helper.переход(this, new входВпрофельКлиента());
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Helper.переход(this, new testForm());
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Helper.переход(this, new mainForm());
        }
    }
}

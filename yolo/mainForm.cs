using System;
using System.Linq;
using System.Windows.Forms;

namespace yolo
{
    public partial class mainForm : Form
    {
        public static string текущийЛогин;
        public static int текущийКлиентId; // Статическая переменная для хранения id текущего клиента


        public mainForm()
        {
            InitializeComponent();
            Helper.цветДляПереходов(label8);
            Helper.цветДляПереходов(переходКконтактам);
        }

        // Устанавливает имя клиента в метку профиля
        public void SetClientProfile(string clientName)
        {
            LableпрофильКлиента.Text = clientName;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Helper.переход(this, new авторизация());
        }

        private void переходКконтактам_Click(object sender, EventArgs e)
        {
            Helper.переход(this, new контакты());
        }

        private void LableпрофильКлиента_Click(object sender, EventArgs e)
        {
            using (var db = new DbHelper())
            {
                try
                {
                    var клиент = db.Клиенты.FirstOrDefault(k => k.имя == текущийЛогин); // текущийЛогин - переменная, хранящая логин текущего пользователя
                    if (клиент != null)
                    {
                        профильПользователя профильПользователяInstance = new профильПользователя(клиент.почта, клиент.имя, клиент.пароль);
                        профильПользователяInstance.ProfileUpdated += OnProfileUpdated;
                        Helper.загрузкаФормыВправо(this, профильПользователяInstance, splitContainer1);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка", "Произошла ошибка при загрузке профиля пользователя");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке профиля: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Обновляет текущий логин и метку профиля при изменении профиля
        private void OnProfileUpdated(string newLogin)
        {
            текущийЛогин = newLogin;
            SetClientProfile(newLogin);
        }

        private void КаталогКлиента_Click(object sender, EventArgs e)
        {
            Helper.загрузкаФормыВправо(this, new каталог(), splitContainer1);
        }

        private void корзинаКлиента_Click(object sender, EventArgs e)
        {
            Helper.загрузкаФормыВправо(this, new корзина(), splitContainer1);
        }

        private void заказыКлиента_Click(object sender, EventArgs e)
        {
            Helper.загрузкаФормыВправо(this, new ЗаказыForm(), splitContainer1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yolo
{
    public partial class mainForm: Form
    {
        public static string текущийЛогин;
        public mainForm()
        {
            InitializeComponent();
            Helper.цветДляПереходов(label8);
            Helper.цветДляПереходов(переходКконтактам);
        }
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
                var клиент = db.Клиенты.FirstOrDefault(k => k.имя == текущийЛогин); // текущийЛогин - переменная, хранящая логин текущего пользователя
                if (клиент != null)
                {
                    профильПользователя профильПользователяInstance = new профильПользователя(клиент.почта, клиент.имя, клиент.пароль);
                    Helper.загрузкаФормыВправо(this, профильПользователяInstance, splitContainer1);
                }
                else
                {
                    MessageBox.Show("Ошибка", "Произошла ошибка при загрузке профиля пользователя");
                }
            }
        }
    }
}

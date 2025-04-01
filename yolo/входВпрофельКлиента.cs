using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yolo;

namespace завод_игрпушек
{
    public partial class входВпрофельКлиента: Form
    {
        public входВпрофельКлиента()
        {
            InitializeComponent();
            войти.Enabled = false;
            Helper.цветДляПереходов(label8);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Helper.переход(this, new авторизация());
        }
        private void inputLoginForLogin_TextChanged(object sender, EventArgs e)
        {
            CheckInputFields();
        }

        private void inputPaswordForLogin_TextChanged(object sender, EventArgs e)
        {
            CheckInputFields();
        }
        private void CheckInputFields()
        {
            // Проверяем, заполнены ли все текстовые поля
            if( !string.IsNullOrWhiteSpace(inputLoginForLogin.Text) &&
                !string.IsNullOrWhiteSpace(inputPaswordForLogin.Text))
            {
                войти.Enabled = true; // Активируем кнопку
            }
            else
            {
                войти.Enabled = false; // Деактивируем кнопку
            }
        }
        private void войти_Click(object sender, EventArgs e)
        {
            using (var db = new DbHelper())
            {
                var клиент = db.Клиенты.FirstOrDefault(k => k.имя == inputLoginForLogin.Text && k.пароль == inputPaswordForLogin.Text);
                if (клиент != null)
                {
                    mainForm mainFormInstance = new mainForm();
                    mainFormInstance.SetClientProfile(клиент.имя);
                    Helper.переход(this, mainFormInstance);
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

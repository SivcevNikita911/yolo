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
    public partial class входВпрофельАдминистратора: Form
    {
        public входВпрофельАдминистратора()
        {
            InitializeComponent();
            войтиAdmin.Enabled = false;
            Helper.цветДляПереходов(label8);
        }
        private void label8_Click(object sender, EventArgs e)
        {
            Helper.переход(this, new авторизация());
        }

        private void inputLoginAdmin_TextChanged(object sender, EventArgs e)
        {
            CheckInputFields();
        }

        private void inputPaswordAdmin_TextChanged(object sender, EventArgs e)
        {
            CheckInputFields();
        }
        private void CheckInputFields()
        {
            // Проверяем, заполнены ли все текстовые поля
            if (!string.IsNullOrWhiteSpace(inputLoginAdmin.Text) &&
                !string.IsNullOrWhiteSpace(inputPaswordAdmin.Text))
            {
                войтиAdmin.Enabled = true; // Активируем кнопку
            }
            else
            {
                войтиAdmin.Enabled = false; // Деактивируем кнопку
            }
        }
        private void войтиAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DbHelper())
                {
                    var админ = db.Администраторы.FirstOrDefault(k => k.имя == inputLoginAdmin.Text && k.пароль == inputPaswordAdmin.Text);
                    if (админ != null)
                    {
                        adminForm adminFormInstance = new adminForm();
                        Helper.переход(this, adminFormInstance);
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

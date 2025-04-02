using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace yolo
{
    public partial class создание_аккаунта : Form
    {
        public создание_аккаунта()
        {
            InitializeComponent();
            Helper.цветДляПереходов(backToАвторизация);
            saveKlient.Enabled = false;
        }

        private void backToАвторизация_Click(object sender, EventArgs e)
        {
            Helper.переход(this, new авторизация());
        }

        private void inputMaill_TextChanged(object sender, EventArgs e)
        {
            CheckInputFields();
        }

        private void inputLogin_TextChanged(object sender, EventArgs e)
        {
            CheckInputFields();
        }

        private void inputPassword_TextChanged(object sender, EventArgs e)
        {
            CheckInputFields();
        }

        private void CheckInputFields()
        {
            // Проверяем, заполнены ли все текстовые поля
            if (!string.IsNullOrWhiteSpace(inputMaill.Text) &&
                !string.IsNullOrWhiteSpace(inputLogin.Text) &&
                !string.IsNullOrWhiteSpace(inputPassword.Text))
            {
                saveKlient.Enabled = true; // Активируем кнопку
            }
            else
            {
                saveKlient.Enabled = false; // Деактивируем кнопку
            }
        }
        private DbHelper db = new DbHelper();
        private void saveKlient_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, существует ли клиент с таким же email или логином
                var existingClient = db.Клиенты.FirstOrDefault(k => k.почта == inputMaill.Text || k.имя == inputLogin.Text);
                if (existingClient != null)
                {
                    MessageBox.Show("Клиент с таким email или логином уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inputMaill.Text= "";
                    inputLogin.Text = "";
                    return;
                }

                Клиенты клиент = new Клиенты
                {
                    почта = inputMaill.Text,
                    имя = inputLogin.Text,
                    пароль = inputPassword.Text
                };
                db.Клиенты.Add(клиент);
                db.SaveChanges(); // Сохраняем изменения в базе данных
                MessageBox.Show("Клиент успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Helper.переход(this, new авторизация());
            }
            catch (Exception ex)
            {
                // Выводим сообщение об ошибке и внутреннее исключение
                MessageBox.Show($"Ошибка при сохранении клиента: {ex.Message}\n\n{ex.InnerException?.Message}\n\n{ex.InnerException?.InnerException?.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
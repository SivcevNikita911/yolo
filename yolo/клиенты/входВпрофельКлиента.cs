using System;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using yolo;

namespace завод_игрпушек
{
    public partial class входВпрофельКлиента : Form
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
            if (!string.IsNullOrWhiteSpace(inputLoginForLogin.Text) &&
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
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                if (string.IsNullOrWhiteSpace(connectionString))
                {
                    throw new InvalidOperationException("Строка подключения к базе данных не найдена или пуста.");
                }

                // Проверка существования файла базы данных
                var builder = new SQLiteConnectionStringBuilder(connectionString);
                if (!System.IO.File.Exists(builder.DataSource))
                {
                    throw new InvalidOperationException("Файл базы данных не найден по указанному пути.");
                }

                using (var db = new DbHelper())
                {
                    var клиент = db.Клиенты.FirstOrDefault(k => k.имя == inputLoginForLogin.Text && k.пароль == inputPaswordForLogin.Text);
                    if (клиент != null)
                    {
                        mainForm.текущийЛогин = клиент.имя; // Инициализация переменной текущийЛогин
                        mainForm.текущийКлиентId = клиент.id; // Сохранение id клиента в глобальную переменную

                        mainForm mainFormInstance = new mainForm();
                        mainFormInstance.SetClientProfile(клиент.имя); // Установка имени клиента в метку

                        // Переход на форму mainForm
                        Helper.переход(this, mainFormInstance);
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Ошибка при подключении к БД: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Ошибка в операции: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неизвестная ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

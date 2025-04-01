using System.Drawing;
using System.Windows.Forms;

namespace yolo
{
    class Helper
    {

        public static void цветДляПереходов(Label label)
        {
            label.MouseEnter += (sender, e) =>
            {
                label.ForeColor = Color.Blue; // Изменение цвета текста
                label.Font = new Font(label.Font, FontStyle.Bold); // Изменение стиля шрифта на жирный
            };

            label.MouseLeave += (sender, e) =>
            {
                label.ForeColor = Color.Yellow; 
                label.Font = new Font(label.Font, FontStyle.Regular); 
            };
        }
        public static void переход(Form текущая, Form следующаяФорма)
        {
            следующаяФорма.FormClosed += (s, e) =>
        {
            if (Application.OpenForms.Count == 1) // Если больше нет открытых форм
            {
                Application.Exit(); // Завершает приложение
            }
            else текущая.Close();
        };
            следующаяФорма.Show();
            текущая.Hide();
        }
        public static void загрузкаФормыВправо(Form mainForm, Form formToLoad, SplitContainer splitContainer)
        {
            // Очищаем Panel2
            splitContainer.Panel2.Controls.Clear();

            // Настраиваем форму
            formToLoad.TopLevel = false;
            formToLoad.FormBorderStyle = FormBorderStyle.None;
            formToLoad.Dock = DockStyle.Fill;

            // Добавляем форму в Panel2
            splitContainer.Panel2.Controls.Add(formToLoad);
            formToLoad.Show();
        }
    }
}


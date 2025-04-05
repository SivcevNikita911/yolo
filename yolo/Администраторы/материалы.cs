using System;
using System.Linq;
using System.Windows.Forms;

namespace yolo
{
    public partial class материалы : Form
    {
        public материалы()
        {
            InitializeComponent();
            ЗагрузитьМатериалы();
        }

        public void ЗагрузитьМатериалы()
        {
            try
            {
                using (var db = new DbHelper())
                {
                    // Загружаем список материалов
                    var списокМатериалов = db.Материалы.ToList();
                    dataGridViewМатериалы.DataSource = списокМатериалов;

                    // Проверяем, если колонка "id" уже есть, делаем её только для чтения
                    if (dataGridViewМатериалы.Columns.Contains("id"))
                    {
                        dataGridViewМатериалы.Columns["id"].ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message + "\n" + ex.InnerException?.Message);
            }
        }


        private void ОбновитьДанныеВБазе(int id, string название, int ценаЗаШтуку, int количество)
        {
            using (var db = new DbHelper())
            {
                try
                {
                    var материал = db.Материалы.FirstOrDefault(m => m.id == id);
                    if (материал != null)
                    {
                        материал.название = название;
                        материал.ценаЗаШтуку = ценаЗаШтуку;
                        материал.количество = количество;

                        // Сохраняем изменения в базе данных
                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка обновления данных: " + ex.Message);
                }
            }
        }

        // Обработчик события на изменение данных
        private void change_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewМатериалы.Rows)
            {
                if (row.IsNewRow) continue;

                var id = (int)row.Cells["id"].Value;
                var название = row.Cells["название"].Value.ToString();
                var ценаЗаШтуку = Convert.ToInt32(row.Cells["ценаЗаШтуку"].Value);
                var количество = Convert.ToInt32(row.Cells["количество"].Value);

                // Обновляем данные в базе через DbHelper
                ОбновитьДанныеВБазе(id, название, ценаЗаШтуку, количество);
            }
        }
    }
}

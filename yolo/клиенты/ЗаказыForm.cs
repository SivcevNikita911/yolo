using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace yolo
{
    public partial class ЗаказыForm : Form
    {
        public ЗаказыForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            ЗагрузкаЗаказов();
        }

        private void InitializeDataGridView()
        {
            // Очищаем существующие столбцы
            dataGridViewЗаказы.Columns.Clear();

            // Добавляем столбцы
            dataGridViewЗаказы.Columns.Add("номер_заказа", "Номер заказа");
            dataGridViewЗаказы.Columns.Add("статус", "Статус");
            dataGridViewЗаказы.Columns.Add("дата", "Дата");
            dataGridViewЗаказы.Columns.Add("общая_цена", "Общая цена");

            // Создаем раскрывающийся столбец для товаров
            var товарыColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Товары",
                Name = "товарыColumn",
                DefaultCellStyle = { NullValue = "ПРОСМОТРЕТЬ СПИСОК ИГРУШЕК" } // Устанавливаем текст по умолчанию

            };
            // Вычисляем ширину текста "ПРОСМОТРЕТЬ СПИСОК ИГРУШЕК"
            var textSize = TextRenderer.MeasureText("ПРОСМОТРЕТЬ СПИСОК ИГРУШЕК", dataGridViewЗаказы.Font);
            товарыColumn.Width = textSize.Width + 20; // Добавляем небольшой отступ для визуального комфорта


            dataGridViewЗаказы.Columns.Add(товарыColumn);
            // Устанавливаем колонку "Товары" на вторую позицию
            dataGridViewЗаказы.Columns["товарыColumn"].DisplayIndex = 1;

        }

        private void ЗагрузкаЗаказов()
        {
            using (var db = new DbHelper())
            {
                try
                {
                    // Фильтруем заказы по текущему клиенту
                    var заказы = db.Заказы
                        .Where(z => z.Клиент_id == mainForm.текущийКлиентId)
                        .ToList()
                        .Select(z => new
                        {
                            z.id,
                            z.номер_заказа,
                            z.статус,
                            z.дата,
                            Товары = z.ПолучитьТовары().Select(t => $"{t.название} (x{t.количество})").ToList(),
                            z.общая_цена
                        })
                        .ToList();

                    // Привязываем данные к DataGridView
                    foreach (var заказ in заказы)
                    {
                        var rowIndex = dataGridViewЗаказы.Rows.Add(
                            заказ.номер_заказа,
                            заказ.статус,
                            заказ.дата,
                            заказ.общая_цена
                        );

                        // Заполняем раскрывающийся список для товаров
                        var товарыColumn = (DataGridViewComboBoxCell)dataGridViewЗаказы.Rows[rowIndex].Cells["товарыColumn"];
                        товарыColumn.DataSource = заказ.Товары;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки заказов: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

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
    public partial class ЗаказыForm: Form
    {
        public ЗаказыForm()
        {
            InitializeComponent();
            ЗагрузкаЗаказов();
        }
        private void ЗагрузкаЗаказов()
        {
            using (var db = new DbHelper())
            {
                try
                {
                    // Фильтруем заказы по текущему клиенту
                    var заказы = db.Заказы
                        .Where(z => z.Клиент_id == mainForm.текущийКлиентId) // Фильтрация по id клиента
                        .ToList() // Загружаем данные в память
                        .Select(z => new
                        {
                            z.id,
                            z.номер_заказа,
                            z.статус,
                            z.дата,
                            Товары = string.Join(", ", z.ПолучитьТовары().Select(t => $"{t.название} (x{t.количество})")),
                            z.общая_цена
                        })
                        .ToList();

                    // Привязываем данные к DataGridView
                    dataGridViewЗаказы.DataSource = заказы;
                    dataGridViewЗаказы.Columns["id"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки заказов: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

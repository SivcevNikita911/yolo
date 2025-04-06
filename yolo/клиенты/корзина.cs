using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

namespace yolo
{
    public partial class корзина : Form
    {
        public корзина()
        {
            InitializeComponent();
            ЗагрузитьКорзину();
            ОбновитьОбщуюЦену();
        }

        public void ЗагрузитьКорзину()
        {
            try
            {
                using (var db = new DbHelper())
                {
                    // Получаем товары из корзины только для текущего клиента
                    var Корзина = db.Корзина
                        .Where(c => c.Клиент_id == mainForm.текущийКлиентId) // Фильтруем по id клиента
                        .Join(db.Каталог, корзина => корзина.товар_id, каталог => каталог.id,
                            (корзина, каталог) => new
                            {
                                корзина.id,
                                корзина.товар_id,
                                корзина.цена,
                                корзина.количество,
                                каталог.название
                            })
                        .ToList();

                    // Заполняем DataGridView данными
                    dataGridViewКорзина.DataSource = Корзина;

                    dataGridViewКорзина.Columns["id"].Visible = false;
                    dataGridViewКорзина.Columns["товар_id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки корзины: " + ex.Message);
            }
        }

        public void ОбновитьОбщуюЦену()
        {
            try
            {
                using (var db = new DbHelper())
                {
                    var общаяЦена = db.Корзина
                        .Where(c => c.Клиент_id == mainForm.текущийКлиентId)
                        .Sum(c => c.цена * c.количество);

                    ценаЗаВсе.Text = $"{общаяЦена}.руб.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подсчета общей цены: " + ex.Message);
            }
        }

        private void заказать_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
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
        }
        public void ЗагрузитьКорзину()
        {
            try
            {
                using (var db = new DbHelper())
                {
                    // Получаем товары из корзины только для текущего клиента
                    var списокМатериалов = db.Корзина
                        .Where(c => c.Клиент_id == mainForm.текущийКлиентId) // Фильтруем по id клиента
                        .Join(db.Каталог, корзина => корзина.товар_id, каталог => каталог.id,
                            (корзина, каталог) => new
                            {
                                корзина.id,
                                корзина.товар_id,
                                корзина.цена,
                                корзина.количество,
                                каталог.название // Показываем название товара из каталога
                            })
                        .ToList();

                    // Заполняем DataGridView данными
                    dataGridViewКорзина.DataSource = списокМатериалов;

                    // Проверяем, если колонка "id" уже есть, скрываем её и делаем только для чтения
                    if (dataGridViewКорзина.Columns.Contains("id"))
                    {
                        dataGridViewКорзина.Columns["id"].Visible = false;  // Скрыть колонку
                        dataGridViewКорзина.Columns["id"].ReadOnly = true;   // Сделать её только для чтения
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки корзины: " + ex.Message);
            }
        }

    }
}

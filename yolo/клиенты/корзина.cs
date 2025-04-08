using System;
using System.Collections.Generic;
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
                        .Sum(c => (int?)c.цена * c.количество) ?? 0; // Используем Nullable<int> для обработки пустой корзины

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
            try
            {
                using (var db = new DbHelper())
                {
                    // Получаем товары из корзины для текущего клиента
                    var корзина = db.Корзина
                        .Where(c => c.Клиент_id == mainForm.текущийКлиентId)
                        .ToList();

                    // Проверяем, пуста ли корзина
                    if (!корзина.Any())
                    {
                        MessageBox.Show("Корзина пуста. Добавьте товары перед оформлением заказа.",
                                        "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Формируем список товаров для заказа
                    var товары = корзина.Select(c => new Товар
                    {
                        название = db.Каталог.FirstOrDefault(k => k.id == c.товар_id)?.название,
                        количество = c.количество,
                        цена = c.цена
                    }).ToList();

                    // Создаем новый заказ
                    var новыйЗаказ = СоздатьЗаказ(товары);

                    // Добавляем заказ в базу данных
                    db.Заказы.Add(новыйЗаказ);

                    // Очищаем корзину
                    db.Корзина.RemoveRange(корзина);

                    // Сохраняем изменения
                    db.SaveChanges();

                    // Обновляем интерфейс
                    ЗагрузитьКорзину();
                    ОбновитьОбщуюЦену();

                    MessageBox.Show("Заказ успешно оформлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при оформлении заказа: {ex.Message}",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Заказы СоздатьЗаказ(List<Товар> товары)
        {
            return new Заказы
            {
                номер_заказа = Guid.NewGuid().ToString().Substring(0, 8), // Генерируем уникальный номер заказа
                статус = "Ожидает обработки",
                дата = DateTime.Now,
                общая_цена = товары.Sum(t => t.цена * t.количество),
                Клиент_id = mainForm.текущийКлиентId, // Привязываем заказ к текущему клиенту
                товары = Newtonsoft.Json.JsonConvert.SerializeObject(товары) // Сериализуем список товаров
            };
        }
    }
}

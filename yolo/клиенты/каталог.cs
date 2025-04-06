using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace yolo
{
    public partial class каталог : Form
    {
        public каталог()
        {
            InitializeComponent();
            ЗагрузитьКаталогДляТекущегоПользователя();
            dataGridViewКаталог.CellClick += dataGridViewКаталог_CellClick;
        }

        private void ЗагрузитьКаталогДляТекущегоПользователя()
        {
            ОчиститьТекущиеДанные();
            using (var db = new DbHelper())
            {
                var Каталог = db.Каталог.ToList();
                ПривязатьДанныеКDataGridView(Каталог);
                ДобавитьСтолбцы();
                СинхронизироватьСКорзиной(db, Каталог);
                dataGridViewКаталог.Columns["id"].Visible = false;
            }
        }

        private void ОчиститьТекущиеДанные()
        {
            dataGridViewКаталог.Rows.Clear();
        }

        private void ПривязатьДанныеКDataGridView(object данные)
        {
            dataGridViewКаталог.DataSource = данные;
        }

        private void ДобавитьСтолбцы()
        {
            AddButtonColumns();
        }

        private void СинхронизироватьСКорзиной(DbHelper db, List<Каталог> списокКаталога)
        {
            var клиент = db.Клиенты.FirstOrDefault(k => k.имя == mainForm.текущийЛогин);
            if (клиент != null)
            {
                var корзина = db.Корзина.Where(c => c.Клиент_id == клиент.id).ToList();
                foreach (var товар in списокКаталога)
                {
                    var корзинаТовара = корзина.FirstOrDefault(c => c.товар_id == товар.id);
                    товар.количество_в_корзине = корзинаТовара?.количество ?? 0;
                }
                ПривязатьДанныеКDataGridView(списокКаталога);
            }
        }

        private void AddButtonColumns()
        {
            if (!dataGridViewКаталог.Columns.Contains("+количество_в_корзине"))
            {
                var plusColumn = new DataGridViewButtonColumn
                {
                    Name = "+количество_в_корзине",
                    Text = "+",
                    UseColumnTextForButtonValue = true
                };
                dataGridViewКаталог.Columns.Add(plusColumn);
            }

            if (!dataGridViewКаталог.Columns.Contains("-количество_в_корзине"))
            {
                var minusColumn = new DataGridViewButtonColumn
                {
                    Name = "-количество_в_корзине",
                    Text = "-",
                    UseColumnTextForButtonValue = true
                };
                dataGridViewКаталог.Columns.Add(minusColumn);
            }
        }

        private void dataGridViewКаталог_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var товарId = (int)dataGridViewКаталог.Rows[e.RowIndex].Cells["id"].Value;
                using (var db = new DbHelper())
                {
                    if (dataGridViewКаталог.Columns[e.ColumnIndex].Name == "+количество_в_корзине")
                    {
                        ОбработатьКнопкуПлюс(db, e.RowIndex, товарId);
                        MessageBox.Show("товар добавлен");
                    }
                    else if (dataGridViewКаталог.Columns[e.ColumnIndex].Name == "-количество_в_корзине")
                    {
                        ОбработатьКнопкуМинус(db, e.RowIndex, товарId);
                        MessageBox.Show("товар убран");
                    }
                }
            }
        }

        private void ОбработатьКнопкуПлюс(DbHelper db, int rowIndex, int товарId)
        {
            var currentQty = (int)dataGridViewКаталог.Rows[rowIndex].Cells["количество_в_корзине"].Value;
            dataGridViewКаталог.Rows[rowIndex].Cells["количество_в_корзине"].Value = currentQty + 1;

            var товар = db.Каталог.FirstOrDefault(t => t.id == товарId);
            if (товар != null)
            {
                товар.количество_в_корзине = currentQty + 1;
            }

            var клиент = db.Клиенты.FirstOrDefault(k => k.имя == mainForm.текущийЛогин);
            if (клиент != null)
            {
                var текущаяКорзина = db.Корзина.FirstOrDefault(c => c.Клиент_id == клиент.id && c.товар_id == товарId);
                if (текущаяКорзина != null)
                {
                    текущаяКорзина.количество += 1;
                }
                else
                {
                    db.Корзина.Add(new Корзина
                    {
                        Клиент_id = клиент.id,
                        товар_id = товар.id,
                        цена = товар.цена,
                        количество = 1
                    });
                }
                db.SaveChanges();
            }
        }

        private void ОбработатьКнопкуМинус(DbHelper db, int rowIndex, int товарId)
        {
            var currentQty = (int)dataGridViewКаталог.Rows[rowIndex].Cells["количество_в_корзине"].Value;
            if (currentQty > 0)
            {
                dataGridViewКаталог.Rows[rowIndex].Cells["количество_в_корзине"].Value = currentQty - 1;

                var товар = db.Каталог.FirstOrDefault(t => t.id == товарId);
                if (товар != null)
                {
                    товар.количество_в_корзине = currentQty - 1;
                }

                var клиент = db.Клиенты.FirstOrDefault(k => k.имя == mainForm.текущийЛогин);
                if (клиент != null)
                {
                    var текущаяКорзина = db.Корзина.FirstOrDefault(c => c.Клиент_id == клиент.id && c.товар_id == товарId);
                    if (текущаяКорзина != null && текущаяКорзина.количество > 0)
                    {
                        текущаяКорзина.количество -= 1;
                        if (текущаяКорзина.количество == 0)
                        {
                            db.Корзина.Remove(текущаяКорзина);
                        }
                    }
                    db.SaveChanges();
                }
            }
            else
            {
                УдалитьТоварИзКорзины(db, товарId);
            }
        }

        private void УдалитьТоварИзКорзины(DbHelper db, int товарId)
        {
            var клиент = db.Клиенты.FirstOrDefault(k => k.имя == mainForm.текущийЛогин);
            if (клиент != null)
            {
                var текущаяКорзина = db.Корзина.FirstOrDefault(c => c.Клиент_id == клиент.id && c.товар_id == товарId);
                if (текущаяКорзина != null)
                {
                    db.Корзина.Remove(текущаяКорзина);
                    db.SaveChanges();
                }
            }
        }
    }
}
using System;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace yolo
{
    public partial class каталог : Form
    {
        public каталог()
        {
            InitializeComponent();
            ЗагрузитьКаталог();
        }

        private void ЗагрузитьКаталог()
        {
            using (var db = new DbHelper())
            {
                var списокКаталога = db.Каталог.ToList();
                dataGridViewКаталог.DataSource = списокКаталога;

                if (!dataGridViewКаталог.Columns.Contains("Количество"))
                {
                    DataGridViewTextBoxColumn qtyColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "Количество",
                        HeaderText = "Количество",
                        ValueType = typeof(int),
                        DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
                    };
                    dataGridViewКаталог.Columns.Add(qtyColumn);
                }

                if (!dataGridViewКаталог.Columns.Contains("Управление"))
                {
                    DataGridViewButtonColumn manageColumn = new DataGridViewButtonColumn
                    {
                        Name = "Управление",
                        HeaderText = "Изменить",
                        Text = "+ / -",
                        UseColumnTextForButtonValue = true
                    };
                    dataGridViewКаталог.Columns.Add(manageColumn);
                }

                dataGridViewКаталог.CellClick += dataGridViewКаталог_CellClick;
            }
        }
        private void dataGridViewКаталог_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewКаталог.Columns[e.ColumnIndex].Name == "Управление" && e.RowIndex >= 0)
            {
                var qtyCell = dataGridViewКаталог.Rows[e.RowIndex].Cells["Количество"];

                int qty = 0;
                if (qtyCell.Value != null)
                    int.TryParse(qtyCell.Value.ToString(), out qty);

                var result = MessageBox.Show("Увеличить количество?", "Добавить/Убрать", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    qty++;
                }
                else if (result == DialogResult.No && qty > 0)
                {
                    qty--;
                }

                qtyCell.Value = qty;
            }
        }
    }
}
using System;
using System.Data;
using System.Data.SQLite;
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
            string connectionString = "Data Source=C:\\Users\\r2d2\\Desktop\\yolo\\yolo\\БД\\bdIgrushki.db";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Каталог";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridViewКаталог.DataSource = table;

                // Автоматическое масштабирование столбцов
                dataGridViewКаталог.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Проверка: если уже добавлены, то не дублируем
                if (!dataGridViewКаталог.Columns.Contains("Количество"))
                {
                    // Добавление столбца "Количество"
                    DataGridViewTextBoxColumn qtyColumn = new DataGridViewTextBoxColumn();
                    qtyColumn.Name = "Количество";
                    qtyColumn.HeaderText = "Количество";
                    qtyColumn.ValueType = typeof(int);
                    qtyColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridViewКаталог.Columns.Add(qtyColumn);
                }

                if (!dataGridViewКаталог.Columns.Contains("Управление"))
                {
                    // Добавление столбца с кнопками + и -
                    DataGridViewButtonColumn manageColumn = new DataGridViewButtonColumn();
                    manageColumn.Name = "Управление";
                    manageColumn.HeaderText = "Изменить";
                    manageColumn.Text = "+ / -";
                    manageColumn.UseColumnTextForButtonValue = true;
                    dataGridViewКаталог.Columns.Add(manageColumn);
                }

                // Обработка кликов по кнопкам
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
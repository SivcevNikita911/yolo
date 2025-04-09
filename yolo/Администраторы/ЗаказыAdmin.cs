using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yolo
{
    public partial class ЗаказыAdmin : Form
    {
        public ЗаказыAdmin()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadClientsAsync();
        }

        private void InitializeDataGridView()
        {
            // Очищаем существующие столбцы
            dataGridViewЗаказы.Columns.Clear();

            // Создаем столбец ComboBox для выбора клиентов
            var clientColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Клиенты",
                Name = "ClientColumn",

                DefaultCellStyle = { NullValue = "Выберите клиента" }
            };
            dataGridViewЗаказы.Columns.Add(clientColumn);
            clientColumn.Width = 125; // Укажите подходящее значение ширины.


            // Подключаем обработчики событий
            dataGridViewЗаказы.CellValueChanged += DataGridView_CellValueChanged;
            dataGridViewЗаказы.CurrentCellDirtyStateChanged += DataGridView_CurrentCellDirtyStateChanged;
        }

        private async void LoadClientsAsync()
        {
            try
            {
                using (var db = new DbHelper())
                {
                    var clients = await Task.Run(() => db.Клиенты.Select(c => new { c.id, c.имя }).ToList());
                    var clientColumn = (DataGridViewComboBoxColumn)dataGridViewЗаказы.Columns["ClientColumn"];
                    clientColumn.DataSource = clients;
                    clientColumn.DisplayMember = "имя";
                    clientColumn.ValueMember = "id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки клиентов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewЗаказы.IsCurrentCellDirty)
            {
                dataGridViewЗаказы.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private async void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewЗаказы.Columns["ClientColumn"].Index)
            {
                var selectedClientId = dataGridViewЗаказы.Rows[e.RowIndex].Cells["ClientColumn"].Value;
                if (selectedClientId is int clientId)
                {
                    await LoadOrdersAsync(clientId);
                }
            }
        }

        private async Task LoadOrdersAsync(int clientId)
        {
            try
            {
                using (var db = new DbHelper())
                {
                    var orders = await Task.Run(() =>
                        db.Заказы
                            .Where(o => o.Клиент_id == clientId)
                            .Select(o => new
                            {
                                o.номер_заказа,
                                o.статус,
                                o.дата,
                                o.общая_цена
                            })
                            .ToList()
                    );

                    if (orders.Any())
                    {
                        dataGridViewЗаказы.DataSource = orders;
                    }
                    else
                    {
                        MessageBox.Show("Для выбранного клиента нет заказов.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewЗаказы.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки заказов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

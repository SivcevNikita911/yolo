using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yolo
{
    public partial class Доставка : Form
    {
        public Доставка()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadClientsAsync();
        }

        private void InitializeDataGridView()
        {
            // Очищаем существующие столбцы
            dataGridViewДоставка.Columns.Clear();

            // Создаем столбец ComboBox для выбора клиентов
            var clientColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Клиенты",
                Name = "ClientColumn",
                DefaultCellStyle = { NullValue = "Выберите клиента" }
            };
            dataGridViewДоставка.Columns.Add(clientColumn);
            clientColumn.Width = 125;

            // Создаем столбец с кнопкой
            var buttonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Действие",
                Name = "ActionButtonColumn",
                Text = "Изменить статус",
                UseColumnTextForButtonValue = true
            };
            dataGridViewДоставка.Columns.Add(buttonColumn);

            // Подключаем обработчики событий
            dataGridViewДоставка.CellValueChanged += DataGridView_CellValueChanged;
            dataGridViewДоставка.CurrentCellDirtyStateChanged += DataGridView_CurrentCellDirtyStateChanged;
            dataGridViewДоставка.CellClick += DataGridView_CellClick;
        }

        private async void LoadClientsAsync()
        {
            try
            {
                using (var db = new DbHelper())
                {
                    var clients = await Task.Run(() => db.Клиенты.Select(c => new { c.id, c.имя }).ToList());
                    var clientColumn = (DataGridViewComboBoxColumn)dataGridViewДоставка.Columns["ClientColumn"];
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
            if (dataGridViewДоставка.IsCurrentCellDirty)
            {
                dataGridViewДоставка.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private async void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewДоставка.Columns["ClientColumn"].Index)
            {
                var selectedClientId = dataGridViewДоставка.Rows[e.RowIndex].Cells["ClientColumn"].Value;
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
                        dataGridViewДоставка.DataSource = orders;
                    }
                    else
                    {
                        MessageBox.Show("Для выбранного клиента нет заказов.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewДоставка.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки заказов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что нажата кнопка в столбце ActionButtonColumn
            if (e.ColumnIndex == dataGridViewДоставка.Columns["ActionButtonColumn"].Index && e.RowIndex >= 0)
            {
                var row = dataGridViewДоставка.Rows[e.RowIndex];
                var orderIdValue = row.Cells["номер_заказа"].Value; // Предполагается, что номер заказа есть в строке

                if (orderIdValue != null)
                {
                    string orderId = orderIdValue.ToString(); // Преобразуем значение в строку
                    try
                    {
                        using (var db = new DbHelper())
                        {
                            // Обновляем статус в базе данных
                            var order = db.Заказы.FirstOrDefault(o => o.номер_заказа == orderId);
                            if (order != null)
                            {
                                order.статус = "отправлен на доставку";
                                await db.SaveChangesAsync();

                                // Обновляем статус в интерфейсе
                                row.Cells["статус"].Value = "отправлен на доставку";
                                MessageBox.Show("Статус успешно обновлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Заказ с указанным номером не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка обновления статуса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Номер заказа отсутствует в строке.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

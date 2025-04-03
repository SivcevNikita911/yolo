using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yolo
{
    public partial class материалы : Form
    {
        public материалы()
        {
            InitializeComponent();
            ЗагрузитьМатериалы();
        }

        // Загружаем материалы в DataGridView
        public void ЗагрузитьМатериалы()
        {
            string connectionString = "Data Source=C:\\Users\\r2d2\\Desktop\\yolo\\yolo\\БД\\bdIgrushki.db";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Материалы";

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection); // Указываем запрос и соединение
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewМатериалы.DataSource = dataTable;

                    // Делаем столбец "id" только для чтения
                    dataGridViewМатериалы.Columns["id"].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
                }
            }
        }

        // Обработчик события изменения данных в DataGridView
        private void dataGridViewМатериалы_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Опционально, можно обрабатывать изменение в реальном времени, если это необходимо.
        }


        private void ОбновитьДанныеВБазе(object id, string название, int ценаЗаШтуку, int количество)
        {
            string connectionString = "Data Source=C:\\Users\\r2d2\\Desktop\\yolo\\yolo\\БД\\bdIgrushki.db";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    string updateQuery = "UPDATE Материалы SET название = @название, ценаЗаШтуку = @ценаЗаШтуку, количество = @количество WHERE id = @id";
                    SQLiteCommand command = new SQLiteCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@название", название);
                    command.Parameters.AddWithValue("@ценаЗаШтуку", ценаЗаШтуку);
                    command.Parameters.AddWithValue("@количество", количество);
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    command.ExecuteNonQuery(); // Выполнение запроса на обновление
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка обновления данных: " + ex.Message);
                }
            }
        }

        // Событие на кнопку "Изменить"
        private void change_Click(object sender, EventArgs e)
        {
            // Итерация по всем строкам в DataGridView
            foreach (DataGridViewRow row in dataGridViewМатериалы.Rows)
            {
                if (row.IsNewRow) continue; // Пропустить новую строку, если таковая есть

                var id = row.Cells["id"].Value;
                var название = row.Cells["название"].Value.ToString();
                var ценаЗаШтуку = Convert.ToInt32(row.Cells["ценаЗаШтуку"].Value);
                var количество = Convert.ToInt32(row.Cells["количество"].Value);

                // Обновляем данные в базе данных
                ОбновитьДанныеВБазе(id, название, ценаЗаШтуку, количество);
            }
        }
    }
}
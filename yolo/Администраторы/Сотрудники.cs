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
    public partial class Сотрудники : Form
    {
        public Сотрудники()
        {
            InitializeComponent();
            ЗагрузкаСотрудников();
            ЗагрузкаДолжностей();
            добавитьСотрудника.Enabled = false;
        }

        public void ЗагрузкаСотрудников()
        {
            using (var db = new DbHelper())
            {
                try
                {
                    var списокСотрудников = db.сотрудники.ToList();
                    dataGridViewСотрудники.DataSource = списокСотрудников;

                    dataGridViewСотрудники.Columns["id"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
                }
            }
        }

        public void ЗагрузкаДолжностей()
        {
            using (var db = new DbHelper())
            {
                try
                {
                    var списокДолжностей = db.Должности.ToList();
                    comboBoxДолжности.DataSource = списокДолжностей;
                    comboBoxДолжности.DisplayMember = "Название";
                    comboBoxДолжности.ValueMember = "id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки должностей: " + ex.Message);
                }
            }
        }

        private void добавитьСотрудника_Click(object sender, EventArgs e)
        {
            using (var db = new DbHelper())
            {
                try
                {
                    var новыйСотрудник = new сотрудники
                    {
                        ФИО = inputФИО.Text,
                        должность_id = (int)comboBoxДолжности.SelectedValue,
                        телефон = inputТелефон.Text,
                        зарплата = long.Parse(inputЗарплата.Text)
                    };

                    db.сотрудники.Add(новыйСотрудник);
                    db.SaveChanges();
                    ЗагрузкаСотрудников();
                    MessageBox.Show("Сотрудник добавлен успешно!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка добавления сотрудника: " + ex.Message);
                }
            }
        }

        private void inputФИО_TextChanged(object sender, EventArgs e)
        {
            ПроверкаЗаполненностиПолей();
        }

        private void comboBoxДолжности_SelectedIndexChanged(object sender, EventArgs e)
        {
            ПроверкаЗаполненностиПолей();
        }

        private void inputТелефон_TextChanged(object sender, EventArgs e)
        {
            ПроверкаЗаполненностиПолей();
        }

        private void inputЗарплата_TextChanged(object sender, EventArgs e)
        {
            ПроверкаЗаполненностиПолей();
        }

        private void ПроверкаЗаполненностиПолей()
        {
            добавитьСотрудника.Enabled = !string.IsNullOrWhiteSpace(inputФИО.Text) &&
            comboBoxДолжности.SelectedIndex != -1 &&
            !string.IsNullOrWhiteSpace(inputТелефон.Text) &&
            !string.IsNullOrWhiteSpace(inputЗарплата.Text);
        }
    }
}

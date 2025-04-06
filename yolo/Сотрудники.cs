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
    public partial class Сотрудники: Form
    {
        public Сотрудники()
        {
            InitializeComponent();
            ЗагрузкаСотрудников();
        }
        public void ЗагрузкаСотрудников ()
        {
            using (var db = new DbHelper())
            {
                var списокСотрудников = db.Каталог.ToList();//исправь
                dataGridViewСотрудники.DataSource = списокСотрудников;
            }
        }

        private void изменитьСотрудников_Click(object sender, EventArgs e)
        {

        }
    }
}

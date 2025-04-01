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
    public partial class testForm : Form
    {
        private DbHelper db;
        public testForm()
        {
            InitializeComponent();
            selectКлиенты();
        }

        private void selectКлиенты()
        {
            db = new DbHelper();
            List<Клиенты> клиенты = db.Клиенты.ToList();
            foreach (Клиенты клиент in клиенты)
            {
                string strКлиенты = $"| id={клиент.id}  login = {клиент.имя} почта = {клиент.почта} password={клиент.пароль} ";
                selectКлинты.Items.Add(strКлиенты);
            }
        }

        private void selectКлинты_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
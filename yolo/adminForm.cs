using System;
using System.Windows.Forms;

namespace yolo
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
            Helper.цветДляПереходов(label8);
        }

        private void backToАвторизация_Click(object sender, EventArgs e)
        {
            Helper.переход(this, new авторизация());
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Helper.переход(this, new авторизация());
        }

        private void adminПерехходКматериалам_Click(object sender, EventArgs e)
        {
            Helper.загрузкаФормыВправо(this, new материалы(), splitContainer1);
        }

        private void adminПерехходКсотрудникам_Click(object sender, EventArgs e)
        {
            Helper.загрузкаФормыВправо(this, new Сотрудники(), splitContainer1);
        }
    }
}

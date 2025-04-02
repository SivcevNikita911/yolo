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
    public partial class adminForm: Form
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
    }
}

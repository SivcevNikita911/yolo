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
    public partial class mainForm: Form
    {
        public mainForm()
        {
            InitializeComponent();
            Helper.цветДляПереходов(label8);
            Helper.цветДляПереходов(переходКконтактам);
        }
        public void SetClientProfile(string clientName)
        {
            профильКлиента.Text = clientName;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Helper.переход(this, new авторизация());
        }

        private void переходКконтактам_Click(object sender, EventArgs e)
        {
            Helper.переход(this, new контакты());
        }

        private void профильКлиента_Click(object sender, EventArgs e)
        {
            Helper.загрузкаФормыВправо(this, new профильПользователя(), splitContainer1);
        }
    }
}

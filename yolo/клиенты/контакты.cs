using System;
using System.Windows.Forms;

namespace yolo
{
    public partial class контакты : Form
    {
        public контакты()
        {
            InitializeComponent();
            Helper.цветДляПереходов(label8);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Helper.переход(this, new mainForm());
        }
    }
}

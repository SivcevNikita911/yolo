using System;
using System.Linq;
using System.Windows.Forms;

namespace yolo
{
    public partial class профильПользователя : Form
    {
        private string currentLogin;

        public профильПользователя(string login)
        {
            InitializeComponent();
        }

        private Button ButtonChangeProfile;
        private Label label4;
        private TextBox inputPasswordchange;
        private Label label3;
        private TextBox inputLoginchange;
        private Label label2;
        private TextBox inputMaillchange;
        private Label label1;
    }
}
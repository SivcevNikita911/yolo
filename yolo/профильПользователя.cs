using System;
using System.Linq;
using System.Windows.Forms;

namespace yolo
{
    public partial class профильПользователя : Form
    {
        public event Action<string> ProfileUpdated;

        public профильПользователя(string clientMaill, string clientLogin, string clientPassword)
        {
            InitializeComponent();
            SetClientMaill(clientMaill);
            SetClientLogin(clientLogin);
            SetClientPassword(clientPassword);
        }

        public профильПользователя()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.ButtonChangeProfile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.inputPasswordchange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputLoginchange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputMaillchange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonChangeProfile
            // 
            this.ButtonChangeProfile.BackColor = System.Drawing.Color.Violet;
            this.ButtonChangeProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonChangeProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChangeProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonChangeProfile.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonChangeProfile.ForeColor = System.Drawing.Color.Yellow;
            this.ButtonChangeProfile.Location = new System.Drawing.Point(31, 285);
            this.ButtonChangeProfile.Name = "ButtonChangeProfile";
            this.ButtonChangeProfile.Size = new System.Drawing.Size(240, 65);
            this.ButtonChangeProfile.TabIndex = 16;
            this.ButtonChangeProfile.Text = "change up";
            this.ButtonChangeProfile.UseVisualStyleBackColor = false;
            this.ButtonChangeProfile.Click += new System.EventHandler(this.ButtonChangeProfile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Jokerman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(11, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 33);
            this.label4.TabIndex = 15;
            this.label4.Text = "password";
            // 
            // inputPasswordchange
            // 
            this.inputPasswordchange.BackColor = System.Drawing.Color.Violet;
            this.inputPasswordchange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPasswordchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputPasswordchange.Location = new System.Drawing.Point(17, 246);
            this.inputPasswordchange.Multiline = true;
            this.inputPasswordchange.Name = "inputPasswordchange";
            this.inputPasswordchange.Size = new System.Drawing.Size(285, 33);
            this.inputPasswordchange.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Jokerman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(11, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "login";
            // 
            // inputLoginchange
            // 
            this.inputLoginchange.BackColor = System.Drawing.Color.Violet;
            this.inputLoginchange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputLoginchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputLoginchange.Location = new System.Drawing.Point(17, 182);
            this.inputLoginchange.Multiline = true;
            this.inputLoginchange.Name = "inputLoginchange";
            this.inputLoginchange.Size = new System.Drawing.Size(285, 33);
            this.inputLoginchange.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Jokerman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(69, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "maill";
            // 
            // inputMaillchange
            // 
            this.inputMaillchange.BackColor = System.Drawing.Color.Violet;
            this.inputMaillchange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputMaillchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputMaillchange.Location = new System.Drawing.Point(17, 117);
            this.inputMaillchange.Multiline = true;
            this.inputMaillchange.Name = "inputMaillchange";
            this.inputMaillchange.Size = new System.Drawing.Size(285, 33);
            this.inputMaillchange.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(158, 58);
            this.label1.TabIndex = 17;
            this.label1.Text = "profile";
            // 
            // профильПользователя
            // 
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(320, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonChangeProfile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputPasswordchange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputLoginchange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputMaillchange);
            this.Name = "профильПользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ButtonChangeProfile_Click(object sender, EventArgs e)
        {
            string newEmail = inputMaillchange.Text;
            string newLogin = inputLoginchange.Text;
            string newPassword = inputPasswordchange.Text;

            // Обновление значений
            SetClientMaill(newEmail);
            SetClientLogin(newLogin);
            SetClientPassword(newPassword);

            // Сохранение изменений
            SaveClientData(newEmail, newLogin, newPassword);

            // Уведомление о том, что профиль обновлен
            ProfileUpdated?.Invoke(newLogin);

            MessageBox.Show("Профиль успешно обновлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveClientData(string email, string login, string password)
        {
            using (var db = new DbHelper())
            {
                var клиент = db.Клиенты.FirstOrDefault(k => k.имя == mainForm.текущийЛогин);
                if (клиент != null)
                {
                    клиент.почта = email;
                    клиент.имя = login;
                    клиент.пароль = password;
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Ошибка", "Произошла ошибка при сохранении данных пользователя");
                }
            }
        }

        public void SetClientMaill(string clientMaill)
        {
            inputMaillchange.Text = clientMaill;
        }

        public void SetClientLogin(string clientLogin)
        {
            inputLoginchange.Text = clientLogin;
        }

        public void SetClientPassword(string clientPassword)
        {
            inputPasswordchange.Text = clientPassword;
        }
    }
}
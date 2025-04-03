namespace yolo
{
    partial class авторизация
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.logInUser = new System.Windows.Forms.Button();
            this.createAccount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.logInUser);
            this.panel1.Controls.Add(this.createAccount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 466);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Violet;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(116, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 80);
            this.button1.TabIndex = 3;
            this.button1.Text = "Admin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logInUser
            // 
            this.logInUser.BackColor = System.Drawing.Color.Violet;
            this.logInUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logInUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logInUser.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInUser.ForeColor = System.Drawing.Color.Yellow;
            this.logInUser.Location = new System.Drawing.Point(116, 136);
            this.logInUser.Name = "logInUser";
            this.logInUser.Size = new System.Drawing.Size(240, 80);
            this.logInUser.TabIndex = 2;
            this.logInUser.Text = "user";
            this.logInUser.UseVisualStyleBackColor = false;
            this.logInUser.Click += new System.EventHandler(this.logInUser_Click);
            // 
            // createAccount
            // 
            this.createAccount.AutoSize = true;
            this.createAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccount.Font = new System.Drawing.Font("Jokerman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccount.ForeColor = System.Drawing.Color.Yellow;
            this.createAccount.Location = new System.Drawing.Point(165, 378);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(143, 55);
            this.createAccount.TabIndex = 1;
            this.createAccount.Text = "Sign in";
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(165, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log in";
            // 
            // авторизация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 466);
            this.Controls.Add(this.panel1);
            this.Name = "авторизация";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logInUser;
        private System.Windows.Forms.Label createAccount;
        private System.Windows.Forms.Button button1;
    }
}


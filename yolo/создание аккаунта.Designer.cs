namespace yolo
{
    partial class создание_аккаунта
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveKlient = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputMaill = new System.Windows.Forms.TextBox();
            this.backToАвторизация = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.saveKlient);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.inputPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.inputLogin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.inputMaill);
            this.panel1.Controls.Add(this.backToАвторизация);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 386);
            this.panel1.TabIndex = 1;
            // 
            // saveKlient
            // 
            this.saveKlient.BackColor = System.Drawing.Color.Violet;
            this.saveKlient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveKlient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveKlient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveKlient.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveKlient.ForeColor = System.Drawing.Color.Yellow;
            this.saveKlient.Location = new System.Drawing.Point(100, 309);
            this.saveKlient.Name = "saveKlient";
            this.saveKlient.Size = new System.Drawing.Size(240, 65);
            this.saveKlient.TabIndex = 9;
            this.saveKlient.Text = "Sign up";
            this.saveKlient.UseVisualStyleBackColor = false;
            this.saveKlient.Click += new System.EventHandler(this.saveKlient_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Jokerman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(78, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "password";
            // 
            // inputPassword
            // 
            this.inputPassword.BackColor = System.Drawing.Color.Violet;
            this.inputPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputPassword.Location = new System.Drawing.Point(84, 240);
            this.inputPassword.Multiline = true;
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.PasswordChar = '*';
            this.inputPassword.Size = new System.Drawing.Size(285, 33);
            this.inputPassword.TabIndex = 7;
            this.inputPassword.TextChanged += new System.EventHandler(this.inputPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Jokerman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(78, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "login";
            // 
            // inputLogin
            // 
            this.inputLogin.BackColor = System.Drawing.Color.Violet;
            this.inputLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputLogin.Location = new System.Drawing.Point(84, 176);
            this.inputLogin.Multiline = true;
            this.inputLogin.Name = "inputLogin";
            this.inputLogin.Size = new System.Drawing.Size(285, 33);
            this.inputLogin.TabIndex = 5;
            this.inputLogin.TextChanged += new System.EventHandler(this.inputLogin_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Jokerman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(73, 79);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(69, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "maill";
            // 
            // inputMaill
            // 
            this.inputMaill.BackColor = System.Drawing.Color.Violet;
            this.inputMaill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputMaill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputMaill.Location = new System.Drawing.Point(79, 111);
            this.inputMaill.Multiline = true;
            this.inputMaill.Name = "inputMaill";
            this.inputMaill.Size = new System.Drawing.Size(285, 33);
            this.inputMaill.TabIndex = 3;
            this.inputMaill.TextChanged += new System.EventHandler(this.inputMaill_TextChanged);
            // 
            // backToАвторизация
            // 
            this.backToАвторизация.AutoSize = true;
            this.backToАвторизация.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToАвторизация.Font = new System.Drawing.Font("Jokerman", 32.2F);
            this.backToАвторизация.ForeColor = System.Drawing.Color.Yellow;
            this.backToАвторизация.Location = new System.Drawing.Point(3, 0);
            this.backToАвторизация.Name = "backToАвторизация";
            this.backToАвторизация.Size = new System.Drawing.Size(84, 79);
            this.backToАвторизация.TabIndex = 2;
            this.backToАвторизация.Text = "🠔";
            this.backToАвторизация.Click += new System.EventHandler(this.backToАвторизация_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Jokerman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(148, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign in";
            // 
            // создание_аккаунта
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 386);
            this.Controls.Add(this.panel1);
            this.Name = "создание_аккаунта";
            this.Text = "создание_аккаунта";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label backToАвторизация;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputMaill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputLogin;
        private System.Windows.Forms.Button saveKlient;
    }
}

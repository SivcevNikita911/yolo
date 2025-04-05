namespace yolo
{
    partial class mainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.переходКконтактам = new System.Windows.Forms.Label();
            this.корзинаКлиента = new System.Windows.Forms.Button();
            this.заказыКлиента = new System.Windows.Forms.Button();
            this.КаталогКлиента = new System.Windows.Forms.Button();
            this.LableпрофильКлиента = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Violet;
            this.splitContainer1.Panel1.Controls.Add(this.заказыКлиента);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.переходКконтактам);
            this.splitContainer1.Panel1.Controls.Add(this.корзинаКлиента);
            this.splitContainer1.Panel1.Controls.Add(this.КаталогКлиента);
            this.splitContainer1.Panel1.Controls.Add(this.LableпрофильКлиента);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Jokerman", 12.2F);
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 31);
            this.label8.TabIndex = 7;
            this.label8.Text = "🠔";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // переходКконтактам
            // 
            this.переходКконтактам.AutoSize = true;
            this.переходКконтактам.Font = new System.Drawing.Font("Ink Free", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.переходКконтактам.ForeColor = System.Drawing.Color.Crimson;
            this.переходКконтактам.Location = new System.Drawing.Point(23, 388);
            this.переходКконтактам.Name = "переходКконтактам";
            this.переходКконтактам.Size = new System.Drawing.Size(199, 53);
            this.переходКконтактам.TabIndex = 6;
            this.переходКконтактам.Text = "Контакты";
            this.переходКконтактам.Click += new System.EventHandler(this.переходКконтактам_Click);
            // 
            // корзинаКлиента
            // 
            this.корзинаКлиента.BackColor = System.Drawing.Color.HotPink;
            this.корзинаКлиента.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.корзинаКлиента.Cursor = System.Windows.Forms.Cursors.Hand;
            this.корзинаКлиента.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.корзинаКлиента.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.корзинаКлиента.ForeColor = System.Drawing.Color.Yellow;
            this.корзинаКлиента.Location = new System.Drawing.Point(3, 217);
            this.корзинаКлиента.Name = "корзинаКлиента";
            this.корзинаКлиента.Size = new System.Drawing.Size(247, 80);
            this.корзинаКлиента.TabIndex = 5;
            this.корзинаКлиента.Text = "Корзина";
            this.корзинаКлиента.UseVisualStyleBackColor = false;
            this.корзинаКлиента.Click += new System.EventHandler(this.корзинаКлиента_Click);
            // 
            // заказыКлиента
            // 
            this.заказыКлиента.BackColor = System.Drawing.Color.HotPink;
            this.заказыКлиента.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.заказыКлиента.Cursor = System.Windows.Forms.Cursors.Hand;
            this.заказыКлиента.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.заказыКлиента.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.заказыКлиента.ForeColor = System.Drawing.Color.Yellow;
            this.заказыКлиента.Location = new System.Drawing.Point(3, 303);
            this.заказыКлиента.Name = "заказыКлиента";
            this.заказыКлиента.Size = new System.Drawing.Size(247, 80);
            this.заказыКлиента.TabIndex = 4;
            this.заказыКлиента.Text = "Заказы";
            this.заказыКлиента.UseVisualStyleBackColor = false;
            // 
            // КаталогКлиента
            // 
            this.КаталогКлиента.BackColor = System.Drawing.Color.HotPink;
            this.КаталогКлиента.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.КаталогКлиента.Cursor = System.Windows.Forms.Cursors.Hand;
            this.КаталогКлиента.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.КаталогКлиента.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.КаталогКлиента.ForeColor = System.Drawing.Color.Yellow;
            this.КаталогКлиента.Location = new System.Drawing.Point(3, 131);
            this.КаталогКлиента.Name = "КаталогКлиента";
            this.КаталогКлиента.Size = new System.Drawing.Size(247, 80);
            this.КаталогКлиента.TabIndex = 3;
            this.КаталогКлиента.Text = "Каталог";
            this.КаталогКлиента.UseVisualStyleBackColor = false;
            this.КаталогКлиента.Click += new System.EventHandler(this.КаталогКлиента_Click);
            // 
            // LableпрофильКлиента
            // 
            this.LableпрофильКлиента.AutoSize = true;
            this.LableпрофильКлиента.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LableпрофильКлиента.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LableпрофильКлиента.Font = new System.Drawing.Font("Ink Free", 16.2F);
            this.LableпрофильКлиента.ForeColor = System.Drawing.Color.Crimson;
            this.LableпрофильКлиента.Location = new System.Drawing.Point(51, 9);
            this.LableпрофильКлиента.Name = "LableпрофильКлиента";
            this.LableпрофильКлиента.Size = new System.Drawing.Size(83, 36);
            this.LableпрофильКлиента.TabIndex = 0;
            this.LableпрофильКлиента.Text = "label1";
            this.LableпрофильКлиента.Click += new System.EventHandler(this.LableпрофильКлиента_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label профельКлиента;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LableпрофильКлиента;
        private System.Windows.Forms.Button КаталогКлиента;
        private System.Windows.Forms.Button корзинаКлиента;
        private System.Windows.Forms.Button заказыКлиента;
        private System.Windows.Forms.Label переходКконтактам;
        private System.Windows.Forms.Label label8;
    }
}
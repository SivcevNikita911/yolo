namespace yolo
{
    partial class adminForm
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
            this.adminПерехходКсотрудникам = new System.Windows.Forms.Button();
            this.adminПерехходКматериалам = new System.Windows.Forms.Button();
            this.adminПерехходКдоставке = new System.Windows.Forms.Button();
            this.adminПерехходКзаказам = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(222)))), ((int)(((byte)(245)))));
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.adminПерехходКсотрудникам);
            this.splitContainer1.Panel1.Controls.Add(this.adminПерехходКматериалам);
            this.splitContainer1.Panel1.Controls.Add(this.adminПерехходКдоставке);
            this.splitContainer1.Panel1.Controls.Add(this.adminПерехходКзаказам);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.splitContainer1.Size = new System.Drawing.Size(896, 450);
            this.splitContainer1.SplitterDistance = 249;
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
            this.label8.TabIndex = 8;
            this.label8.Text = "🠔";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // adminПерехходКсотрудникам
            // 
            this.adminПерехходКсотрудникам.Font = new System.Drawing.Font("Ink Free", 14F);
            this.adminПерехходКсотрудникам.Location = new System.Drawing.Point(12, 196);
            this.adminПерехходКсотрудникам.Name = "adminПерехходКсотрудникам";
            this.adminПерехходКсотрудникам.Size = new System.Drawing.Size(208, 45);
            this.adminПерехходКсотрудникам.TabIndex = 3;
            this.adminПерехходКсотрудникам.Text = "Сотрудники";
            this.adminПерехходКсотрудникам.UseVisualStyleBackColor = true;
            this.adminПерехходКсотрудникам.Click += new System.EventHandler(this.adminПерехходКсотрудникам_Click);
            // 
            // adminПерехходКматериалам
            // 
            this.adminПерехходКматериалам.Font = new System.Drawing.Font("Ink Free", 14F);
            this.adminПерехходКматериалам.Location = new System.Drawing.Point(12, 145);
            this.adminПерехходКматериалам.Name = "adminПерехходКматериалам";
            this.adminПерехходКматериалам.Size = new System.Drawing.Size(208, 45);
            this.adminПерехходКматериалам.TabIndex = 2;
            this.adminПерехходКматериалам.Text = "Материалы";
            this.adminПерехходКматериалам.UseVisualStyleBackColor = true;
            this.adminПерехходКматериалам.Click += new System.EventHandler(this.adminПерехходКматериалам_Click);
            // 
            // adminПерехходКдоставке
            // 
            this.adminПерехходКдоставке.Font = new System.Drawing.Font("Ink Free", 14F);
            this.adminПерехходКдоставке.Location = new System.Drawing.Point(12, 94);
            this.adminПерехходКдоставке.Name = "adminПерехходКдоставке";
            this.adminПерехходКдоставке.Size = new System.Drawing.Size(208, 45);
            this.adminПерехходКдоставке.TabIndex = 1;
            this.adminПерехходКдоставке.Text = "Доставка";
            this.adminПерехходКдоставке.UseVisualStyleBackColor = true;
            // 
            // adminПерехходКзаказам
            // 
            this.adminПерехходКзаказам.Font = new System.Drawing.Font("Ink Free", 14F);
            this.adminПерехходКзаказам.Location = new System.Drawing.Point(12, 43);
            this.adminПерехходКзаказам.Name = "adminПерехходКзаказам";
            this.adminПерехходКзаказам.Size = new System.Drawing.Size(208, 45);
            this.adminПерехходКзаказам.TabIndex = 0;
            this.adminПерехходКзаказам.Text = "Заказы";
            this.adminПерехходКзаказам.UseVisualStyleBackColor = true;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "adminForm";
            this.Text = "adminForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button adminПерехходКзаказам;
        private System.Windows.Forms.Button adminПерехходКсотрудникам;
        private System.Windows.Forms.Button adminПерехходКматериалам;
        private System.Windows.Forms.Button adminПерехходКдоставке;
        private System.Windows.Forms.Label label8;
    }
}
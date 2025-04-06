namespace yolo
{
    partial class корзина
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
            this.dataGridViewКорзина = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ценаЗаВсе = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.заказать = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewКорзина)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewКорзина
            // 
            this.dataGridViewКорзина.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewКорзина.Location = new System.Drawing.Point(9, 14);
            this.dataGridViewКорзина.Name = "dataGridViewКорзина";
            this.dataGridViewКорзина.RowHeadersWidth = 51;
            this.dataGridViewКорзина.RowTemplate.Height = 24;
            this.dataGridViewКорзина.Size = new System.Drawing.Size(476, 274);
            this.dataGridViewКорзина.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(208)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.ценаЗаВсе);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.заказать);
            this.panel1.Location = new System.Drawing.Point(292, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 92);
            this.panel1.TabIndex = 1;
            // 
            // ценаЗаВсе
            // 
            this.ценаЗаВсе.AutoSize = true;
            this.ценаЗаВсе.Location = new System.Drawing.Point(99, 16);
            this.ценаЗаВсе.Name = "ценаЗаВсе";
            this.ценаЗаВсе.Size = new System.Drawing.Size(44, 16);
            this.ценаЗаВсе.TabIndex = 2;
            this.ценаЗаВсе.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Итого:";
            // 
            // заказать
            // 
            this.заказать.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(20)))), ((int)(((byte)(113)))));
            this.заказать.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.заказать.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.заказать.Location = new System.Drawing.Point(44, 50);
            this.заказать.Name = "заказать";
            this.заказать.Size = new System.Drawing.Size(99, 39);
            this.заказать.TabIndex = 0;
            this.заказать.Text = "заказать";
            this.заказать.UseVisualStyleBackColor = false;
            this.заказать.Click += new System.EventHandler(this.заказать_Click);
            // 
            // корзина
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewКорзина);
            this.Name = "корзина";
            this.Text = "корзина";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewКорзина)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewКорзина;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ценаЗаВсе;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button заказать;
    }
}
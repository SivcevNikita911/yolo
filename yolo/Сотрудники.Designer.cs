namespace yolo
{
    partial class Сотрудники
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
            this.dataGridViewСотрудники = new System.Windows.Forms.DataGridView();
            this.изменитьСотрудников = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewСотрудники)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewСотрудники
            // 
            this.dataGridViewСотрудники.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewСотрудники.Location = new System.Drawing.Point(18, 24);
            this.dataGridViewСотрудники.Name = "dataGridViewСотрудники";
            this.dataGridViewСотрудники.RowHeadersWidth = 51;
            this.dataGridViewСотрудники.RowTemplate.Height = 24;
            this.dataGridViewСотрудники.Size = new System.Drawing.Size(599, 274);
            this.dataGridViewСотрудники.TabIndex = 0;
            // 
            // изменитьСотрудников
            // 
            this.изменитьСотрудников.Location = new System.Drawing.Point(18, 304);
            this.изменитьСотрудников.Name = "изменитьСотрудников";
            this.изменитьСотрудников.Size = new System.Drawing.Size(155, 53);
            this.изменитьСотрудников.TabIndex = 1;
            this.изменитьСотрудников.Text = "изменить";
            this.изменитьСотрудников.UseVisualStyleBackColor = true;
            this.изменитьСотрудников.Click += new System.EventHandler(this.изменитьСотрудников_Click);
            // 
            // Сотрудники
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.изменитьСотрудников);
            this.Controls.Add(this.dataGridViewСотрудники);
            this.Name = "Сотрудники";
            this.Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewСотрудники)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewСотрудники;
        private System.Windows.Forms.Button изменитьСотрудников;
    }
}
namespace yolo
{
    partial class каталог
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
            this.dataGridViewКаталог = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewКаталог)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewКаталог
            // 
            this.dataGridViewКаталог.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewКаталог.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewКаталог.Name = "dataGridViewКаталог";
            this.dataGridViewКаталог.RowHeadersWidth = 51;
            this.dataGridViewКаталог.RowTemplate.Height = 24;
            this.dataGridViewКаталог.Size = new System.Drawing.Size(587, 265);
            this.dataGridViewКаталог.TabIndex = 1;
            // 
            // каталог
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewКаталог);
            this.Name = "каталог";
            this.Text = "каталог";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewКаталог)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewКаталог;
    }
}
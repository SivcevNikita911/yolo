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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewКорзина)).BeginInit();
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
            // корзина
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewКорзина);
            this.Name = "корзина";
            this.Text = "корзина";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewКорзина)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewКорзина;
    }
}
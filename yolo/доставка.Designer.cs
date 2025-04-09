namespace yolo
{
    partial class Доставка
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
            this.dataGridViewДоставка = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewДоставка)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewДоставка
            // 
            this.dataGridViewДоставка.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewДоставка.Location = new System.Drawing.Point(23, 21);
            this.dataGridViewДоставка.Name = "dataGridViewДоставка";
            this.dataGridViewДоставка.RowHeadersWidth = 51;
            this.dataGridViewДоставка.RowTemplate.Height = 24;
            this.dataGridViewДоставка.Size = new System.Drawing.Size(740, 276);
            this.dataGridViewДоставка.TabIndex = 0;
            // 
            // Доставка
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewДоставка);
            this.Name = "Доставка";
            this.Text = "Доставка";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewДоставка)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewДоставка;
    }
}
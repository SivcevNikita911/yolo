namespace yolo
{
    partial class ЗаказыForm
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
            this.dataGridViewЗаказы = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewЗаказы)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewЗаказы
            // 
            this.dataGridViewЗаказы.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewЗаказы.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewЗаказы.Name = "dataGridViewЗаказы";
            this.dataGridViewЗаказы.RowHeadersWidth = 51;
            this.dataGridViewЗаказы.RowTemplate.Height = 24;
            this.dataGridViewЗаказы.Size = new System.Drawing.Size(510, 305);
            this.dataGridViewЗаказы.TabIndex = 0;
            // 
            // ЗаказыForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewЗаказы);
            this.Name = "ЗаказыForm";
            this.Text = "ЗаказыForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewЗаказы)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewЗаказы;
    }
}
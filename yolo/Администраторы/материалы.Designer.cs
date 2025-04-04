namespace yolo
{
    partial class материалы
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
            this.dataGridViewМатериалы = new System.Windows.Forms.DataGridView();
            this.change = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewМатериалы)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewМатериалы
            // 
            this.dataGridViewМатериалы.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewМатериалы.Location = new System.Drawing.Point(11, 11);
            this.dataGridViewМатериалы.Name = "dataGridViewМатериалы";
            this.dataGridViewМатериалы.RowHeadersWidth = 51;
            this.dataGridViewМатериалы.RowTemplate.Height = 24;
            this.dataGridViewМатериалы.Size = new System.Drawing.Size(596, 265);
            this.dataGridViewМатериалы.TabIndex = 0;
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(11, 282);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(141, 43);
            this.change.TabIndex = 3;
            this.change.Text = "иземенить";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // материалы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.change);
            this.Controls.Add(this.dataGridViewМатериалы);
            this.Name = "материалы";
            this.Text = "материалы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewМатериалы)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewМатериалы;
        private System.Windows.Forms.Button change;
    }
}
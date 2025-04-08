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
            this.добавитьСотрудника = new System.Windows.Forms.Button();
            this.inputФИО = new System.Windows.Forms.TextBox();
            this.comboBoxДолжности = new System.Windows.Forms.ComboBox();
            this.inputТелефон = new System.Windows.Forms.TextBox();
            this.inputЗарплата = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.dataGridViewСотрудники.Size = new System.Drawing.Size(655, 274);
            this.dataGridViewСотрудники.TabIndex = 0;
            // 
            // добавитьСотрудника
            // 
            this.добавитьСотрудника.Location = new System.Drawing.Point(12, 391);
            this.добавитьСотрудника.Name = "добавитьСотрудника";
            this.добавитьСотрудника.Size = new System.Drawing.Size(121, 47);
            this.добавитьСотрудника.TabIndex = 1;
            this.добавитьСотрудника.Text = "добавить";
            this.добавитьСотрудника.UseVisualStyleBackColor = true;
            this.добавитьСотрудника.Click += new System.EventHandler(this.добавитьСотрудника_Click);
            // 
            // inputФИО
            // 
            this.inputФИО.Location = new System.Drawing.Point(77, 304);
            this.inputФИО.Multiline = true;
            this.inputФИО.Name = "inputФИО";
            this.inputФИО.Size = new System.Drawing.Size(121, 34);
            this.inputФИО.TabIndex = 2;
            this.inputФИО.TextChanged += new System.EventHandler(this.inputФИО_TextChanged);
            // 
            // comboBoxДолжности
            // 
            this.comboBoxДолжности.FormattingEnabled = true;
            this.comboBoxДолжности.Location = new System.Drawing.Point(204, 304);
            this.comboBoxДолжности.Name = "comboBoxДолжности";
            this.comboBoxДолжности.Size = new System.Drawing.Size(159, 24);
            this.comboBoxДолжности.TabIndex = 3;
            this.comboBoxДолжности.SelectedIndexChanged += new System.EventHandler(this.comboBoxДолжности_SelectedIndexChanged);
            // 
            // inputТелефон
            // 
            this.inputТелефон.Location = new System.Drawing.Point(369, 304);
            this.inputТелефон.Multiline = true;
            this.inputТелефон.Name = "inputТелефон";
            this.inputТелефон.Size = new System.Drawing.Size(121, 34);
            this.inputТелефон.TabIndex = 4;
            this.inputТелефон.TextChanged += new System.EventHandler(this.inputТелефон_TextChanged);
            // 
            // inputЗарплата
            // 
            this.inputЗарплата.Location = new System.Drawing.Point(496, 304);
            this.inputЗарплата.Multiline = true;
            this.inputЗарплата.Name = "inputЗарплата";
            this.inputЗарплата.Size = new System.Drawing.Size(121, 34);
            this.inputЗарплата.TabIndex = 5;
            this.inputЗарплата.TextChanged += new System.EventHandler(this.inputЗарплата_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Должность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "зарплата";
            // 
            // Сотрудники
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputЗарплата);
            this.Controls.Add(this.inputТелефон);
            this.Controls.Add(this.comboBoxДолжности);
            this.Controls.Add(this.inputФИО);
            this.Controls.Add(this.добавитьСотрудника);
            this.Controls.Add(this.dataGridViewСотрудники);
            this.Name = "Сотрудники";
            this.Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewСотрудники)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewСотрудники;
        private System.Windows.Forms.Button добавитьСотрудника;
        private System.Windows.Forms.TextBox inputФИО;
        private System.Windows.Forms.ComboBox comboBoxДолжности;
        private System.Windows.Forms.TextBox inputТелефон;
        private System.Windows.Forms.TextBox inputЗарплата;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
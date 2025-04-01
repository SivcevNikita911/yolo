namespace yolo
{
    partial class testForm
    {
        private System.ComponentModel.IContainer components = null;
        public System.Windows.Forms.ListBox selectКлинты;

        private void InitializeComponent()
        {
            this.selectКлинты = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // selectКлинты
            // 
            this.selectКлинты.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectКлинты.FormattingEnabled = true;
            this.selectКлинты.ItemHeight = 22;
            this.selectКлинты.Location = new System.Drawing.Point(12, 12);
            this.selectКлинты.Name = "selectКлинты";
            this.selectКлинты.Size = new System.Drawing.Size(555, 48);
            this.selectКлинты.TabIndex = 0;
            this.selectКлинты.SelectedIndexChanged += new System.EventHandler(this.selectКлинты_SelectedIndexChanged);
            // 
            // testForm
            // 
            this.ClientSize = new System.Drawing.Size(579, 578);
            this.Controls.Add(this.selectКлинты);
            this.Name = "testForm";
            this.ResumeLayout(false);

        }
    }
}
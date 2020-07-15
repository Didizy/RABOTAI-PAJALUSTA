namespace курсач
{
    partial class report_sales_of_user
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
            this.dataGridViewSalesRep = new System.Windows.Forms.DataGridView();
            this.ColumnSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTariph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonCreateReport = new System.Windows.Forms.Button();
            this.buttonSaveInFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesRep)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSalesRep
            // 
            this.dataGridViewSalesRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalesRep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSale,
            this.ColumnProvider,
            this.ColumnTariph});
            this.dataGridViewSalesRep.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewSalesRep.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSalesRep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewSalesRep.Name = "dataGridViewSalesRep";
            this.dataGridViewSalesRep.RowHeadersWidth = 51;
            this.dataGridViewSalesRep.RowTemplate.Height = 24;
            this.dataGridViewSalesRep.Size = new System.Drawing.Size(408, 366);
            this.dataGridViewSalesRep.TabIndex = 0;
            // 
            // ColumnSale
            // 
            this.ColumnSale.HeaderText = "Скидка";
            this.ColumnSale.MinimumWidth = 6;
            this.ColumnSale.Name = "ColumnSale";
            this.ColumnSale.Width = 125;
            // 
            // ColumnProvider
            // 
            this.ColumnProvider.HeaderText = "Провайдер";
            this.ColumnProvider.MinimumWidth = 6;
            this.ColumnProvider.Name = "ColumnProvider";
            this.ColumnProvider.Width = 125;
            // 
            // ColumnTariph
            // 
            this.ColumnTariph.HeaderText = "Тариф";
            this.ColumnTariph.MinimumWidth = 6;
            this.ColumnTariph.Name = "ColumnTariph";
            this.ColumnTariph.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(490, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин покупателя";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(493, 86);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(156, 20);
            this.textBoxLogin.TabIndex = 2;
            // 
            // buttonCreateReport
            // 
            this.buttonCreateReport.Location = new System.Drawing.Point(506, 155);
            this.buttonCreateReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateReport.Name = "buttonCreateReport";
            this.buttonCreateReport.Size = new System.Drawing.Size(112, 37);
            this.buttonCreateReport.TabIndex = 8;
            this.buttonCreateReport.Text = "Создать отчет";
            this.buttonCreateReport.UseVisualStyleBackColor = true;
            this.buttonCreateReport.Click += new System.EventHandler(this.buttonCreateReport_Click);
            // 
            // buttonSaveInFile
            // 
            this.buttonSaveInFile.Location = new System.Drawing.Point(506, 271);
            this.buttonSaveInFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaveInFile.Name = "buttonSaveInFile";
            this.buttonSaveInFile.Size = new System.Drawing.Size(112, 41);
            this.buttonSaveInFile.TabIndex = 7;
            this.buttonSaveInFile.Text = "Сохранить в файл";
            this.buttonSaveInFile.UseVisualStyleBackColor = true;
            this.buttonSaveInFile.Click += new System.EventHandler(this.buttonSaveInFile_Click);
            // 
            // report_sales_of_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 366);
            this.Controls.Add(this.buttonCreateReport);
            this.Controls.Add(this.buttonSaveInFile);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSalesRep);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "report_sales_of_user";
            this.Text = "Скидки, которые может получать пользователь";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesRep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSalesRep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTariph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonCreateReport;
        private System.Windows.Forms.Button buttonSaveInFile;
    }
}
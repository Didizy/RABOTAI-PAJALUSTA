namespace курсач
{
    partial class report_of_sales
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
            this.dataGridViewSaleForUsers = new System.Windows.Forms.DataGridView();
            this.ColumnLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTariph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.sale_size = new System.Windows.Forms.TextBox();
            this.buttonCreateReport = new System.Windows.Forms.Button();
            this.buttonSaveInFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleForUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSaleForUsers
            // 
            this.dataGridViewSaleForUsers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewSaleForUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaleForUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnLogin,
            this.ColumnProvider,
            this.ColumnTariph});
            this.dataGridViewSaleForUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewSaleForUsers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSaleForUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewSaleForUsers.Name = "dataGridViewSaleForUsers";
            this.dataGridViewSaleForUsers.RowHeadersWidth = 51;
            this.dataGridViewSaleForUsers.RowTemplate.Height = 24;
            this.dataGridViewSaleForUsers.Size = new System.Drawing.Size(396, 366);
            this.dataGridViewSaleForUsers.TabIndex = 0;
            // 
            // ColumnLogin
            // 
            this.ColumnLogin.HeaderText = "Логин покупателя";
            this.ColumnLogin.MinimumWidth = 6;
            this.ColumnLogin.Name = "ColumnLogin";
            this.ColumnLogin.Width = 125;
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
            this.label1.Location = new System.Drawing.Point(451, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Скидка";
            // 
            // sale_size
            // 
            this.sale_size.Location = new System.Drawing.Point(454, 78);
            this.sale_size.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sale_size.Name = "sale_size";
            this.sale_size.Size = new System.Drawing.Size(152, 20);
            this.sale_size.TabIndex = 2;
            // 
            // buttonCreateReport
            // 
            this.buttonCreateReport.Location = new System.Drawing.Point(468, 134);
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
            this.buttonSaveInFile.Location = new System.Drawing.Point(468, 274);
            this.buttonSaveInFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaveInFile.Name = "buttonSaveInFile";
            this.buttonSaveInFile.Size = new System.Drawing.Size(112, 41);
            this.buttonSaveInFile.TabIndex = 7;
            this.buttonSaveInFile.Text = "Сохранить в файл";
            this.buttonSaveInFile.UseVisualStyleBackColor = true;
            this.buttonSaveInFile.Click += new System.EventHandler(this.buttonSaveInFile_Click);
            // 
            // report_of_sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 366);
            this.Controls.Add(this.buttonCreateReport);
            this.Controls.Add(this.buttonSaveInFile);
            this.Controls.Add(this.sale_size);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSaleForUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "report_of_sales";
            this.Text = "report_of_sales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleForUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSaleForUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTariph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sale_size;
        private System.Windows.Forms.Button buttonCreateReport;
        private System.Windows.Forms.Button buttonSaveInFile;
    }
}
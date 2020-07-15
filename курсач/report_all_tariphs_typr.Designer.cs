namespace курсач
{
    partial class report_all_tariphs_typr
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
            this.dataGridViewTypeRep = new System.Windows.Forms.DataGridView();
            this.ColumnTariph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCreateReport = new System.Windows.Forms.Button();
            this.buttonSaveInFile = new System.Windows.Forms.Button();
            this.textBoxProvider = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxAddTariphTV = new System.Windows.Forms.CheckBox();
            this.checkBoxAddTariphInternet = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypeRep)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTypeRep
            // 
            this.dataGridViewTypeRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTypeRep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTariph});
            this.dataGridViewTypeRep.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewTypeRep.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTypeRep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewTypeRep.MultiSelect = false;
            this.dataGridViewTypeRep.Name = "dataGridViewTypeRep";
            this.dataGridViewTypeRep.RowHeadersWidth = 51;
            this.dataGridViewTypeRep.RowTemplate.Height = 24;
            this.dataGridViewTypeRep.Size = new System.Drawing.Size(212, 366);
            this.dataGridViewTypeRep.TabIndex = 0;
            this.dataGridViewTypeRep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTypeRep_CellContentClick);
            // 
            // ColumnTariph
            // 
            this.ColumnTariph.HeaderText = "Тариф";
            this.ColumnTariph.MinimumWidth = 6;
            this.ColumnTariph.Name = "ColumnTariph";
            this.ColumnTariph.Width = 125;
            // 
            // buttonCreateReport
            // 
            this.buttonCreateReport.Location = new System.Drawing.Point(315, 183);
            this.buttonCreateReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateReport.Name = "buttonCreateReport";
            this.buttonCreateReport.Size = new System.Drawing.Size(112, 37);
            this.buttonCreateReport.TabIndex = 6;
            this.buttonCreateReport.Text = "Создать отчет";
            this.buttonCreateReport.UseVisualStyleBackColor = true;
            this.buttonCreateReport.Click += new System.EventHandler(this.buttonCreateReport_Click);
            // 
            // buttonSaveInFile
            // 
            this.buttonSaveInFile.Location = new System.Drawing.Point(315, 299);
            this.buttonSaveInFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaveInFile.Name = "buttonSaveInFile";
            this.buttonSaveInFile.Size = new System.Drawing.Size(112, 41);
            this.buttonSaveInFile.TabIndex = 5;
            this.buttonSaveInFile.Text = "Сохранить в файл";
            this.buttonSaveInFile.UseVisualStyleBackColor = true;
            this.buttonSaveInFile.Click += new System.EventHandler(this.buttonSaveInFile_Click);
            // 
            // textBoxProvider
            // 
            this.textBoxProvider.Location = new System.Drawing.Point(279, 68);
            this.textBoxProvider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxProvider.Name = "textBoxProvider";
            this.textBoxProvider.Size = new System.Drawing.Size(210, 20);
            this.textBoxProvider.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(276, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Провайдер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(278, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вид услуги";
            // 
            // checkBoxAddTariphTV
            // 
            this.checkBoxAddTariphTV.AutoSize = true;
            this.checkBoxAddTariphTV.Location = new System.Drawing.Point(395, 140);
            this.checkBoxAddTariphTV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxAddTariphTV.Name = "checkBoxAddTariphTV";
            this.checkBoxAddTariphTV.Size = new System.Drawing.Size(98, 17);
            this.checkBoxAddTariphTV.TabIndex = 24;
            this.checkBoxAddTariphTV.Text = "Кабельное ТВ";
            this.checkBoxAddTariphTV.UseVisualStyleBackColor = true;
            // 
            // checkBoxAddTariphInternet
            // 
            this.checkBoxAddTariphInternet.AutoSize = true;
            this.checkBoxAddTariphInternet.Location = new System.Drawing.Point(281, 140);
            this.checkBoxAddTariphInternet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxAddTariphInternet.Name = "checkBoxAddTariphInternet";
            this.checkBoxAddTariphInternet.Size = new System.Drawing.Size(74, 17);
            this.checkBoxAddTariphInternet.TabIndex = 23;
            this.checkBoxAddTariphInternet.Text = "Интернет";
            this.checkBoxAddTariphInternet.UseVisualStyleBackColor = true;
            // 
            // report_all_tariphs_typr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 366);
            this.Controls.Add(this.checkBoxAddTariphTV);
            this.Controls.Add(this.checkBoxAddTariphInternet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProvider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreateReport);
            this.Controls.Add(this.buttonSaveInFile);
            this.Controls.Add(this.dataGridViewTypeRep);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "report_all_tariphs_typr";
            this.Text = "Тарифы провайдера определенного вида услуги";
            this.Load += new System.EventHandler(this.report_all_tariphs_typr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypeRep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTypeRep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTariph;
        private System.Windows.Forms.Button buttonCreateReport;
        private System.Windows.Forms.Button buttonSaveInFile;
        private System.Windows.Forms.TextBox textBoxProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxAddTariphTV;
        private System.Windows.Forms.CheckBox checkBoxAddTariphInternet;
    }
}
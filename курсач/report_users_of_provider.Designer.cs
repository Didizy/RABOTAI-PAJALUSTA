﻿namespace курсач
{
    partial class report_users_of_provider
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
            this.dataGridViewUsersRep = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProvider = new System.Windows.Forms.TextBox();
            this.buttonSaveInFile = new System.Windows.Forms.Button();
            this.buttonCreateReport = new System.Windows.Forms.Button();
            this.ColumnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsersRep)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsersRep
            // 
            this.dataGridViewUsersRep.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewUsersRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsersRep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnUser,
            this.ColumnSale});
            this.dataGridViewUsersRep.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewUsersRep.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUsersRep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewUsersRep.Name = "dataGridViewUsersRep";
            this.dataGridViewUsersRep.RowHeadersWidth = 51;
            this.dataGridViewUsersRep.RowTemplate.Height = 24;
            this.dataGridViewUsersRep.Size = new System.Drawing.Size(310, 366);
            this.dataGridViewUsersRep.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(362, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Провайдер";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxProvider
            // 
            this.textBoxProvider.Location = new System.Drawing.Point(365, 80);
            this.textBoxProvider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxProvider.Name = "textBoxProvider";
            this.textBoxProvider.Size = new System.Drawing.Size(194, 20);
            this.textBoxProvider.TabIndex = 2;
            this.textBoxProvider.TextChanged += new System.EventHandler(this.textBoxProvider_TextChanged);
            // 
            // buttonSaveInFile
            // 
            this.buttonSaveInFile.Location = new System.Drawing.Point(400, 266);
            this.buttonSaveInFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaveInFile.Name = "buttonSaveInFile";
            this.buttonSaveInFile.Size = new System.Drawing.Size(112, 41);
            this.buttonSaveInFile.TabIndex = 3;
            this.buttonSaveInFile.Text = "Сохранить в файл";
            this.buttonSaveInFile.UseVisualStyleBackColor = true;
            this.buttonSaveInFile.Click += new System.EventHandler(this.buttonSaveInFile_Click);
            // 
            // buttonCreateReport
            // 
            this.buttonCreateReport.Location = new System.Drawing.Point(400, 123);
            this.buttonCreateReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateReport.Name = "buttonCreateReport";
            this.buttonCreateReport.Size = new System.Drawing.Size(112, 37);
            this.buttonCreateReport.TabIndex = 4;
            this.buttonCreateReport.Text = "Создать отчет";
            this.buttonCreateReport.UseVisualStyleBackColor = true;
            this.buttonCreateReport.Click += new System.EventHandler(this.buttonCreateReport_Click);
            // 
            // ColumnUser
            // 
            this.ColumnUser.HeaderText = "Логин покупателя";
            this.ColumnUser.MinimumWidth = 6;
            this.ColumnUser.Name = "ColumnUser";
            this.ColumnUser.Width = 125;
            // 
            // ColumnSale
            // 
            this.ColumnSale.HeaderText = "Скидка";
            this.ColumnSale.MinimumWidth = 6;
            this.ColumnSale.Name = "ColumnSale";
            this.ColumnSale.Width = 125;
            // 
            // report_users_of_provider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonCreateReport);
            this.Controls.Add(this.buttonSaveInFile);
            this.Controls.Add(this.textBoxProvider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewUsersRep);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "report_users_of_provider";
            this.Text = "Все пользователи провайдера";
            this.Load += new System.EventHandler(this.report_users_of_provider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsersRep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsersRep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProvider;
        private System.Windows.Forms.Button buttonSaveInFile;
        private System.Windows.Forms.Button buttonCreateReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSale;
    }
}
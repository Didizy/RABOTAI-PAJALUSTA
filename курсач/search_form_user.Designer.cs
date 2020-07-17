namespace курсач
{
    partial class search_form_user
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
            this.dataGridViewSearchUser = new System.Windows.Forms.DataGridView();
            this.ColumnHahLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTariph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCompareNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSearchUser
            // 
            this.dataGridViewSearchUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnHahLogin,
            this.ColumnLogin,
            this.ColumnTariph,
            this.ColumnDate});
            this.dataGridViewSearchUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewSearchUser.Location = new System.Drawing.Point(0, 66);
            this.dataGridViewSearchUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewSearchUser.Name = "dataGridViewSearchUser";
            this.dataGridViewSearchUser.ReadOnly = true;
            this.dataGridViewSearchUser.RowHeadersWidth = 51;
            this.dataGridViewSearchUser.RowTemplate.Height = 24;
            this.dataGridViewSearchUser.Size = new System.Drawing.Size(581, 62);
            this.dataGridViewSearchUser.TabIndex = 0;
            // 
            // ColumnHahLogin
            // 
            this.ColumnHahLogin.HeaderText = "Хеш-значение логина";
            this.ColumnHahLogin.MinimumWidth = 6;
            this.ColumnHahLogin.Name = "ColumnHahLogin";
            this.ColumnHahLogin.ReadOnly = true;
            this.ColumnHahLogin.Width = 125;
            // 
            // ColumnLogin
            // 
            this.ColumnLogin.HeaderText = "Логин";
            this.ColumnLogin.MinimumWidth = 6;
            this.ColumnLogin.Name = "ColumnLogin";
            this.ColumnLogin.ReadOnly = true;
            this.ColumnLogin.Width = 125;
            // 
            // ColumnTariph
            // 
            this.ColumnTariph.HeaderText = "Тариф";
            this.ColumnTariph.MinimumWidth = 6;
            this.ColumnTariph.Name = "ColumnTariph";
            this.ColumnTariph.ReadOnly = true;
            this.ColumnTariph.Width = 125;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Дата подключения";
            this.ColumnDate.MinimumWidth = 6;
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            this.ColumnDate.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин покупателя";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.labelLogin.Location = new System.Drawing.Point(191, 7);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(58, 22);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество сравнений";
            // 
            // labelCompareNum
            // 
            this.labelCompareNum.AutoSize = true;
            this.labelCompareNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.labelCompareNum.Location = new System.Drawing.Point(191, 37);
            this.labelCompareNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCompareNum.Name = "labelCompareNum";
            this.labelCompareNum.Size = new System.Drawing.Size(58, 22);
            this.labelCompareNum.TabIndex = 4;
            this.labelCompareNum.Text = "label3";
            this.labelCompareNum.Click += new System.EventHandler(this.labelCompareNum_Click);
            // 
            // search_form_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 128);
            this.Controls.Add(this.labelCompareNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSearchUser);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "search_form_user";
            this.Text = "Информация о покупателе";
            this.Load += new System.EventHandler(this.search_form_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSearchUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHahLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTariph;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCompareNum;
    }
}
namespace курсач
{
    partial class searchform_sale
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
            this.dataGridViewSearchSale = new System.Windows.Forms.DataGridView();
            this.ColumnSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTariph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateOfUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSale = new System.Windows.Forms.Label();
            this.labelCompareNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchSale)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSearchSale
            // 
            this.dataGridViewSearchSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSale,
            this.ColumnTariph,
            this.ColumnDateOfUse});
            this.dataGridViewSearchSale.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewSearchSale.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSearchSale.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSearchSale.Name = "dataGridViewSearchSale";
            this.dataGridViewSearchSale.RowHeadersWidth = 51;
            this.dataGridViewSearchSale.RowTemplate.Height = 24;
            this.dataGridViewSearchSale.Size = new System.Drawing.Size(428, 356);
            this.dataGridViewSearchSale.TabIndex = 0;
            // 
            // ColumnSale
            // 
            this.ColumnSale.HeaderText = "Скидка";
            this.ColumnSale.MinimumWidth = 6;
            this.ColumnSale.Name = "ColumnSale";
            this.ColumnSale.Width = 125;
            // 
            // ColumnTariph
            // 
            this.ColumnTariph.HeaderText = "Тариф";
            this.ColumnTariph.MinimumWidth = 6;
            this.ColumnTariph.Name = "ColumnTariph";
            this.ColumnTariph.Width = 125;
            // 
            // ColumnDateOfUse
            // 
            this.ColumnDateOfUse.HeaderText = "Срок пользования тарифом";
            this.ColumnDateOfUse.MinimumWidth = 6;
            this.ColumnDateOfUse.Name = "ColumnDateOfUse";
            this.ColumnDateOfUse.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(515, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Процент скидки";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSale
            // 
            this.labelSale.AutoSize = true;
            this.labelSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.labelSale.Location = new System.Drawing.Point(542, 71);
            this.labelSale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSale.Name = "labelSale";
            this.labelSale.Size = new System.Drawing.Size(58, 22);
            this.labelSale.TabIndex = 2;
            this.labelSale.Text = "label2";
            this.labelSale.Click += new System.EventHandler(this.labelSale_Click);
            // 
            // labelCompareNum
            // 
            this.labelCompareNum.AutoSize = true;
            this.labelCompareNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.labelCompareNum.Location = new System.Drawing.Point(542, 258);
            this.labelCompareNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCompareNum.Name = "labelCompareNum";
            this.labelCompareNum.Size = new System.Drawing.Size(58, 22);
            this.labelCompareNum.TabIndex = 3;
            this.labelCompareNum.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(494, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество сравнений";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // searchform_sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 356);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCompareNum);
            this.Controls.Add(this.labelSale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSearchSale);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "searchform_sale";
            this.Text = "Информация о скидке";
            this.Load += new System.EventHandler(this.searchform_sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSearchSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTariph;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateOfUse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSale;
        private System.Windows.Forms.Label labelCompareNum;
        private System.Windows.Forms.Label label2;
    }
}
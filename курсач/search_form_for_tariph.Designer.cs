namespace курсач
{
    partial class search_form_for_tariph
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
            this.labelTariphName = new System.Windows.Forms.Label();
            this.labelFINDNameTariph = new System.Windows.Forms.Label();
            this.labelCompareNamberTEXT = new System.Windows.Forms.Label();
            this.labelCompareNumber = new System.Windows.Forms.Label();
            this.dataGridViewSearchTariph = new System.Windows.Forms.DataGridView();
            this.ColumnProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHashOfTariph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTariph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchTariph)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTariphName
            // 
            this.labelTariphName.AutoSize = true;
            this.labelTariphName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelTariphName.Location = new System.Drawing.Point(13, 13);
            this.labelTariphName.Name = "labelTariphName";
            this.labelTariphName.Size = new System.Drawing.Size(168, 24);
            this.labelTariphName.TabIndex = 1;
            this.labelTariphName.Text = "Название тарифа";
            // 
            // labelFINDNameTariph
            // 
            this.labelFINDNameTariph.AutoSize = true;
            this.labelFINDNameTariph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.labelFINDNameTariph.Location = new System.Drawing.Point(216, 18);
            this.labelFINDNameTariph.Name = "labelFINDNameTariph";
            this.labelFINDNameTariph.Size = new System.Drawing.Size(70, 26);
            this.labelFINDNameTariph.TabIndex = 2;
            this.labelFINDNameTariph.Text = "label1";
            this.labelFINDNameTariph.Click += new System.EventHandler(this.labelFINDNameTariph_Click);
            // 
            // labelCompareNamberTEXT
            // 
            this.labelCompareNamberTEXT.AutoSize = true;
            this.labelCompareNamberTEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelCompareNamberTEXT.Location = new System.Drawing.Point(13, 74);
            this.labelCompareNamberTEXT.Name = "labelCompareNamberTEXT";
            this.labelCompareNamberTEXT.Size = new System.Drawing.Size(219, 24);
            this.labelCompareNamberTEXT.TabIndex = 3;
            this.labelCompareNamberTEXT.Text = "Количество сравнений";
            // 
            // labelCompareNumber
            // 
            this.labelCompareNumber.AutoSize = true;
            this.labelCompareNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.labelCompareNumber.Location = new System.Drawing.Point(253, 81);
            this.labelCompareNumber.Name = "labelCompareNumber";
            this.labelCompareNumber.Size = new System.Drawing.Size(70, 26);
            this.labelCompareNumber.TabIndex = 4;
            this.labelCompareNumber.Text = "label1";
            // 
            // dataGridViewSearchTariph
            // 
            this.dataGridViewSearchTariph.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchTariph.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProvider,
            this.ColumnHashOfTariph,
            this.ColumnTariph,
            this.ColumnType,
            this.ColumnCost});
            this.dataGridViewSearchTariph.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewSearchTariph.Location = new System.Drawing.Point(0, 128);
            this.dataGridViewSearchTariph.Name = "dataGridViewSearchTariph";
            this.dataGridViewSearchTariph.RowHeadersWidth = 51;
            this.dataGridViewSearchTariph.RowTemplate.Height = 24;
            this.dataGridViewSearchTariph.Size = new System.Drawing.Size(801, 150);
            this.dataGridViewSearchTariph.TabIndex = 5;
            // 
            // ColumnProvider
            // 
            this.ColumnProvider.HeaderText = "Провайдер";
            this.ColumnProvider.MinimumWidth = 6;
            this.ColumnProvider.Name = "ColumnProvider";
            this.ColumnProvider.Width = 125;
            // 
            // ColumnHashOfTariph
            // 
            this.ColumnHashOfTariph.HeaderText = "Хеш-значение тарифа";
            this.ColumnHashOfTariph.MinimumWidth = 6;
            this.ColumnHashOfTariph.Name = "ColumnHashOfTariph";
            this.ColumnHashOfTariph.Width = 125;
            // 
            // ColumnTariph
            // 
            this.ColumnTariph.HeaderText = "Тариф";
            this.ColumnTariph.MinimumWidth = 6;
            this.ColumnTariph.Name = "ColumnTariph";
            this.ColumnTariph.Width = 125;
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "Вид услуги";
            this.ColumnType.MinimumWidth = 6;
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.Width = 125;
            // 
            // ColumnCost
            // 
            this.ColumnCost.HeaderText = "Стоимость";
            this.ColumnCost.MinimumWidth = 6;
            this.ColumnCost.Name = "ColumnCost";
            this.ColumnCost.Width = 125;
            // 
            // search_form_for_tariph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 278);
            this.Controls.Add(this.dataGridViewSearchTariph);
            this.Controls.Add(this.labelCompareNumber);
            this.Controls.Add(this.labelCompareNamberTEXT);
            this.Controls.Add(this.labelFINDNameTariph);
            this.Controls.Add(this.labelTariphName);
            this.Name = "search_form_for_tariph";
            this.Text = "search_form_for_tariph";
            this.Load += new System.EventHandler(this.search_form_for_tariph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchTariph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTariphName;
        private System.Windows.Forms.Label labelFINDNameTariph;
        private System.Windows.Forms.Label labelCompareNamberTEXT;
        private System.Windows.Forms.Label labelCompareNumber;
        private System.Windows.Forms.DataGridView dataGridViewSearchTariph;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHashOfTariph;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTariph;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCost;
    }
}
namespace курсач
{
    partial class searchform_provider
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
            this.compare_number = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_compare = new System.Windows.Forms.Label();
            this.label_provider = new System.Windows.Forms.Label();
            this.Porovider_name = new System.Windows.Forms.Label();
            this.Column_hash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_tariph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // compare_number
            // 
            this.compare_number.AutoSize = true;
            this.compare_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.compare_number.Location = new System.Drawing.Point(436, 5);
            this.compare_number.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.compare_number.Name = "compare_number";
            this.compare_number.Size = new System.Drawing.Size(134, 20);
            this.compare_number.TabIndex = 0;
            this.compare_number.Text = "compare_number";
            this.compare_number.Click += new System.EventHandler(this.compare_number_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_hash,
            this.Column_speed,
            this.Column_cost,
            this.Column_tariph});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 146);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(644, 198);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label_compare
            // 
            this.label_compare.AutoSize = true;
            this.label_compare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_compare.Location = new System.Drawing.Point(268, 8);
            this.label_compare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_compare.Name = "label_compare";
            this.label_compare.Size = new System.Drawing.Size(164, 17);
            this.label_compare.TabIndex = 2;
            this.label_compare.Text = "Количество сравнений:";
            // 
            // label_provider
            // 
            this.label_provider.AutoSize = true;
            this.label_provider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_provider.Location = new System.Drawing.Point(9, 7);
            this.label_provider.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_provider.Name = "label_provider";
            this.label_provider.Size = new System.Drawing.Size(155, 17);
            this.label_provider.TabIndex = 3;
            this.label_provider.Text = "Название провайдера";
            // 
            // Porovider_name
            // 
            this.Porovider_name.AutoSize = true;
            this.Porovider_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Porovider_name.Location = new System.Drawing.Point(168, 5);
            this.Porovider_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Porovider_name.Name = "Porovider_name";
            this.Porovider_name.Size = new System.Drawing.Size(51, 20);
            this.Porovider_name.TabIndex = 4;
            this.Porovider_name.Text = "label1";
            this.Porovider_name.Click += new System.EventHandler(this.Porovider_name_Click);
            // 
            // Column_hash
            // 
            this.Column_hash.HeaderText = "Хеш-значение";
            this.Column_hash.MinimumWidth = 6;
            this.Column_hash.Name = "Column_hash";
            this.Column_hash.ReadOnly = true;
            this.Column_hash.Width = 125;
            // 
            // Column_speed
            // 
            this.Column_speed.HeaderText = "Скорость";
            this.Column_speed.MinimumWidth = 6;
            this.Column_speed.Name = "Column_speed";
            this.Column_speed.ReadOnly = true;
            this.Column_speed.Width = 125;
            // 
            // Column_cost
            // 
            this.Column_cost.HeaderText = "Цена";
            this.Column_cost.MinimumWidth = 6;
            this.Column_cost.Name = "Column_cost";
            this.Column_cost.ReadOnly = true;
            this.Column_cost.Width = 125;
            // 
            // Column_tariph
            // 
            this.Column_tariph.HeaderText = "Тариф";
            this.Column_tariph.MinimumWidth = 6;
            this.Column_tariph.Name = "Column_tariph";
            this.Column_tariph.ReadOnly = true;
            this.Column_tariph.Width = 125;
            // 
            // searchform_provider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 344);
            this.Controls.Add(this.Porovider_name);
            this.Controls.Add(this.label_provider);
            this.Controls.Add(this.label_compare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.compare_number);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "searchform_provider";
            this.Text = "Информация по провайдеру";
            this.Load += new System.EventHandler(this.error_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label compare_number;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_compare;
        private System.Windows.Forms.Label label_provider;
        private System.Windows.Forms.Label Porovider_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_hash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_tariph;
    }
}
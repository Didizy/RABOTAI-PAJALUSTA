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
            this.Column_hash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columntariph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_compare = new System.Windows.Forms.Label();
            this.provider_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // compare_number
            // 
            this.compare_number.AutoSize = true;
            this.compare_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.compare_number.Location = new System.Drawing.Point(500, 9);
            this.compare_number.Name = "compare_number";
            this.compare_number.Size = new System.Drawing.Size(165, 25);
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
            this.Columntariph,
            this.Column_type});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 244);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Columntariph
            // 
            this.Columntariph.HeaderText = "Тариф";
            this.Columntariph.MinimumWidth = 6;
            this.Columntariph.Name = "Columntariph";
            this.Columntariph.ReadOnly = true;
            this.Columntariph.Width = 125;
            // 
            // Column_type
            // 
            this.Column_type.HeaderText = "Тип услуги";
            this.Column_type.MinimumWidth = 6;
            this.Column_type.Name = "Column_type";
            this.Column_type.ReadOnly = true;
            this.Column_type.Width = 125;
            // 
            // label_compare
            // 
            this.label_compare.AutoSize = true;
            this.label_compare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_compare.Location = new System.Drawing.Point(286, 13);
            this.label_compare.Name = "label_compare";
            this.label_compare.Size = new System.Drawing.Size(208, 20);
            this.label_compare.TabIndex = 2;
            this.label_compare.Text = "Количество сравнений:";
            // 
            // provider_name
            // 
            this.provider_name.AutoSize = true;
            this.provider_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.provider_name.Location = new System.Drawing.Point(12, 9);
            this.provider_name.Name = "provider_name";
            this.provider_name.Size = new System.Drawing.Size(198, 20);
            this.provider_name.TabIndex = 3;
            this.provider_name.Text = "Название провайдера";
            // 
            // searchform_provider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 289);
            this.Controls.Add(this.provider_name);
            this.Controls.Add(this.label_compare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.compare_number);
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
        private System.Windows.Forms.Label provider_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_hash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columntariph;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_type;
    }
}
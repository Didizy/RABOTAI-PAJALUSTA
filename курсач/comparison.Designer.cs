namespace курсач
{
    partial class comparison
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hash_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.load_32 = new System.Windows.Forms.Button();
            this.load_64 = new System.Windows.Forms.Button();
            this.load_128 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.collis_1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.collis_2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hash,
            this.name});
            this.dataGridView1.Location = new System.Drawing.Point(2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 149);
            this.dataGridView1.TabIndex = 1;
            // 
            // hash
            // 
            this.hash.HeaderText = "Хеш";
            this.hash.Name = "hash";
            // 
            // name
            // 
            this.name.HeaderText = "Название";
            this.name.Name = "name";
            // 
            // name_2
            // 
            this.name_2.HeaderText = "Название";
            this.name_2.Name = "name_2";
            // 
            // hash_2
            // 
            this.hash_2.HeaderText = "Хеш";
            this.hash_2.Name = "hash_2";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hash_2,
            this.name_2});
            this.dataGridView2.Location = new System.Drawing.Point(441, 1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(243, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // graph
            // 
            chartArea1.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graph.Legends.Add(legend1);
            this.graph.Location = new System.Drawing.Point(2, 231);
            this.graph.Name = "graph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Первая ХФ";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Вторая ХФ";
            this.graph.Series.Add(series1);
            this.graph.Series.Add(series2);
            this.graph.Size = new System.Drawing.Size(370, 218);
            this.graph.TabIndex = 10;
            this.graph.Text = "chart1";
            this.graph.Visible = false;
            // 
            // load_32
            // 
            this.load_32.Location = new System.Drawing.Point(660, 231);
            this.load_32.Name = "load_32";
            this.load_32.Size = new System.Drawing.Size(128, 46);
            this.load_32.TabIndex = 11;
            this.load_32.Text = "Загрузить 32 ";
            this.load_32.UseVisualStyleBackColor = true;
            this.load_32.Click += new System.EventHandler(this.load_32_Click);
            // 
            // load_64
            // 
            this.load_64.Location = new System.Drawing.Point(660, 300);
            this.load_64.Name = "load_64";
            this.load_64.Size = new System.Drawing.Size(128, 46);
            this.load_64.TabIndex = 12;
            this.load_64.Text = "Загрузить 64";
            this.load_64.UseVisualStyleBackColor = true;
            // 
            // load_128
            // 
            this.load_128.Location = new System.Drawing.Point(660, 368);
            this.load_128.Name = "load_128";
            this.load_128.Size = new System.Drawing.Size(128, 46);
            this.load_128.TabIndex = 13;
            this.load_128.Text = "Загрузить 128";
            this.load_128.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Коллизий:";
            // 
            // collis_1
            // 
            this.collis_1.AutoSize = true;
            this.collis_1.Location = new System.Drawing.Point(79, 157);
            this.collis_1.Name = "collis_1";
            this.collis_1.Size = new System.Drawing.Size(13, 13);
            this.collis_1.TabIndex = 15;
            this.collis_1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Коллизий:";
            // 
            // collis_2
            // 
            this.collis_2.AutoSize = true;
            this.collis_2.Location = new System.Drawing.Point(503, 166);
            this.collis_2.Name = "collis_2";
            this.collis_2.Size = new System.Drawing.Size(13, 13);
            this.collis_2.TabIndex = 17;
            this.collis_2.Text = "0";
            // 
            // comparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.collis_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.collis_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.load_128);
            this.Controls.Add(this.load_64);
            this.Controls.Add(this.load_32);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "comparison";
            this.Text = "comparison";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hash;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hash_2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.Button load_32;
        private System.Windows.Forms.Button load_64;
        private System.Windows.Forms.Button load_128;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label collis_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label collis_2;
    }
}
namespace курсач
{
    partial class error_form
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
            this.error_mes1 = new System.Windows.Forms.Label();
            this.error_mes2 = new System.Windows.Forms.Label();
            this.error_mes3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // error_mes1
            // 
            this.error_mes1.AutoSize = true;
            this.error_mes1.Location = new System.Drawing.Point(31, 28);
            this.error_mes1.Name = "error_mes1";
            this.error_mes1.Size = new System.Drawing.Size(46, 17);
            this.error_mes1.TabIndex = 0;
            this.error_mes1.Text = "label1";
            this.error_mes1.Click += new System.EventHandler(this.error_mes1_Click);
            // 
            // error_mes2
            // 
            this.error_mes2.AutoSize = true;
            this.error_mes2.Location = new System.Drawing.Point(31, 67);
            this.error_mes2.Name = "error_mes2";
            this.error_mes2.Size = new System.Drawing.Size(46, 17);
            this.error_mes2.TabIndex = 1;
            this.error_mes2.Text = "label2";
            // 
            // error_mes3
            // 
            this.error_mes3.AutoSize = true;
            this.error_mes3.Location = new System.Drawing.Point(31, 111);
            this.error_mes3.Name = "error_mes3";
            this.error_mes3.Size = new System.Drawing.Size(46, 17);
            this.error_mes3.TabIndex = 2;
            this.error_mes3.Text = "label3";
            // 
            // error_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 322);
            this.Controls.Add(this.error_mes3);
            this.Controls.Add(this.error_mes2);
            this.Controls.Add(this.error_mes1);
            this.Name = "error_form";
            this.Text = "error_form";
            this.Load += new System.EventHandler(this.error_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label error_mes1;
        private System.Windows.Forms.Label error_mes2;
        private System.Windows.Forms.Label error_mes3;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсач
{
    public partial class searchform_sale : Form
    {
        tree_sale.root s;
        Form2 f2;
        public searchform_sale()
        {
            InitializeComponent();
        }
        public searchform_sale(tree_sale.root a, Form2 f2)
        {
            InitializeComponent();
            this.f2 = f2;
            this.s = a;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void searchform_sale_Load(object sender, EventArgs e)
        {
            string[] line = new string[3];
            line[0] = s.size;
            line[1] = s.tariph.provider.title;
            line[2] = s.date+" Месяцев";
            dataGridViewSearchSale.Rows.Add(line);
            labelSale.Text = s.size;
            labelCompareNum.Text = f2.sales.comparisons.ToString();
        }

        private void labelSale_Click(object sender, EventArgs e)
        {

        }
    }
}

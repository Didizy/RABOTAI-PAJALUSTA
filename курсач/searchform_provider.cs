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
    public partial class searchform_provider : Form
    {
        public searchform_provider()
        {
            InitializeComponent();
        }

        public void add_grid_param(string[] n, DataGridView grid)
        {
            grid.Rows.Add(n);
        }

        private void error_form_Load(object sender, EventArgs e)
        {
            string[] check = { "test1", "test2", "test3", "test4" };
            add_grid_param(check, dataGridView1);
           
        }

        private void error_mes1_Click(object sender, EventArgs e)
        {

        }

        private void compare_number_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

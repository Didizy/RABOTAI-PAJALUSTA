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
        tree_providers.root pr;
        Form2 f2;
        public searchform_provider()
        {
            InitializeComponent();
        }
        public searchform_provider(tree_providers.root a, Form2 f2)
        {
            InitializeComponent();
            pr = a;
            this.f2 = f2;
        }
       
       
        public int add_grid_param( DataGridView grid)
        {
            string[] temp = new string[4];
            int curr = 0;
            int comp = 0;
            f2.tariph.comparisons = 0;
            while (curr < pr.current_tariph)
            {
                spisok_tariph.nest a = f2.tariph.find(pr.arr[curr].name, pr);
                comp += f2.tariph.comparisons;
                temp[0] = a.hash.ToString();
                temp[1] = pr.arr[curr].name;
                temp[2] = a.speed.ToString();
                temp[3] = pr.arr[curr].cost.ToString();
                grid.Rows.Add(temp);
                curr++;
                
             
            }
            return comp;
           // grid.Rows.
            //string[] check = { "test1", "test2", "test3", "test4" };
            //grid.Rows.Add(check);
            //grid.Rows.Add(n);//добивить строку в столбцы
        }

        private void error_form_Load(object sender, EventArgs e)
        {
            //string[] check = { "test1", "test2", "test3", "test4" };//в строку подстроки, котторые будут в столбцах
            int comp = add_grid_param( dataGridView1);
            Provider_name.Text = pr.title;
            compare_number.Text = comp.ToString();
           
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

        private void Porovider_name_Click(object sender, EventArgs e)
        {

        }
    }
}

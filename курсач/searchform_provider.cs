﻿using System;
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
       
       
        public void add_grid_param( DataGridView grid)
        {
            string[] temp = new string[4];
            int curr = 0;
            while (curr < pr.current_tariph)
            {
                temp[1] = f2.tariph.find(pr.arr[curr].name, pr).hash.ToString();
                temp[2] = f2.tariph.find(pr.arr[curr].name, pr).speed.ToString();
                temp[3] = pr.arr[curr].cost.ToString();
                temp[4] = pr.arr[curr].name;
                grid.Rows.Add(temp);
                curr++;
              
             
            }
            //string[] check = { "test1", "test2", "test3", "test4" };
            //grid.Rows.Add(check);
            //grid.Rows.Add(n);//добивить строку в столбцы
        }

        private void error_form_Load(object sender, EventArgs e)
        {
            //string[] check = { "test1", "test2", "test3", "test4" };//в строку подстроки, котторые будут в столбцах
            add_grid_param( dataGridView1);
           
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

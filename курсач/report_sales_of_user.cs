using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace курсач
{
    public partial class report_sales_of_user : Form

    {
        Form2 f2;
        spisok_users.nest user;
        int error_number;

        public report_sales_of_user()
        {
            InitializeComponent();
        }
        public report_sales_of_user(Form2 f)
        {
            f2 = f;
            InitializeComponent();
        }
        public void potential_sale(string[] line, tree_sale.root s, spisok_users.nest u)
        {
            if (s == null)
                return;
            potential_sale(line, s.left, u);
            if (f2.user.Can_get_sale(u, s))
            {
                line[0] = s.size;
                line[1] = s.tariph.provider.title;
                line[2] = s.tariph.name;
                dataGridViewSalesRep.Rows.Add(line);
            }
            potential_sale(line, s.right, u);
        }
        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            dataGridViewSalesRep.Rows.Clear();

            if (textBoxLogin.Text=="")
            {
                error_number = 1;
                f2.message_box(error_number);
                return;
            }
            else if (textBoxLogin.Text.Length>30)
            {
                error_number = 2;
                f2.message_box(error_number);
                return;
            }
            user = f2.user.find(textBoxLogin.Text);
            tree_sale.root sale = f2.sales.main;
            string[] line = new string[3];
            if(user != null)
                potential_sale(line, sale, user);
            else
            {
                error_number = 3;
                f2.message_box(error_number);
            }
        }

        private void buttonSaveInFile_Click(object sender, EventArgs e)
        {
            //StreamWriter file = new StreamWriter(@"a:\gitjub\курсач\otchet_sales_of_user.txt");
            StreamWriter file = new StreamWriter(@"c:\курсач\курсач\otchet_sales_of_user.txt");
            if (dataGridViewSalesRep.Rows[0].Cells[0].Value == null)
            {
                file.Close();
                error_number = 5;
                f2.message_box(error_number);
            }
            else
            {
                file.WriteLine("Пользователь: " + user.login);
                int i = 0;
                while (dataGridViewSalesRep.Rows[i].Cells[0].Value != null)
                {
                    file.WriteLine(dataGridViewSalesRep.Rows[i].Cells[0].Value.ToString() + "/" + dataGridViewSalesRep.Rows[i].Cells[1].Value.ToString() + "/" + dataGridViewSalesRep.Rows[i].Cells[2].Value.ToString());
                    i++;
                }
                file.Close();
                error_number = 11;
                f2.message_box(error_number);
            }
        }

        private void report_sales_of_user_Load(object sender, EventArgs e)
        {

        }
    }
}

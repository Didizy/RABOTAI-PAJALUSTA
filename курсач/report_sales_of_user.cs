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
            user = f2.user.find(textBoxLogin.Text);
            tree_sale.root sale = f2.sales.main;
            string[] line = new string[3];
            if(user != null)
            potential_sale(line, sale, user);
            //textBoxLogin;
        }

        private void buttonSaveInFile_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"a:\gitjub\курсач\otchet_sales_of_user.txt");
            if (user == null)
            {
                file.Close();
                //отчёт ещё не сделан, еррор
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
            }
        }

        private void report_sales_of_user_Load(object sender, EventArgs e)
        {

        }
    }
}

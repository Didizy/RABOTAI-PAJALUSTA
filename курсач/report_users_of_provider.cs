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
    public partial class report_users_of_provider : Form
    {
        tree_providers.root pr;
        Form2 f2;
        int error_number;
        public report_users_of_provider()
        {
            InitializeComponent();
        }
        public report_users_of_provider(Form2 f, tree_providers.root p)
        {
            f2 = f;
            pr = p;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void report_users_of_provider_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            dataGridViewUsersRep.Rows.Clear();

            if (textBoxProvider.Text=="")
            {
                error_number = 1;
                f2.message_box(error_number);
            }
            else if (textBoxProvider.Text.Length>30)
            {
                error_number = 2;
                f2.message_box(error_number);
            }

            string[] line = new string[2];
            for(int i = 0; i < pr.current_user; i++)
            {
                spisok_users.nest u = f2.user.find(pr.users[i]);
                if (u == null)
                {
                    error_number = 3;
                    f2.message_box(error_number);
                }
                else
                {
                    tree_sale.root s = f2.user.check_for_sale(u.tariph, f2.sales.main, u);
                    if (s == null)
                    {
                        error_number = 3;
                        f2.message_box(error_number);
                    }
                    else
                    {
                        line[0] = u.login;
                        line[1] = s.size;
                        dataGridViewUsersRep.Rows.Add(line);
                    }
                }
            }
        }

        private void textBoxProvider_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSaveInFile_Click(object sender, EventArgs e)
        {

        }
    }
}

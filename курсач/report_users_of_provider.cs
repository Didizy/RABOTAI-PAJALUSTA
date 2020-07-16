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
    public partial class report_users_of_provider : Form
    {
        tree_providers.root pr;
        Form2 f2;
        int error_number;
        public report_users_of_provider()
        {
            InitializeComponent();
        }
        public report_users_of_provider(Form2 f)
        {
            f2 = f;       InitializeComponent();
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
            pr = f2.provider.find(textBoxProvider.Text);
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
                        line[0] = u.login;
                        line[1] = "0";
                        dataGridViewUsersRep.Rows.Add(line);
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
        public int sedgvik(int[] mas, int n)
        {
            int p1 = 1;
            int p2 = 1;
            int i = -1;
            do
            {
                if (++i % 2 == 1)
                    mas[i] = 8 * p1 - 6 * p2 + 1;
                else
                {
                    mas[i] = 9 * p1 - 9 * p2 + 1;
                    p2 *= 2;
                }
                p1 *= 2;
            }
            while (3 * mas[i] <= n);
            if (i > 0)
                return --i;
            return 0;
        }

        private void buttonSaveInFile_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"A:\gitjub\курсач\otchet_user_of_provider.txt");
            if(pr == null)
            {
                file.Close();
                error_number = 5;
                f2.message_box(error_number);
            }
            else
            {
                file.WriteLine("Провайдер: " + pr.title);
                string[] users = new string[pr.current_user];
                string[] sale = new string[pr.current_user];
                for (int i = 0; i < pr.current_user; i++)
                {
                    users[i] = pr.users[i];
                    sale[i] = dataGridViewUsersRep.Rows[i].Cells[1].Value.ToString();
                }
                int di, m, t;
                int[] d = new int[20];
                string temp;
                string temp_sale;
                for(int j = 0; j < 20; j++)
                {
                    d[j] = 0;
                }
                t = sedgvik(d, pr.current_user);
                while (t >= 0)
                {
                    di = d[t--];
                    for (int k = di; k < pr.current_user; k++)
                    {
                        temp = users[k];
                        temp_sale = sale[k];
                        for (m = k - di; (m >= 0) && (f2.provider.compare(users[m], temp) == 1); m -= di)
                        {
                            users[m + di] = users[m];
                            sale[m + di] = sale[m];

                        }
                        users[m + di] = temp;
                        sale[m + di] = temp_sale;
                    }
                }
                for (int i = 0; i < pr.current_user; i++)
                {
                    file.WriteLine(users[i] + "/" + sale[i]);
                }
                file.Close();
            }
        }
    }
}

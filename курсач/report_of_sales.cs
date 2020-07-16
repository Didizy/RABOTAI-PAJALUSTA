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
using System.Globalization;

namespace курсач
{
   
    public partial class report_of_sales : Form
    {
        Form2 f2;
        int error_number;
        string size_of_sale;
        public report_of_sales()
        {
            InitializeComponent();
        }
        public report_of_sales(Form2 f)
        {
            InitializeComponent();
            f2 = f;
        }
        /*  public int compare(string a, string b)//сравнение строк
          {


              for (int i = 0; ((i < a.Length) && (i < b.Length)); i++)
              {
                  if (a[i] == b[i])
                      continue;
                  else if (a[i] < b[i])
                      return -1;
                  else
                      return 1;

              }
              return 0;
          }*/
        int num = 0;
        public void sale_obhod_po_skidke(tree_sale.root s, string size,string[] line)
        {
            if (s == null)
                return;
            int i = f2.provider.compare(s.size, size);
            if (i == -1)
                sale_obhod_po_skidke(s.right, size, line);
            else if (i == 0)
            {
                for (int j = 0; j < s.tariph.provider.current_user; j++)
                {
                    spisok_users.nest u = f2.user.find(s.tariph.provider.users[j]);
                    if ((u.tariph == s.tariph)&&f2.user.Can_get_sale(u,s))
                    {
                        line[0] = u.login;
                        line[1] = u.tariph.provider.title;
                        line[2] = u.tariph.name;
                        dataGridViewSaleForUsers.Rows.Add(line);
                        num++;
                    }
                }
                sale_obhod_po_skidke(s.left, size, line);
                sale_obhod_po_skidke(s.right, size, line);
            }
            else if (i == 1)
            {
                sale_obhod_po_skidke(s.left, size, line);
            }
        }
        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            dataGridViewSaleForUsers.Rows.Clear();

            if (sale_size.Text =="")
            {
                error_number = 1;
                f2.message_box(error_number);
            }
            else if(sale_size.Text.Length>3)
            {
                error_number = 2;
                f2.message_box(error_number);
            }
            else
            {
                string[] line = new string[3];


                size_of_sale = sale_size.Text;
                sale_obhod_po_skidke(f2.sales.main, sale_size.Text, line);
            }
           
        }
        public int compare(string a, string b)//сравнение строк
        {
            for (int i = 0; ((i < a.Length) && (i < b.Length)); i++)
            {
                if (a[i] == b[i])
                    continue;
                else if (a[i] < b[i])
                    return -1;
                else
                    return 1;

            }
            return 0;
        }
        private void buttonSaveInFile_Click(object sender, EventArgs e)
        {
            //StreamWriter file = new StreamWriter(@"A:\gitjub\курсач\otchet_sales.txt");
            StreamWriter file = new StreamWriter(@"c:\курсач\курсач\otchet_sales.txt");
            if (dataGridViewSaleForUsers.Rows[0].Cells[0].Value == null)
            {
                file.Close();
                error_number = 5;
                f2.message_box(error_number);

            }
            else
            {
                file.WriteLine("Размер скидки: " + size_of_sale);

                string[] users = new string[num];
                string[] provider = new string[num];
                string[] tariph = new string[num];

                int i = 0;
                while (dataGridViewSaleForUsers.Rows[i].Cells[0].Value != null)
                {
                    users[i] = dataGridViewSaleForUsers.Rows[i].Cells[0].Value.ToString();
                    provider[i] = dataGridViewSaleForUsers.Rows[i].Cells[1].Value.ToString();
                    tariph[i] = dataGridViewSaleForUsers.Rows[i].Cells[2].Value.ToString();
                    i++;
                }

                int start = 0;
                int end = num - 1;

                while (start < end)
                {
                    for (int j = start; j < end; j++)
                    {
                        if (compare(users[j], users[j + 1]) == 1)
                        {
                            swap(ref users[j], ref users[j + 1]);
                            swap(ref provider[j], ref provider[j + 1]);
                            swap(ref tariph[j], ref tariph[j + 1]);
                        }
                    }

                    for (int j = end - 1; j > start; j--)
                    {
                        if (compare(users[j], users[j - 1]) == -1)
                        {
                            swap(ref users[j], ref users[j - 1]);
                            swap(ref provider[j], ref provider[j - 1]);
                            swap(ref tariph[j], ref tariph[j - 1]);
                        }
                    }
                    start++;
                    end--;
                }

                i = 0;
                while (i != num)
                {
                    file.WriteLine(users[i] + "/" + provider[i] + "/" + tariph[i]);
                    i++;
                }

                file.Close();
                error_number = 11;
                f2.message_box(error_number);
                num = 0;
            }
        }
        void swap(ref string a, ref string b)
        {
            string help;
            help = a;
            a = b;
            b = help;
        }
    }


}

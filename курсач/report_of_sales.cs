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
   
    public partial class report_of_sales : Form
    {
        Form2 f2;
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
            string[] line = new string[3];
            size_of_sale = sale_size.Text;
            sale_obhod_po_skidke(f2.sales.main, sale_size.Text, line);
            
        }

        private void buttonSaveInFile_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"A:\gitjub\курсач\otchet_sales.txt");
            if (dataGridViewSaleForUsers.Rows[0].Cells[0].Value == null)
            {
                file.Close();
                
            }
            file.WriteLine("Размер скидки: " + size_of_sale);
            int i = 0;
            while (dataGridViewSaleForUsers.Rows[i].Cells[0].Value != null)
            {
                file.WriteLine(dataGridViewSaleForUsers.Rows[i].Cells[0].Value.ToString() + "/" + dataGridViewSaleForUsers.Rows[i].Cells[1].Value.ToString() + "/" + dataGridViewSaleForUsers.Rows[i].Cells[2].Value.ToString());
                i++;
            }
            file.Close();


        }
    }
}

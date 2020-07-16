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
    public partial class report_all_tariphs_typr : Form
    {
        Form2 f2;
        tree_providers.root pr;
        int type;
        int error_number;
        public report_all_tariphs_typr()
        {
            InitializeComponent();
        }
        public report_all_tariphs_typr(Form2 a)
        {
            f2 = a;
            InitializeComponent();
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
    
        
        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            dataGridViewTypeRep.Rows.Clear();
            pr = f2.provider.find(textBoxProvider.Text);
            type = 0;
            if ((checkBoxAddTariphInternet.Checked)&& (checkBoxAddTariphTV.Checked))
                type = 2;
            else if (checkBoxAddTariphTV.Checked)
                type = 3;
            else if  (checkBoxAddTariphInternet.Checked)
                type = 2;
            if (type == 0)
            {
                error_number = 1;
                f2.message_box(error_number);
            }
            else if (textBoxProvider.Text == "")
            {
                error_number = 1;
                f2.message_box(error_number);
            }
            else if (pr == null)
            {
                error_number = 3;
                f2.message_box(error_number);
            }
            else if (textBoxProvider.Text.Length > 30)
            {
                error_number = 2;
                f2.message_box(error_number);
            }
            else
            {
                string name = "";
                for (int i = 0; i < pr.current_tariph; i++)
                {
                    spisok_tariph.nest a = f2.tariph.find(pr.arr[i].name, pr);
                    if (a.type == type)
                    {
                        name = a.name;
                        dataGridViewTypeRep.Rows.Add(name);
                    }
                }
            }
        }

        private void buttonSaveInFile_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"a:\gitjub\курсач\otchet_provider_type.txt");
            if (pr == null)
            {
                file.Close();
                error_number = 5;
                f2.message_box(error_number);
            }
            else
            {
                file.WriteLine("Провайдер: " + pr.title);
                string str = "";
                switch(type)
                {
                    case 1:
                        str = "Интернет";
                        break;
                    case 2:
                        str = "Интернет и ТВ";
                        break;
                    case 3:
                        str = "ТВ";
                        break;
                }
                file.WriteLine("Тип: " + str);
                int i = 0;
                int n = 10;
                string[] tariphs = new string[n];
                
                while (dataGridViewTypeRep.Rows[i].Cells[0].Value != null)
                {
                    if (i == n - 1)
                    {
                        Array.Resize(ref tariphs, n + 10);
                        n += 10;
                    }
                    tariphs[i] = dataGridViewTypeRep.Rows[i].Cells[0].Value.ToString();
                    //file.WriteLine(dataGridViewTypeRep.Rows[i].Cells[0].Value.ToString());
                    i++;
                }
                int di, m, j;
                n = 0;
                while (tariphs[n] != null)
                    n++;
                //n++;
                int[] d = new int[20] ;
                string temp;
                for (int k = 0; k < 20; k++)
                    d[k] = 0;
                j = sedgvik(d, n);
                while (j >= 0)
                {
                    di = d[j--];
                    for(int k = di; k < n; k++)
                    {
                        temp = tariphs[k];
                        for( m = k - di; (m >= 0) && (f2.provider.compare(tariphs[m], temp) == 1); m -= di)
                        {
                            tariphs[m + di] = tariphs[m];

                        }
                        tariphs[m + di] = temp;
                    }
                }
                for (i = 0; i < n; i++)
                    file.WriteLine(tariphs[i]);
                file.Close();
            }
        }

        private void dataGridViewTypeRep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void report_all_tariphs_typr_Load(object sender, EventArgs e)
        {

        }

        private void textBoxProvider_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

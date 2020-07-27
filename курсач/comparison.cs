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
    public partial class comparison : Form
    {
        spisok_tariph tariph = new spisok_tariph();
        spisok_tariph tar = new spisok_tariph();
        public comparison()
        {
            InitializeComponent();
            
        }

        private void load_32_Click(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader(@"a:\gitjub\курсач\load_32.txt");
            string name;
            tar.collisions = 0;
            tariph.collisions = 0;
            while (file.Peek() > -1)
            {
                name = file.ReadLine();
                tar.add(tar.getkey(name, ""),name, 3, 0, null);
                tariph.add(name, 3, 0, null);
            }
            for(int j = 0; j < tar.max_elements; j++)
            {
                if (tar.free(tar.mas[j]))
                    continue;
                else
                {
                    dataGridView1.Rows.Add(tar.mas[j].hash.ToString(), tar.mas[j].name);
                    //dataGridView1.Rows[i].Cells[0].Value = tar.mas[j].hash.ToString();
                    //dataGridView1.Rows[i].Cells[1].Value = tar.mas[j].name;
                    
                }

            }
            for (int j = 0; j < tariph.max_elements; j++)
            {
                if (tariph.free(tariph.mas[j]))
                    continue;
                else
                {
                    dataGridView2.Rows.Add(tariph.mas[j].hash.ToString(), tariph.mas[j].name);
                    //dataGridView2.Rows[i].Cells[0].Value = tariph.mas[j].hash.ToString();
                    //dataGridView2.Rows[i].Cells[1].Value = tariph.mas[j].name;
                    
                }

            }
            collis_1.Text = tar.collisions.ToString();
            collis_2.Text = tariph.collisions.ToString();
        }
    }
}

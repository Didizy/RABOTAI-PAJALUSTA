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
    public partial class search_form_for_tariph : Form
    {
        spisok_tariph.nest tariph;
        Form2 f2;
        public search_form_for_tariph()
        {
            InitializeComponent();
        }

        public search_form_for_tariph(spisok_tariph.nest a, Form2 f2)
        {
            InitializeComponent();
            tariph = a;
            this.f2 = f2;
        }

        private void search_form_for_tariph_Load(object sender, EventArgs e)
        {
            dataGridViewSearchTariph.Rows.Clear();
            string[] line = new string[5];
            line[0] = tariph.provider.title;
            line[1] = tariph.hash.ToString();
            line[2] = tariph.type.ToString();
            for (int i = 0; i < tariph.provider.current_tariph; i++)
                if (tariph.provider.arr[i].name == tariph.name)
                    line[3] = tariph.provider.arr[i].cost.ToString();
            line[4] = tariph.speed.ToString();
            dataGridViewSearchTariph.Rows.Add(line);
            labelFINDNameTariph.Text = tariph.name;
            labelCompareNamberTEXT.Text = f2.tariph.comparisons.ToString();
        }

        private void dataGridViewSearchTariph_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelFINDNameTariph_Click(object sender, EventArgs e)
        {

        }
    }
}

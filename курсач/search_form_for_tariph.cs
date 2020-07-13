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
        spisok_tariph.nest pr;
        Form2 f2;
        public search_form_for_tariph()
        {
            InitializeComponent();
        }

        public search_form_for_tariph(spisok_tariph.nest a, Form2 f2)
        {
            InitializeComponent();
            pr = a;
            this.f2 = f2;
        }

        private void search_form_for_tariph_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewSearchTariph_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelFINDNameTariph_Click(object sender, EventArgs e)
        {

        }
    }
}

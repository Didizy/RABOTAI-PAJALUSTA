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
    public partial class search_form_user : Form
    {
        spisok_users.nest pr;
        Form2 f2;
        public search_form_user()
        {
            InitializeComponent();
        }

        public search_form_user(spisok_users.nest a, Form2 f2)
        {
            InitializeComponent();
            pr = a;
            this.f2 = f2;
        }

        private void labelCompareNum_Click(object sender, EventArgs e)
        {

        }

        private void search_form_user_Load(object sender, EventArgs e)
        {

        }
    }
}

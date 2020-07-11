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
    public partial class Form2 : Form
    {
        tree_providers provider;
        spisok_tariph tariph;
        spisok_users user;
        tree_sale sales;
        public Form2()
        {
            InitializeComponent();
            provider = new tree_providers();
            tariph = new spisok_tariph();
            user = new spisok_users();
            sales = new tree_sale();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            spisok_tariph.nest a = tariph.find(tariph_find_title.Text, provider.find(tariph_find_provider.Text));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tariph.delete(tariph_del_title.Text, provider.find(tariph_del_provider.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int type = 0;
            if (tariph_type.Text == "Интернет")
                type = 1;
            else if (tariph_type.Text == "Интернет и ТВ")
                type = 2;
            else if (tariph_type.Text == "ТВ")
                type = 3;
            else
            {

                return;
            }
            provider.add_tariph(tariph_title.Text,Convert.ToInt32(tariph_cost.Text),tariph_provider.Text);
            tariph.add(tariph.getkey(tariph_title.Text), tariph_title.Text, type, Convert.ToInt32(tariph_speed.Text), provider.find(tariph_provider.Text));
            tariph_title.Text = tariph_cost.Text=tariph_provider.Text = tariph_speed.Text=tariph_type.Text="" ;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            int ind_to_show = 1 ;
            bool end = false;
            tree_providers.root a;
            while (!end)
            {
                i = 0;   
                a = provider.print_provider(ind_to_show, provider.main, ref i);
                Провайдеры.Items.Add(a.title);
                ind_to_show++;
                if (a == null)
                    end = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            provider.add_Provider(Provider_title.Text);
            Provider_title.Text = "";
        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            user.add(user.get_hash(user_login.Text), user_login.Text, user_date.Text, tariph.find(user_tariph.Text, provider.find(user_provider.Text)));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void add_sale_Click(object sender, EventArgs e)
        {
            sales.add_sale(sale_length.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            provider.delete(provider_del_title.Text);
        }

        private void find_provider_Click(object sender, EventArgs e)
        {
            tree_providers.root a = provider.find(find_provider.Text);
        }

        private void Provider_title_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

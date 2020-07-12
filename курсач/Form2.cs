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
        //переменные для окон//лучше будет загнать в отдельный файлл
        int error_number;
        DialogResult message_choise_resilt;

        public Form2()
        {
            InitializeComponent();
            provider = new tree_providers();
            tariph = new spisok_tariph();
            user = new spisok_users();
            sales = new tree_sale();
        }

        public void message_box(int error_number)
        {
            int switch_on = error_number;//код ошибки или ее отсутсвие

            switch (switch_on)
            {
                case 0://ошибок нет
                    MessageBox.Show("Элемент добавлен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1://заполнены не все поля
                    message_choise_resilt = MessageBox.Show("Заполнены не все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2://некоректный ввод данных
                    MessageBox.Show("Введены некореектные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default: break;
            }


            
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
            //прихуярить текст боксы!!! для вида услуги
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
            tariph_find_title.Text = tariph_find_provider.Text = "";
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
            sales.delete_tariph(tariph.find(tariph_del_title.Text, provider.find(tariph_del_provider.Text)),sales.main);
            tariph.delete(tariph_del_title.Text, provider.find(tariph_del_provider.Text));
            tariph_del_title.Text = tariph_del_provider.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //тут прописать чек боксы
            /*int type = 0;
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
            tariph_title.Text = tariph_cost.Text=tariph_provider.Text = tariph_speed.Text=tariph_type.Text="" ;*/
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
                //Провайдеры.Items.Add(a.title);
                ind_to_show++;
                if (a == null)
                    end = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            provider.add_Provider(Provider_title.Text);
            Provider_title.Text = "";

            error_number = 1;
            message_box(error_number);

                

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            user.add(user.get_hash(user_login.Text), user_login.Text, user_date.Text, tariph.find(user_tariph.Text, provider.find(user_provider.Text)));
            user_login.Text = user_date.Text = user_tariph.Text = user_provider.Text = "";
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
            spisok_tariph.nest a = tariph.find(sale_tariph.Text, provider.find(sale_provider.Text));
            sales.add_sale(sale_num.Text, sale_length.Text, a, a.provider);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tree_providers.root pr = provider.find(provider_del_title.Text);

            while (pr.current_user > 0)
            {
                user.delete(pr.users[0]);
                provider.delete_user(pr.users[0], pr.title);
            }
            while (pr.current_tariph > 0) 
            {
                sales.delete_tariph(tariph.find(pr.arr[0].name,pr), sales.main);
                tariph.delete(pr.arr[0].name, pr);
                provider.del_tariph(pr.arr[0].name, pr);
            }
            provider.delete(provider_del_title.Text);
            provider_del_title.Text = "";
        }

        private void find_provider_Click(object sender, EventArgs e)
        {
            tree_providers.root a = provider.find(find_provider.Text);
            find_provider.Text = "";


            searchform_provider searchform = new searchform_provider();

            
            
            searchform.Show();
            
        }

        private void Provider_title_TextChanged(object sender, EventArgs e)
        {

        }

        private void del_user_Click(object sender, EventArgs e)
        {
            spisok_users.nest a = user.find(user_del_login.Text);
            provider.delete_user(user_del_login.Text, a.tariph.provider.title);
            user.delete(user_del_login.Text);
            user_del_login.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sales.delete(sale_del_size.Text, tariph.find(sale_del_tar.Text, provider.find(sale_del_provider.Text)));
            sale_del_tar.Text = sale_del_size.Text = sale_del_provider.Text = "";
        }

        private void user_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_del_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            user.find(user_find_login.Text);
            user_find_login.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sales.find(sale_find_size.Text, tariph.find(sale_find_tariph.Text, provider.find(sale_find_provider.Text)));
            sale_find_provider.Text = sale_find_size.Text = sale_find_tariph.Text = "";
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewProvidersAndTariphs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewUsersAndSells_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBoxAddTariphTV_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

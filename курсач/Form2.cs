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
    public partial class Form2 : Form
    {
       public tree_providers provider;
       public spisok_tariph tariph;
       public spisok_users user;
       public tree_sale sales;
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

        public bool check_for_int(string a)
        {
            for(int i = 0; i<a.Length;i++)
                if(((int)a[i]<48)||((int)a[i]>57))
                    return false;
            return true;
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
            int type = 0;
            if ((checkBoxAddTariphInternet.Checked) && (checkBoxAddTariphTV.Checked))
            {
                type = 2;
            }
            else if ((checkBoxAddTariphInternet.Checked) && !(checkBoxAddTariphTV.Checked))
            {
                type = 1;
            }
            else if (!(checkBoxAddTariphInternet.Checked) && (checkBoxAddTariphTV.Checked))
            {
                type = 3;
            }
            else {
                error_number = 1;
                message_box(error_number);
            }
            if (!check_for_int(tariph_cost.Text))
            {
                error_number = 2;
                message_box(error_number);
            }
            if (!check_for_int(tariph_speed.Text))
            {
                error_number = 2;
                message_box(error_number);
            }

      
            provider.add_tariph(tariph_title.Text,Convert.ToInt32(tariph_cost.Text),tariph_provider.Text);
            
            tariph.add(tariph.getkey(tariph_title.Text), tariph_title.Text, type, Convert.ToInt32(tariph_speed.Text), provider.find(tariph_provider.Text));
            error_number = 0;
            message_box(error_number);
            tariph_title.Text = tariph_cost.Text=tariph_provider.Text = tariph_speed.Text="" ;
            checkBoxAddTariphTV.Checked = false;
            checkBoxAddTariphInternet.Checked = false;
            //checkBoxAddTariphTV.AutoCheck = false;
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
            if (Provider_title.Text == "")
            {
                error_number = 1;
                message_box(error_number);
            }
            provider.add_Provider(Provider_title.Text);
            error_number = 0;
            message_box(error_number);
            Provider_title.Text = "";

           

                

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
            tree_providers.root a = provider.find(provider_find_title.Text);
            provider_find_title.Text = "";


            searchform_provider searchform = new searchform_provider(a,this);


            //searchform.Owner = this;
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

        public void output(StreamWriter file, tree_providers.root pr)
        {
            if (pr == null)
                return;
            file.WriteLine(pr.title);
           // file.Write("\n");
            for(int i = 0; i < pr.current_tariph; i++)
            {
                string temp = "";
                temp += pr.arr[i].name;
                temp += "/";
                temp += pr.arr[i].cost.ToString();
                spisok_tariph.nest a = tariph.find(pr.arr[i].name, pr);
                temp += "/";
                temp += a.type.ToString();
                temp += "/";
                temp += a.speed.ToString();
                file.WriteLine(temp);
               // file.Write("\n");

            }
            file.WriteLine("//");
            output(file, pr.left);
            output(file, pr.right);
        }
        private void to_file_Click(object sender, EventArgs e)
        {
            StreamWriter file_out = new StreamWriter(@"a:\gitjub\курсач\output.txt");
            //file_out.WriteLine("РАБОТАЙ");
            output(file_out, provider.main);
            file_out.Close();
        }

        public void input(StreamReader file)
        {
            String temp;
            string provider_name;
            string helper = "";
            string[] info = new string[4];
            int j = 0;
            tree_providers.root pr;
            while (file.Peek() > -1)
            {
                temp = file.ReadLine();
                provider_name = temp;
                provider.add_Provider(provider_name);
                pr = provider.find(provider_name);
                
                while (true)
                {
                    temp = file.ReadLine();
                    helper = "";
                    if (temp == "//")
                        break;
                    for (int i = 0; i < temp.Length; i++)
                    {
                        if (temp[i] == '/')
                        {
                            i++;
                            info[j] = helper;
                            j++;
                            helper = "";
                        }
                        helper += temp[i];
                    }
                    j = 0;
                    info[3] = helper;
                    if ((!check_for_int(info[1])) && (!check_for_int(info[2])) && (!check_for_int(info[3])))
                    {
                        error_number = 2;
                        message_box(error_number);
                    }
                    provider.add_tariph(info[0], Convert.ToInt32(info[1]), provider_name);

                    tariph.add(tariph.getkey(info[0]), info[0], Convert.ToInt32(info[2]), Convert.ToInt32(info[3]), pr);
                }
            }
        }
        private void from_file_button_Click(object sender, EventArgs e)
        {
            StreamReader file_in = new StreamReader(@"a:\gitjub\курсач\output.txt");
            input(file_in);
            file_in.Close();

        }
    }
}

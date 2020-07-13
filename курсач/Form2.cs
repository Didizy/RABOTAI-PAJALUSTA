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
                    message_choise_resilt = MessageBox.Show("Введены некореектные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3://элемент не существует
                    message_choise_resilt = MessageBox.Show("Элемент не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 4://элемент уже существует
                    message_choise_resilt = MessageBox.Show("Элемент уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)//поиск тарифа
        {
            if ((tariph_find_provider.Text == "") || (tariph_find_title.Text == ""))
            {
                error_number = 1;
                message_box(error_number);
            }
            else if ((provider.find(tariph_find_provider.Text) == null) || (tariph.find(tariph_find_title.Text, provider.find(tariph_find_provider.Text)) == null))
            {
                error_number = 3;
                message_box(error_number);
            }
            else
            {
                spisok_tariph.nest a = tariph.find(tariph_find_title.Text, provider.find(tariph_find_provider.Text));
                search_form_for_tariph searchform = new search_form_for_tariph(a, this);

                searchform.Show();
            }

            tariph_find_provider.Text = "";
            tariph_find_title.Text = "";
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
            int error_number = 0;
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
            else 
            {
                error_number = 1;
            }
            if (!check_for_int(tariph_cost.Text))
            {
                error_number = 2;
            }
            if (!check_for_int(tariph_speed.Text))
            {
                error_number = 2;
            }
            else
            {
                provider.add_tariph(tariph_title.Text, Convert.ToInt32(tariph_cost.Text), tariph_provider.Text);

                tariph.add(tariph.getkey(tariph_title.Text), tariph_title.Text, type, Convert.ToInt32(tariph_speed.Text), provider.find(tariph_provider.Text));                
                tariph_title.Text = tariph_cost.Text = tariph_provider.Text = tariph_speed.Text = "";
                checkBoxAddTariphTV.Checked = false;
                checkBoxAddTariphInternet.Checked = false;
            }

            message_box(error_number);
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
           
           // provider.add_Provider(Provider_title.Text);
            error_number = 0;

            
            
            if (Provider_title.Text == "")
            {
                error_number = 1;
            }
            else if (provider.find(Provider_title.Text) != null)
            {
                error_number = 4;
            }
            else
            {
                provider.add_Provider(Provider_title.Text);
            }

            message_box(error_number);
            Provider_title.Text = "";
        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            user.add(/*user.get_hash(user_login.Text),*/ user_login.Text, user_date.Text, tariph.find(user_tariph.Text, provider.find(user_provider.Text)));
            provider.add_user(user_login.Text, user_provider.Text);
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
            sale_num.Text = sale_tariph.Text = sale_provider.Text = sale_length.Text = "";
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
            if (provider_find_title.Text == "")
            {
                error_number = 1;
                message_box(error_number);
            }
            else if (provider.find(provider_find_title.Text)==null)
            {
                error_number = 3;
                message_box(error_number);
            }
            else
            {
                tree_providers.root a = provider.find(provider_find_title.Text);
                searchform_provider searchform = new searchform_provider(a, this);

                searchform.Show();
            }
            provider_find_title.Text = "";
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
            if (user_find_login.Text == "")
            {
                error_number = 1;
                message_box(error_number);
            }
            else if (user.find(user_find_login.Text) == null)
            {
                error_number = 3;
                message_box(error_number);
            }
            else
            {
                spisok_users.nest a = user.find(user_find_login.Text);
                search_form_user searchform = new search_form_user(a, this);
                searchform.Show();
            }

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
        public void get_provider_info(string[] line, tree_providers.root pr)
        {
            if (pr == null)
                return;
            line[0] = pr.title;
            for(int i = 0; i < pr.current_tariph; i++)
            {
                spisok_tariph.nest a = tariph.find(pr.arr[i].name, pr);
                line[1] = a.hash.ToString();
                line[2] = pr.arr[i].name;
                line[3] = a.type.ToString();
                line[4] = a.speed.ToString();
                line[5] = pr.arr[i].cost.ToString();
                dataGridViewProvidersAndTariphs.Rows.Add(line);
            }
            get_provider_info(line, pr.left);
            get_provider_info(line, pr.right);
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
        public void output_for_sales(StreamWriter file,tree_sale.root parent)
        {
            if (parent == null)
                return;
            string output = "";
            output += parent.size;
            output += "/";
            output += parent.date;
            output += "/";
            output += parent.tariph.name;
            output += "/";
            output += parent.tariph.provider.title;
            file.WriteLine(output);
            output_for_sales(file, parent.left);
            output_for_sales(file, parent.right);
        }

/*        private void to_file_Click(object sender, EventArgs e)
        {
            StreamWriter out_file = new StreamWriter(@"c:\курсач\курсач\output_user.txt"); //(@"c:\курсач\курсач\output_user.txt"); @"a:\gitjub\курсач\output_user.txt"
            spisok_users.nest a = user.first;
            spisok_users.nest temp = a.chain_next;
            string output;
            while (true)
            {
                output = "";
                output += a.login;
                output += "/";
                output += a.date;
                output += "/";
                output += a.tariph.name;
                out_file.WriteLine(output);
                while (temp != a)
                {
                    output = "";
                    output += temp.login;
                    output += "/";
                    output += temp.date;
                    output += "/";
                    output += temp.tariph.name;
                    out_file.WriteLine(output);
                    temp = temp.chain_next;

                }
                a = a.next;
                if (a == null)
                    break;
                temp = a.chain_next;
            }
            out_file.WriteLine("//");
            output_for_sales(out_file, sales.main);
            out_file.Close();

        }
        private void from_file_button_Click(object sender, EventArgs e)
        {


        }
*/
        public void output_for_provider(StreamWriter file, tree_providers.root pr)
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
            output_for_provider(file, pr.left);
            output_for_provider(file, pr.right);
        }
       

        public void input_for_provider(StreamReader file)
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
     
        
        /*private void save_provider_Click(object sender, EventArgs e)
        {
            StreamWriter file_out = new StreamWriter(@"c:\курсач\курсач\output_provider.txt");//@"c:\курсач\курсач\output_provider.txt"a:\gitjub\курсач\output_provider.txt
            //file_out.WriteLine("РАБОТАЙ");
            output_for_provider(file_out, provider.main);
            file_out.Close();
        }*/

        /*private void load_provider_Click(object sender, EventArgs e)
        {
            StreamReader file_in = new StreamReader(@"c:\курсач\курсач\output_user.txt");//(@"c:\курсач\курсач\output_user.txt");//@"a:\gitjub\курсач\output_provider.txt"
            input_for_provider(file_in);
            file_in.Close();
        }*/

        private void refresh_provider_Click(object sender, EventArgs e)
        {
            dataGridViewProvidersAndTariphs.Rows.Clear();
            string[] prov = new string[6];
            get_provider_info(prov, provider.main);
        }
        public void sale_out(string[] line, tree_sale.root s)
        {
            if (s == null)
                return;
            for (int i = 0; i < s.tariph.provider.current_user; i++)
            {
                spisok_users.nest u = user.find(s.tariph.provider.users[i]);
                if (s.tariph == u.tariph)
                {
                    if (user.Can_get_sale(u, s))
                    {
                        line[0] = s.size;
                    }
                    else
                    {
                        line[0] = "0";
                    }
                    line[1] = s.date + " Месяцев";
                    line[2] = u.hash.ToString();
                    line[3] = u.login;
                    line[4] = s.tariph.name;
                    line[5] = u.date;
                    dataGridViewUsersAndSells.Rows.Add(line);

                }
                
            }
            sale_out(line, s.left);
            sale_out(line, s.right);
        }

        private void refresh_users_Click(object sender, EventArgs e)
        {
            dataGridViewUsersAndSells.Rows.Clear();
            string[] line = new string[6];
            sale_out(line, sales.main);
        }
        
        private void provider_find_title_TextChanged(object sender, EventArgs e)
        {

        }

        private void tariph_find_title_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_provider_Click_1(object sender, EventArgs e)
        {
            StreamWriter file_out = new StreamWriter(@"c:\курсач\курсач\output_provider.txt");//@"c:\курсач\курсач\output_provider.txt"a:\gitjub\курсач\output_provider.txt
            //file_out.WriteLine("РАБОТАЙ");
            output_for_provider(file_out, provider.main);
            file_out.Close();
        }

        private void load_provider_Click_2(object sender, EventArgs e)
        {
            StreamReader file_in = new StreamReader(@"c:\курсач\курсач\output_provider.txt");//(@"c:\курсач\курсач\output_user.txt");//@"a:\gitjub\курсач\output_provider.txt"
            input_for_provider(file_in);
            file_in.Close();
        }

        private void to_file_Click_1(object sender, EventArgs e)
        {
            StreamWriter out_file = new StreamWriter(@"c:\курсач\курсач\output_user.txt"); //(@"c:\курсач\курсач\output_user.txt"); @"a:\gitjub\курсач\output_user.txt"
            spisok_users.nest a = user.first;
            spisok_users.nest temp = a.chain_next;
            string output;
            while (true)
            {
                output = "";
                output += a.login;
                output += "/";
                output += a.date;
                output += "/";
                output += a.tariph.name;
                output += "/";
                output += a.tariph.provider.title;
                out_file.WriteLine(output);
                while ((temp != a)&&!(temp==null))
                {
                    output = "";
                    output += temp.login;
                    output += "/";
                    output += temp.date;
                    output += "/";
                    output += temp.tariph.name;
                    output += "/";
                    output += temp.tariph.provider.title;
                    out_file.WriteLine(output);
                    temp = temp.chain_next;

                }
                temp = a.next;
                if (temp == a)
                    break;
                temp = a.chain_next;
            }
            out_file.WriteLine("//");
            output_for_sales(out_file, sales.main);
            out_file.Close();
        }

        private void from_file_button_Click_1(object sender, EventArgs e)
        {
            StreamReader file_in = new StreamReader(@"c:\курсач\курсач\output_user.txt");
            string[] line = new string[4];
            string temp = file_in.ReadLine();
            while (temp != "//")
            {
                int j = 0;
                int i = 0;
                while (j < temp.Length)
                {
                    if (temp[j] == '/')
                    {
                        j++;
                        i++;
                    }
                    
                    line[i] += temp[j];
                    j++;
                }
                user.add(line[0], line[1], tariph.find(line[2], provider.find(line[3])));
                provider.add_user(line[0], line[3]);
                line[0] = line[1] = line[2] = line[3] = "";
                temp = file_in.ReadLine();
            }
            
            while (file_in.Peek() > -1)
            {
                temp = file_in.ReadLine();
                int j = 0;
                int i = 0;
                while (j < temp.Length)
                {
                    if (temp[j] == '/')
                    {
                        j++;
                        i++;
                    }
                    line[i] += temp[j];
                    j++;
                }
                spisok_tariph.nest a = tariph.find(line[2], provider.find(line[3]));
                sales.add_sale(line[0], line[1], a, a.provider);
                line[0] = line[1] = line[2] = line[3] = "";

            }
            file_in.Close();
           

        }
    }
}

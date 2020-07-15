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
using System.Text.RegularExpressions;

namespace курсач
{
    public partial class Form2 : Form
    {
        public tree_providers provider;
        public spisok_tariph tariph;
        public spisok_users user;
        public tree_sale sales;
        
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
            for (int i = 0; i < a.Length; i++)
                if (((int)a[i] < 48) || ((int)a[i] > 57))
                    return false;
            return true;
        }
        
        public bool sale_check(string sale)
        {
            if (sale.Length < 3)
            {
                string r1 = "[0-9]{2}";
                string r2 = "[0-9]{1}";

                if (Regex.IsMatch(sale, r1) || Regex.IsMatch(sale, r2))
                    return true;
            }
            return false;
        }
        public bool date_check(string date)
        {
            string r1 = "[0][1-9].[0][1-9].[2][0][0|1][0-9]";
            string r4 = "[0][1-9].[1][0-2].[2][0][0|1][0-9]";

            string r2 = "[1-2][0-9].[0][1-9].[2][0][0|1][0-9]";
            string r5 = "[1-2][0-9].[1][0-2].[2][0][0|1][0-9]";

            string r3 = "[3][0-1].[0][1-9].[2][0][0|1][0-9]";
            string r6 = "[3][0-1].[1][0-2].[2][0][0|1][0-9]";


            string r7 = "[0][1-9].[0][1-9].[2][0][2][0]";
            string r8 = "[0][1-9].[1][0-2].[2][0][2][0]";

            string r9 = "[1-2][0-9].[0][1-9].[2][0][2][0]";
            string r10 = "[1-2][0-9].[1][0-2].[2][0][2][0]";

            string r11 = "[3][0-1].[0][1-9].[2][0][2][0]";
            string r12 = "[3][0-1].[1][0-2].[2][0][2][0]";

            if (Regex.IsMatch(date, r1) || Regex.IsMatch(date, r2) || Regex.IsMatch(date, r3) || Regex.IsMatch(date, r4) || Regex.IsMatch(date, r5)
                || Regex.IsMatch(date, r6) || Regex.IsMatch(date, r7) || Regex.IsMatch(date, r8) || Regex.IsMatch(date, r9) || Regex.IsMatch(date, r10)
                || Regex.IsMatch(date, r11) || Regex.IsMatch(date, r12))
                return true;

            return false;
        }

        int error_number;
        DialogResult message_choise_resilt;

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
                    message_choise_resilt = MessageBox.Show("Введены некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3://элемент не существует
                    message_choise_resilt = MessageBox.Show("Элемент не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 4://элемент уже существует
                    message_choise_resilt = MessageBox.Show("Элемент уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 5://отчет не был создан
                    message_choise_resilt = MessageBox.Show("Отчен не сформирован", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 10://удаление прошло
                    MessageBox.Show("Элемент удален", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default: break;
            }



        }


        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader file_in = new StreamReader(@"c:\курсач\курсач\output_provider.txt");//(@"c:\курсач\курсач\output_user.txt");//@"a:\gitjub\курсач\output_provider.txt"
            input_for_provider(file_in);
            file_in.Close();
            file_in = new StreamReader(@"c:\курсач\курсач\output_user.txt");//@"a:\gitjub\курсач\output_user.txt"
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
                if (provider.find(line[3]) == null)
                {
                    message_choise_resilt = MessageBox.Show("Элемент не может быть добавлен. Перейти к следующему?", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    user.add(line[0], line[1], tariph.find(line[2], provider.find(line[3])));
                    provider.add_user(line[0], line[3]);

                }
                line[0] = line[1] = line[2] = line[3] = "";
                temp = file_in.ReadLine();

                if (message_choise_resilt == DialogResult.Cancel)
                {
                    file_in.Close();
                    return;
                }


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
        private void Form2_close(object sender, EventArgs e)
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
            else if (tariph_find_provider.Text.Length > 30 || tariph_find_provider.Text.Length > 30)
            {
                error_number = 2;
                message_box(error_number);
            }
            else if ((provider.find(tariph_find_provider.Text) == null) || (tariph.find(tariph_find_title.Text, provider.find(tariph_find_provider.Text)) == null))
            {
                error_number = 3;
                message_box(error_number);
            }
            else
            {
                tariph.comparisons = 0;
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
            tree_providers.root check1 = provider.find(tariph_del_provider.Text);
            spisok_tariph.nest check = null;
            if (check1 != null)
                check = tariph.find(tariph_del_title.Text, check1);
            spisok_tariph.nest a = check;
            if (tariph_del_title.Text == "" || tariph_del_provider.Text == "")
            {
                error_number = 1;
                message_box(error_number);
            }
            else if (tariph_del_title.Text.Length > 30 || tariph_del_provider.Text.Length > 30)
            {
                error_number = 2;
                message_box(error_number);
            }
            else if (check == null || check1 == null)
            {
                error_number = 3;
                message_box(error_number);
            }
            else
            {
                for (int i = 0; i < a.provider.current_user; i++)
                {
                    if (user.find(a.provider.users[i]).tariph == a)
                        user.delete(a.provider.users[i]);
                }
                sales.delete_tariph(tariph.find(tariph_del_title.Text, provider.find(tariph_del_provider.Text)), sales.main);
                tariph.delete(tariph_del_title.Text, provider.find(tariph_del_provider.Text));
                error_number = 10;
                message_box(error_number);
            }
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
            else if (tariph_title.Text == "" || tariph_provider.Text == "" || tariph_cost.Text == "")
            {
                error_number = 1;
                //message_box(error_number);
            }
            else if (tariph_title.Text.Length > 30 || tariph_provider.Text.Length > 30 || tariph_cost.Text.Length > 8 || tariph_speed.Text.Length > 10) 
            {
                error_number = 2;
                message_box(error_number);
            }
            else if (checkBoxAddTariphTV.Checked && !(checkBoxAddTariphInternet.Checked))
            {
                if ((Convert.ToInt32(tariph_speed.Text) != 0) || (tariph_speed.Text != ""))
                    error_number = 2;
            }

            else
            {
                bool can_add = provider.add_tariph(tariph_title.Text, Convert.ToInt32(tariph_cost.Text), tariph_provider.Text);
                if (!can_add)
                {
                    error_number = 4;
                }
                else
                    tariph.add(tariph.getkey(tariph_title.Text), tariph_title.Text, type, Convert.ToInt32(tariph_speed.Text), provider.find(tariph_provider.Text));
            }

            message_box(error_number);
            tariph_title.Text = tariph_cost.Text = tariph_provider.Text = tariph_speed.Text = "";
            checkBoxAddTariphTV.Checked = false;
            checkBoxAddTariphInternet.Checked = false;
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
            int ind_to_show = 1;
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
            else if (Provider_title.Text.Length > 30)
            {
                error_number = 2;
                message_box(error_number);
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
            tree_providers.root check1 = provider.find(user_provider.Text);
            spisok_tariph.nest check = null;
            if (check1 != null)
                check = tariph.find(user_tariph.Text, provider.find(user_provider.Text));

            if (user_login.Text == "" || user_provider.Text == "" || user_tariph.Text == "" || user_date.Text == "")
            {
                error_number = 1;
                message_box(error_number);
            }
            else if (!date_check(user_date.Text) || user_login.Text.Length > 30 || user_provider.Text.Length > 30 || user_tariph.Text.Length > 30)
            {
                error_number = 2;
                message_box(error_number);
            }
            else if (check == null || check1 == null)
            {
                error_number = 3;
                message_box(error_number);
            }
            else if (user.find(user_login.Text) != null)
            {
                error_number = 4;
                message_box(error_number);
            }
            else
            {
                user.add(/*user.get_hash(user_login.Text),*/ user_login.Text, user_date.Text, tariph.find(user_tariph.Text, provider.find(user_provider.Text)));
                provider.add_user(user_login.Text, user_provider.Text);
                error_number = 0;
                message_box(error_number);
            }

            user_login.Text = user_date.Text = user_tariph.Text = user_provider.Text = "";
        }//

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
            tree_providers.root check1 = provider.find(sale_provider.Text);
            spisok_tariph.nest check = null;
            if (check1 != null)
                check = tariph.find(sale_tariph.Text, provider.find(sale_provider.Text));

            if (sale_num.Text == "" || sale_length.Text == "" || sale_provider.Text == "" || sale_tariph.Text == "")
            {
                error_number = 1;
                message_box(error_number);
            }
            else if (!sale_check(sale_provider.Text) || check_for_int(sale_length.Text) || sale_length.Text.Length > 3 || sale_provider.Text.Length > 30 || sale_tariph.Text.Length > 30)
            {
                error_number = 2;
                message_box(error_number);
            }
            else if (check == null || check1 == null)
            {
                error_number = 3;
                message_box(error_number);
            }
            else if (sales.find(sale_num.Text, check) != null)
            {
                error_number = 4;
                message_box(error_number);
            }
            else
            {
                spisok_tariph.nest a = tariph.find(sale_tariph.Text, provider.find(sale_provider.Text));
                sales.add_sale(sale_num.Text, sale_length.Text, a, a.provider);

                error_number = 0;
                message_box(error_number);
            }
            sale_num.Text = sale_tariph.Text = sale_provider.Text = sale_length.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tree_providers.root pr = provider.find(provider_del_title.Text);
            if (provider_del_title.Text == "")
            {
                error_number = 1;
                message_box(error_number);
            }
            else if (provider_del_title.Text.Length > 30)
            {
                error_number = 2;
                message_box(error_number);
            }
            else if (pr == null)
            {
                error_number = 3;
                message_box(error_number);
            }
            else
            {
                while (pr.current_user > 0)
                {
                    user.delete(pr.users[0]);
                    provider.delete_user(pr.users[0], pr.title);
                }
                while (pr.current_tariph > 0)
                {
                    sales.delete_tariph(tariph.find(pr.arr[0].name, pr), sales.main);
                    tariph.delete(pr.arr[0].name, pr);
                    provider.del_tariph(pr.arr[0].name, pr);
                }
                provider.delete(provider_del_title.Text);
                error_number = 10;
                message_box(error_number);
            }
            provider_del_title.Text = "";
        }

        private void find_provider_Click(object sender, EventArgs e)
        {
            if (provider_find_title.Text == "")
            {
                error_number = 1;
                message_box(error_number);
            }
            else if (provider_find_title.Text.Length > 30)
            {
                error_number = 2;
                message_box(error_number);
            }
            else if (provider.find(provider_find_title.Text) == null)
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

            if (user_del_login.Text == "")
            {
                error_number = 1;
                message_box(error_number);
            }
            else if (user_del_login.Text.Length > 30)
            {
                error_number = 2;
                message_box(error_number);
            }
            else if (a == null)
            {
                error_number = 3;
                message_box(error_number);
            }
            else
            {
                provider.delete_user(user_del_login.Text, a.tariph.provider.title);
                user.delete(user_del_login.Text);
                error_number = 10;
                message_box(error_number);
            }
            user_del_login.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tree_providers.root check1 = provider.find(sale_del_provider.Text);
            spisok_tariph.nest check = null;
            if (check1 != null)
                check = tariph.find(sale_del_tar.Text, provider.find(sale_del_provider.Text));

            if (sale_del_size.Text == "" || sale_del_tar.Text == "" || sale_del_provider.Text == "")
            {
                error_number = 1;
                message_box(error_number);
            }
            else if (!sale_check(sale_del_size.Text) || sale_del_tar.Text.Length > 30 || sale_find_provider.Text.Length > 30)
            {
                error_number = 2;
                message_box(error_number);
            }
            else if (check1 == null || check == null)
            {
                error_number = 3;
                message_box(error_number);
            }
            else if (sales.delete(sale_del_size.Text, tariph.find(sale_del_tar.Text, provider.find(sale_del_provider.Text))) == false)
            {
                error_number = 3;
                message_box(error_number);
            }
            else
            {
                sales.delete(sale_del_size.Text, tariph.find(sale_del_tar.Text, provider.find(sale_del_provider.Text)));
                error_number = 10;
                message_box(error_number);
            }
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
            else if (user_find_login.Text.Length > 30)
            {
                error_number = 2;
                message_box(error_number);
            }
            else if (user.find(user_find_login.Text) == null)
            {
                error_number = 3;
                message_box(error_number);
            }
            else
            {
                user.comparisons = 0;
                spisok_users.nest a = user.find(user_find_login.Text);
                search_form_user searchform = new search_form_user(a, this);
                searchform.Show();
            }

            user_find_login.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tree_providers.root check1 = provider.find(sale_find_provider.Text);
            spisok_tariph.nest check = null;
            if (check1 != null)
                check = tariph.find(sale_find_tariph.Text, provider.find(sale_find_provider.Text));

            if (sale_find_tariph.Text == "" || sale_find_provider.Text == "" || sale_find_size.Text == "")
            {
                error_number = 1;
                message_box(error_number);
            }
            else if (!sale_check(sale_find_size.Text) || sale_find_provider.Text.Length > 30 || sale_find_tariph.Text.Length > 30)
            {
                error_number = 2;
                message_box(error_number);
            }
            else if (check == null || check1 == null || sales.find(sale_find_size.Text, tariph.find(sale_find_tariph.Text, provider.find(sale_find_provider.Text))) == null)
            {
                error_number = 3;
                message_box(error_number);
            }
            else
            {
                sales.find(sale_find_size.Text, tariph.find(sale_find_tariph.Text, provider.find(sale_find_provider.Text)));
            }

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
            for (int i = 0; i < pr.current_tariph; i++)
            {
                line[1] = pr.arr[i].name;
                line[2] = pr.arr[i].cost.ToString();
                dataGridViewProviders.Rows.Add(line);
            }
            /*switch (a.type)
            {
                case 1:
                    line[3] = "Интеренет";
                    break;
                case 2:
                    line[3] = "Интернет и ТВ";
                    break;
                case 3:
                    line[3] = "ТВ";
                    break;
            }
            //line[3] = a.type.ToString();
            line[4] = a.speed.ToString();
            line[5] = pr.arr[i].cost.ToString();

        }*/

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
        public void output_for_sales(StreamWriter file, tree_sale.root parent)
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
            for (int i = 0; i < pr.current_tariph; i++)
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
                bool check_provider = provider.add_Provider(provider_name);
                if (!check_provider)
                {
                    message_choise_resilt = MessageBox.Show("Элемент не может быть добавлен. Перейти к следующему?", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
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
                if (message_choise_resilt == DialogResult.Cancel)
                {
                    file.Close();
                    return;
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
            dataGridViewProviders.Rows.Clear();
            dataGridViewTariphs.Rows.Clear();
            string[] prov = new string[3];
            string[] tar = new string[5];
            get_provider_info(prov, provider.main);
            spisok_tariph.nest temp = tariph.first;
            if (!tariph.free(temp))
            {
                tar[0] = temp.provider.title;
                tar[1] = temp.hash.ToString();
                tar[2] = temp.name;
                switch (temp.type)
                {

                    case 1:
                        tar[3] = "Интеренет";
                        tar[4] = temp.speed.ToString();
                        break;
                    case 2:
                        tar[3] = "Интернет и ТВ";
                        tar[4] = temp.speed.ToString();
                        break;
                    case 3:
                        tar[3] = "ТВ";
                        tar[4] = "Нет интернета";
                        break;

                }
                dataGridViewTariphs.Rows.Add(tar);
            }
            temp = temp.next;
            while (temp != tariph.first)
            {
                if (!tariph.free(temp))
                {
                    tar[0] = temp.provider.title;
                    tar[1] = temp.hash.ToString();
                    tar[2] = temp.name;
                    switch (temp.type)
                    {

                        case 1:
                            tar[3] = "Интеренет";
                            tar[4] = temp.speed.ToString();
                            break;
                        case 2:
                            tar[3] = "Интернет и ТВ";
                            tar[4] = temp.speed.ToString();
                            break;
                        case 3:
                            tar[3] = "ТВ";
                            tar[4] = "Нет интернета";
                            break;

                    }
                    dataGridViewTariphs.Rows.Add(tar);


                }
                temp = temp.next;
            }
        }
        public void sale_out(string[] line, tree_sale.root s)
        {
            if (s == null)
                return;
            /*for (int i = 0; i < s.tariph.provider.current_user; i++)
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
                
            }*/
            line[0] = s.size;
            line[1] = s.tariph.name;
            line[2] = s.date;
            dataGridViewSales.Rows.Add(line);
            sale_out(line, s.left);
            sale_out(line, s.right);
        }

        private void refresh_users_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.Rows.Clear();
            dataGridViewSales.Rows.Clear();
            string[] sale = new string[3];
            string[] us = new string[4];
            sale_out(sale, sales.main);
            spisok_users.nest temp = user.first;
            spisok_users.nest curr = temp.chain_next;
            us[0] = temp.login;
            us[1] = temp.hash.ToString();
            us[2] = temp.tariph.name;
            us[3] = temp.date;
            dataGridViewUsers.Rows.Add(us);
            while (curr != null)
            {
                us[0] = curr.login;
                us[1] = curr.hash.ToString();
                us[2] = curr.tariph.name;
                us[3] = curr.date;
                dataGridViewUsers.Rows.Add(us);
                curr = curr.chain_next;
            }
            temp = temp.next;
            curr = temp.chain_next;
            while (temp != user.first)
            {
                us[0] = temp.login;
                us[1] = temp.hash.ToString();
                us[2] = temp.tariph.name;
                us[3] = temp.date;
                dataGridViewUsers.Rows.Add(us);
                while (curr != null)
                {
                    us[0] = curr.login;
                    us[1] = curr.hash.ToString();
                    us[2] = curr.tariph.name;
                    us[3] = curr.date;
                    dataGridViewUsers.Rows.Add(us);
                    curr = curr.chain_next;
                }
                temp = temp.next;
                curr = temp.chain_next;
            }
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
            output_for_provider(file_out, provider.main);
            file_out.Close();
        }

        private void load_provider_Click_2(object sender, EventArgs e)
        {
            StreamReader file_in = new StreamReader(@"c:\курсач\курсач\output_provider.txt");//(@"c:\курсач\курсач\output_user.txt");//@"a:\gitjub\курсач\output_provider.txt"
            input_for_provider(file_in);
            file_in.Close();
        }

        private void to_file_Click_1(object sender, EventArgs e)//исправить
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
                while (temp != null)
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
                a = a.next;
                if (a == user.first)
                    break;
                temp = a.chain_next;
            }
            out_file.WriteLine("//");
            output_for_sales(out_file, sales.main);
            out_file.Close();
        }

        private void from_file_button_Click_1(object sender, EventArgs e)
        {
            StreamReader file_in = new StreamReader(@"c:\курсач\курсач\output_user.txt");//@"a:\gitjub\курсач\output_user.txt"
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
                if (provider.find(line[3]) == null || user.find(line[0])!=null)
                {
                    message_choise_resilt = MessageBox.Show("Элемент не может быть добавлен. Перейти к следующему?", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    user.add(line[0], line[1], tariph.find(line[2], provider.find(line[3])));
                    provider.add_user(line[0], line[3]);

                }
                line[0] = line[1] = line[2] = line[3] = "";
                temp = file_in.ReadLine();

                if (message_choise_resilt == DialogResult.Cancel)
                {
                    file_in.Close();
                    return;
                }


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
                if (provider.find(line[3]) == null || tariph.find(line[2], provider.find(line[3])) == null || sales.find(line[0], tariph.find(line[2], provider.find(line[3]))) != null)
                {
                    message_choise_resilt = MessageBox.Show("Элемент не может быть добавлен. Перейти к следующему?", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    spisok_tariph.nest a = tariph.find(line[2], provider.find(line[3]));
                    sales.add_sale(line[0], line[1], a, a.provider);
                }
                
                line[0] = line[1] = line[2] = line[3] = "";
                if (message_choise_resilt == DialogResult.Cancel)
                {
                    file_in.Close();
                    return;
                }
            }

            file_in.Close();


        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewProviders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonReportAllSalesForUsers_Click(object sender, EventArgs e)
        {
            report_sales_of_user otchet = new report_sales_of_user(this);
            otchet.Show();
        }

        private void buttonReportAllTariphType_Click(object sender, EventArgs e)
        {
            report_all_tariphs_typr otchet = new report_all_tariphs_typr(this);
            otchet.Show();
        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void sale_length_TextChanged(object sender, EventArgs e)
        {

        }

        private void sale_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void sale_find_size_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


using System.IO;
namespace курсач
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            StreamWriter file_out = new StreamWriter(@"a:\gitjub\курсач\output_provider.txt");//@"c:\курсач\курсач\output_provider.txt"c:\gitjub\курсач\output_provider.txt
                                                                                              //file_out.WriteLine("РАБОТАЙ");
           // output_for_provider(file_out, provider.main);
            file_out.Close();
            StreamWriter out_file = new StreamWriter(@"a:\gitjub\курсач\output_user.txt"); //(@"c:\курсач\курсач\output_user.txt"); @"c:\gitjub\курсач\output_user.txt"
            /*spisok_users.nest a = user.first;
            if (a != null)
            {
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
            }*/

            /*int it = 0;
            string output;
            while (it<user.max_elements)
            {
                if (user.table[it] != null)//пишу удаление
                {
                    output = "";
                    output += user.table[it].login;
                    output += "/";
                    output += user.table[it].date;
                    output += "/";
                    output += user.table[it].tariph.name;
                    output += "/";
                    output += user.table[it].tariph.provider.title;
                    out_file.WriteLine(output);
                    

                    spisok_users.nest curr = user.table[it].next;
                    while (curr != user.table[it])
                    {
                        output = "";
                        output += curr.login;
                        output += "/";
                        output += curr.date;
                        output += "/";
                        output += curr.tariph.name;
                        output += "/";
                        output += curr.tariph.provider.title;
                        out_file.WriteLine(output);

                        curr = curr.next;
                    }
                }
                it++;
            }

            out_file.WriteLine("//");
            output_for_sales(out_file, sales.main);
            out_file.Close();*/
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.buttonRepAllUsers = new System.Windows.Forms.Button();
            this.buttonReportAllTariphType = new System.Windows.Forms.Button();
            this.dataGridViewTariphs = new System.Windows.Forms.DataGridView();
            this.ColumnTariphPoviderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTariphHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTariphName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTariphType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTariphSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewProviders = new System.Windows.Forms.DataGridView();
            this.ColumnProviderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProviderTariph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProviderCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.load_provider = new System.Windows.Forms.Button();
            this.save_provider = new System.Windows.Forms.Button();
            this.refresh_provider = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxAddTariphTV = new System.Windows.Forms.CheckBox();
            this.checkBoxAddTariphInternet = new System.Windows.Forms.CheckBox();
            this.label38 = new System.Windows.Forms.Label();
            this.tariph_provider = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Add_provider_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tariph_cost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tariph_speed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tariph_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Provider_title = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label30 = new System.Windows.Forms.Label();
            this.tariph_find_title = new System.Windows.Forms.TextBox();
            this.find_tariph = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tariph_find_provider = new System.Windows.Forms.TextBox();
            this.find_provider = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.provider_find_title = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.del_tariph_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tariph_del_title = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tariph_del_provider = new System.Windows.Forms.TextBox();
            this.del_provider = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.provider_del_title = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonRepSaleOfUser = new System.Windows.Forms.Button();
            this.buttonReportAllSalesForUsers = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.ColumnUsersLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUsersHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUsersTariph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUsersDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.ColumnSaleSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSaleTariph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from_file_button = new System.Windows.Forms.Button();
            this.to_file = new System.Windows.Forms.Button();
            this.refresh_users = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.sale_provider = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.user_provider = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.sale_length = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.sale_tariph = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.sale_num = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.add_sale = new System.Windows.Forms.Button();
            this.add_user = new System.Windows.Forms.Button();
            this.user_tariph = new System.Windows.Forms.TextBox();
            this.user_date = new System.Windows.Forms.TextBox();
            this.user_login = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label37 = new System.Windows.Forms.Label();
            this.sale_find_provider = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.user_find_login = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.sale_find_size = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.sale_find_tariph = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label26 = new System.Windows.Forms.Label();
            this.sale_del_provider = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.sale_del_size = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.sale_del_tar = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.user_del_login = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.del_user = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTariphs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProviders)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1124, 593);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage7.Controls.Add(this.button2);
            this.tabPage7.Controls.Add(this.buttonRepAllUsers);
            this.tabPage7.Controls.Add(this.buttonReportAllTariphType);
            this.tabPage7.Controls.Add(this.dataGridViewTariphs);
            this.tabPage7.Controls.Add(this.dataGridViewProviders);
            this.tabPage7.Controls.Add(this.load_provider);
            this.tabPage7.Controls.Add(this.save_provider);
            this.tabPage7.Controls.Add(this.refresh_provider);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage7.Size = new System.Drawing.Size(1116, 567);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "Просмотр";
            this.tabPage7.Click += new System.EventHandler(this.tabPage7_Click);
            // 
            // buttonRepAllUsers
            // 
            this.buttonRepAllUsers.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonRepAllUsers.Location = new System.Drawing.Point(4, 459);
            this.buttonRepAllUsers.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRepAllUsers.Name = "buttonRepAllUsers";
            this.buttonRepAllUsers.Size = new System.Drawing.Size(297, 37);
            this.buttonRepAllUsers.TabIndex = 32;
            this.buttonRepAllUsers.Text = "Отчет: все покупатели провайдера и их скидки";
            this.buttonRepAllUsers.UseVisualStyleBackColor = false;
            this.buttonRepAllUsers.Click += new System.EventHandler(this.buttonRepAllUsers_Click);
            // 
            // buttonReportAllTariphType
            // 
            this.buttonReportAllTariphType.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonReportAllTariphType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReportAllTariphType.Location = new System.Drawing.Point(4, 418);
            this.buttonReportAllTariphType.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReportAllTariphType.Name = "buttonReportAllTariphType";
            this.buttonReportAllTariphType.Size = new System.Drawing.Size(297, 37);
            this.buttonReportAllTariphType.TabIndex = 31;
            this.buttonReportAllTariphType.Text = "Отчет: все тарифы определенного вида";
            this.buttonReportAllTariphType.UseVisualStyleBackColor = false;
            this.buttonReportAllTariphType.Click += new System.EventHandler(this.buttonReportAllTariphType_Click);
            // 
            // dataGridViewTariphs
            // 
            this.dataGridViewTariphs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewTariphs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTariphs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTariphPoviderName,
            this.ColumnTariphHash,
            this.ColumnTariphName,
            this.ColumnTariphType,
            this.ColumnTariphSpeed});
            this.dataGridViewTariphs.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewTariphs.Location = new System.Drawing.Point(436, 4);
            this.dataGridViewTariphs.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTariphs.Name = "dataGridViewTariphs";
            this.dataGridViewTariphs.RowHeadersWidth = 51;
            this.dataGridViewTariphs.RowTemplate.Height = 24;
            this.dataGridViewTariphs.Size = new System.Drawing.Size(679, 410);
            this.dataGridViewTariphs.TabIndex = 30;
            // 
            // ColumnTariphPoviderName
            // 
            this.ColumnTariphPoviderName.HeaderText = "Название провайдера";
            this.ColumnTariphPoviderName.MinimumWidth = 6;
            this.ColumnTariphPoviderName.Name = "ColumnTariphPoviderName";
            this.ColumnTariphPoviderName.Width = 125;
            // 
            // ColumnTariphHash
            // 
            this.ColumnTariphHash.HeaderText = "Хеш-знаение тарифа";
            this.ColumnTariphHash.MinimumWidth = 6;
            this.ColumnTariphHash.Name = "ColumnTariphHash";
            this.ColumnTariphHash.Width = 125;
            // 
            // ColumnTariphName
            // 
            this.ColumnTariphName.HeaderText = "Название тарифа";
            this.ColumnTariphName.MinimumWidth = 6;
            this.ColumnTariphName.Name = "ColumnTariphName";
            this.ColumnTariphName.Width = 125;
            // 
            // ColumnTariphType
            // 
            this.ColumnTariphType.HeaderText = "Вид услуги";
            this.ColumnTariphType.MinimumWidth = 6;
            this.ColumnTariphType.Name = "ColumnTariphType";
            this.ColumnTariphType.Width = 125;
            // 
            // ColumnTariphSpeed
            // 
            this.ColumnTariphSpeed.HeaderText = "Скорость тарифа";
            this.ColumnTariphSpeed.MinimumWidth = 6;
            this.ColumnTariphSpeed.Name = "ColumnTariphSpeed";
            this.ColumnTariphSpeed.Width = 125;
            // 
            // dataGridViewProviders
            // 
            this.dataGridViewProviders.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProviders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProviderName,
            this.ColumnProviderTariph,
            this.ColumnProviderCost});
            this.dataGridViewProviders.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewProviders.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewProviders.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewProviders.Name = "dataGridViewProviders";
            this.dataGridViewProviders.RowHeadersWidth = 51;
            this.dataGridViewProviders.RowTemplate.Height = 24;
            this.dataGridViewProviders.Size = new System.Drawing.Size(428, 410);
            this.dataGridViewProviders.TabIndex = 29;
            this.dataGridViewProviders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProviders_CellContentClick);
            // 
            // ColumnProviderName
            // 
            this.ColumnProviderName.Frozen = true;
            this.ColumnProviderName.HeaderText = "Название провайдера";
            this.ColumnProviderName.MinimumWidth = 6;
            this.ColumnProviderName.Name = "ColumnProviderName";
            this.ColumnProviderName.Width = 125;
            // 
            // ColumnProviderTariph
            // 
            this.ColumnProviderTariph.HeaderText = "Название тарифа";
            this.ColumnProviderTariph.MinimumWidth = 6;
            this.ColumnProviderTariph.Name = "ColumnProviderTariph";
            this.ColumnProviderTariph.Width = 125;
            // 
            // ColumnProviderCost
            // 
            this.ColumnProviderCost.HeaderText = "Стоимость тарифа";
            this.ColumnProviderCost.MinimumWidth = 6;
            this.ColumnProviderCost.Name = "ColumnProviderCost";
            this.ColumnProviderCost.Width = 125;
            // 
            // load_provider
            // 
            this.load_provider.BackColor = System.Drawing.Color.PowderBlue;
            this.load_provider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.load_provider.Location = new System.Drawing.Point(1002, 522);
            this.load_provider.Name = "load_provider";
            this.load_provider.Size = new System.Drawing.Size(112, 45);
            this.load_provider.TabIndex = 28;
            this.load_provider.Text = "Загрузить";
            this.load_provider.UseVisualStyleBackColor = false;
            this.load_provider.Click += new System.EventHandler(this.load_provider_Click_2);
            // 
            // save_provider
            // 
            this.save_provider.BackColor = System.Drawing.Color.PowderBlue;
            this.save_provider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_provider.Location = new System.Drawing.Point(1002, 470);
            this.save_provider.Name = "save_provider";
            this.save_provider.Size = new System.Drawing.Size(112, 45);
            this.save_provider.TabIndex = 27;
            this.save_provider.Text = "Сохранить";
            this.save_provider.UseVisualStyleBackColor = false;
            this.save_provider.Click += new System.EventHandler(this.save_provider_Click_1);
            // 
            // refresh_provider
            // 
            this.refresh_provider.BackColor = System.Drawing.Color.PowderBlue;
            this.refresh_provider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_provider.Location = new System.Drawing.Point(1002, 419);
            this.refresh_provider.Name = "refresh_provider";
            this.refresh_provider.Size = new System.Drawing.Size(112, 45);
            this.refresh_provider.TabIndex = 1;
            this.refresh_provider.Text = "Обновить";
            this.refresh_provider.UseVisualStyleBackColor = false;
            this.refresh_provider.Click += new System.EventHandler(this.refresh_provider_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.checkBoxAddTariphTV);
            this.tabPage2.Controls.Add(this.checkBoxAddTariphInternet);
            this.tabPage2.Controls.Add(this.label38);
            this.tabPage2.Controls.Add(this.tariph_provider);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.Add_provider_button);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tariph_cost);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tariph_speed);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tariph_title);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Provider_title);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1116, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            // 
            // checkBoxAddTariphTV
            // 
            this.checkBoxAddTariphTV.AutoSize = true;
            this.checkBoxAddTariphTV.Location = new System.Drawing.Point(896, 252);
            this.checkBoxAddTariphTV.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAddTariphTV.Name = "checkBoxAddTariphTV";
            this.checkBoxAddTariphTV.Size = new System.Drawing.Size(98, 17);
            this.checkBoxAddTariphTV.TabIndex = 22;
            this.checkBoxAddTariphTV.Text = "Кабельное ТВ";
            this.checkBoxAddTariphTV.UseVisualStyleBackColor = true;
            this.checkBoxAddTariphTV.CheckedChanged += new System.EventHandler(this.checkBoxAddTariphTV_CheckedChanged);
            // 
            // checkBoxAddTariphInternet
            // 
            this.checkBoxAddTariphInternet.AutoSize = true;
            this.checkBoxAddTariphInternet.Location = new System.Drawing.Point(789, 252);
            this.checkBoxAddTariphInternet.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAddTariphInternet.Name = "checkBoxAddTariphInternet";
            this.checkBoxAddTariphInternet.Size = new System.Drawing.Size(74, 17);
            this.checkBoxAddTariphInternet.TabIndex = 21;
            this.checkBoxAddTariphInternet.Text = "Интернет";
            this.checkBoxAddTariphInternet.UseVisualStyleBackColor = true;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(650, 189);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(120, 13);
            this.label38.TabIndex = 20;
            this.label38.Text = "Название провайдера";
            this.label38.Click += new System.EventHandler(this.label38_Click);
            // 
            // tariph_provider
            // 
            this.tariph_provider.Location = new System.Drawing.Point(789, 185);
            this.tariph_provider.Margin = new System.Windows.Forms.Padding(2);
            this.tariph_provider.Name = "tariph_provider";
            this.tariph_provider.Size = new System.Drawing.Size(199, 20);
            this.tariph_provider.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(748, 371);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_provider_button
            // 
            this.Add_provider_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Add_provider_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_provider_button.Location = new System.Drawing.Point(137, 276);
            this.Add_provider_button.Margin = new System.Windows.Forms.Padding(2);
            this.Add_provider_button.Name = "Add_provider_button";
            this.Add_provider_button.Size = new System.Drawing.Size(130, 34);
            this.Add_provider_button.TabIndex = 17;
            this.Add_provider_button.Text = "Добавить";
            this.Add_provider_button.UseVisualStyleBackColor = false;
            this.Add_provider_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(650, 322);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Стоимость тарифа";
            // 
            // tariph_cost
            // 
            this.tariph_cost.Location = new System.Drawing.Point(789, 318);
            this.tariph_cost.Margin = new System.Windows.Forms.Padding(2);
            this.tariph_cost.Name = "tariph_cost";
            this.tariph_cost.Size = new System.Drawing.Size(199, 20);
            this.tariph_cost.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(650, 288);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Размер услуги";
            // 
            // tariph_speed
            // 
            this.tariph_speed.Location = new System.Drawing.Point(789, 284);
            this.tariph_speed.Margin = new System.Windows.Forms.Padding(2);
            this.tariph_speed.Name = "tariph_speed";
            this.tariph_speed.Size = new System.Drawing.Size(199, 20);
            this.tariph_speed.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(650, 255);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Вид услуги";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(650, 221);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Название тарифа";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tariph_title
            // 
            this.tariph_title.Location = new System.Drawing.Point(789, 217);
            this.tariph_title.Margin = new System.Windows.Forms.Padding(2);
            this.tariph_title.Name = "tariph_title";
            this.tariph_title.Size = new System.Drawing.Size(199, 20);
            this.tariph_title.TabIndex = 8;
            this.tariph_title.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(758, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Добавить тариф";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.Location = new System.Drawing.Point(134, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Добавить провайдера";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название провайдера";
            // 
            // Provider_title
            // 
            this.Provider_title.Location = new System.Drawing.Point(178, 225);
            this.Provider_title.Margin = new System.Windows.Forms.Padding(2);
            this.Provider_title.Name = "Provider_title";
            this.Provider_title.Size = new System.Drawing.Size(199, 20);
            this.Provider_title.TabIndex = 0;
            this.Provider_title.TextChanged += new System.EventHandler(this.Provider_title_TextChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage6.Controls.Add(this.label30);
            this.tabPage6.Controls.Add(this.tariph_find_title);
            this.tabPage6.Controls.Add(this.find_tariph);
            this.tabPage6.Controls.Add(this.label13);
            this.tabPage6.Controls.Add(this.tariph_find_provider);
            this.tabPage6.Controls.Add(this.find_provider);
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Controls.Add(this.provider_find_title);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1116, 567);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Найти";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(688, 255);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(97, 13);
            this.label30.TabIndex = 32;
            this.label30.Text = "Название тарифа";
            // 
            // tariph_find_title
            // 
            this.tariph_find_title.Location = new System.Drawing.Point(830, 251);
            this.tariph_find_title.Margin = new System.Windows.Forms.Padding(2);
            this.tariph_find_title.Name = "tariph_find_title";
            this.tariph_find_title.Size = new System.Drawing.Size(199, 20);
            this.tariph_find_title.TabIndex = 31;
            this.tariph_find_title.TextChanged += new System.EventHandler(this.tariph_find_title_TextChanged);
            // 
            // find_tariph
            // 
            this.find_tariph.BackColor = System.Drawing.Color.LightGreen;
            this.find_tariph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.find_tariph.Location = new System.Drawing.Point(776, 304);
            this.find_tariph.Margin = new System.Windows.Forms.Padding(2);
            this.find_tariph.Name = "find_tariph";
            this.find_tariph.Size = new System.Drawing.Size(130, 34);
            this.find_tariph.TabIndex = 23;
            this.find_tariph.Text = "Найти";
            this.find_tariph.UseVisualStyleBackColor = false;
            this.find_tariph.Click += new System.EventHandler(this.button4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(688, 218);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Название провайдера";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // tariph_find_provider
            // 
            this.tariph_find_provider.Location = new System.Drawing.Point(830, 214);
            this.tariph_find_provider.Margin = new System.Windows.Forms.Padding(2);
            this.tariph_find_provider.Name = "tariph_find_provider";
            this.tariph_find_provider.Size = new System.Drawing.Size(199, 20);
            this.tariph_find_provider.TabIndex = 21;
            this.tariph_find_provider.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // find_provider
            // 
            this.find_provider.BackColor = System.Drawing.Color.LightGreen;
            this.find_provider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.find_provider.Location = new System.Drawing.Point(151, 269);
            this.find_provider.Margin = new System.Windows.Forms.Padding(2);
            this.find_provider.Name = "find_provider";
            this.find_provider.Size = new System.Drawing.Size(130, 34);
            this.find_provider.TabIndex = 20;
            this.find_provider.Text = "Найти";
            this.find_provider.UseVisualStyleBackColor = false;
            this.find_provider.Click += new System.EventHandler(this.find_provider_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 225);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Название провайдера";
            // 
            // provider_find_title
            // 
            this.provider_find_title.Location = new System.Drawing.Point(192, 222);
            this.provider_find_title.Margin = new System.Windows.Forms.Padding(2);
            this.provider_find_title.Name = "provider_find_title";
            this.provider_find_title.Size = new System.Drawing.Size(199, 20);
            this.provider_find_title.TabIndex = 18;
            this.provider_find_title.TextChanged += new System.EventHandler(this.provider_find_title_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label11.Location = new System.Drawing.Point(773, 172);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Найти тариф";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label10.Location = new System.Drawing.Point(148, 172);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Найти провайдера";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage5.Controls.Add(this.del_tariph_button);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.tariph_del_title);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.tariph_del_provider);
            this.tabPage5.Controls.Add(this.del_provider);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.provider_del_title);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1116, 567);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Удалить";
            // 
            // del_tariph_button
            // 
            this.del_tariph_button.BackColor = System.Drawing.Color.Salmon;
            this.del_tariph_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del_tariph_button.Location = new System.Drawing.Point(792, 284);
            this.del_tariph_button.Margin = new System.Windows.Forms.Padding(2);
            this.del_tariph_button.Name = "del_tariph_button";
            this.del_tariph_button.Size = new System.Drawing.Size(130, 34);
            this.del_tariph_button.TabIndex = 25;
            this.del_tariph_button.Text = "Удалить";
            this.del_tariph_button.UseVisualStyleBackColor = false;
            this.del_tariph_button.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(699, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Название тарифа";
            // 
            // tariph_del_title
            // 
            this.tariph_del_title.Location = new System.Drawing.Point(840, 235);
            this.tariph_del_title.Margin = new System.Windows.Forms.Padding(2);
            this.tariph_del_title.Name = "tariph_del_title";
            this.tariph_del_title.Size = new System.Drawing.Size(199, 20);
            this.tariph_del_title.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(699, 205);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Название провайдера";
            // 
            // tariph_del_provider
            // 
            this.tariph_del_provider.Location = new System.Drawing.Point(840, 201);
            this.tariph_del_provider.Margin = new System.Windows.Forms.Padding(2);
            this.tariph_del_provider.Name = "tariph_del_provider";
            this.tariph_del_provider.Size = new System.Drawing.Size(199, 20);
            this.tariph_del_provider.TabIndex = 21;
            // 
            // del_provider
            // 
            this.del_provider.BackColor = System.Drawing.Color.Salmon;
            this.del_provider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del_provider.Location = new System.Drawing.Point(154, 247);
            this.del_provider.Margin = new System.Windows.Forms.Padding(2);
            this.del_provider.Name = "del_provider";
            this.del_provider.Size = new System.Drawing.Size(130, 34);
            this.del_provider.TabIndex = 20;
            this.del_provider.Text = "Удалить";
            this.del_provider.UseVisualStyleBackColor = false;
            this.del_provider.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Название провайдера";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // provider_del_title
            // 
            this.provider_del_title.Location = new System.Drawing.Point(202, 201);
            this.provider_del_title.Margin = new System.Windows.Forms.Padding(2);
            this.provider_del_title.Name = "provider_del_title";
            this.provider_del_title.Size = new System.Drawing.Size(199, 20);
            this.provider_del_title.TabIndex = 18;
            this.provider_del_title.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label15.Location = new System.Drawing.Point(789, 156);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 18);
            this.label15.TabIndex = 9;
            this.label15.Text = "Удалить тариф";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label14.Location = new System.Drawing.Point(152, 156);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 18);
            this.label14.TabIndex = 8;
            this.label14.Text = "Удалить провайдера";
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.buttonRepSaleOfUser);
            this.tabPage1.Controls.Add(this.buttonReportAllSalesForUsers);
            this.tabPage1.Controls.Add(this.dataGridViewUsers);
            this.tabPage1.Controls.Add(this.dataGridViewSales);
            this.tabPage1.Controls.Add(this.from_file_button);
            this.tabPage1.Controls.Add(this.to_file);
            this.tabPage1.Controls.Add(this.refresh_users);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1116, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Просмотр";
            // 
            // buttonRepSaleOfUser
            // 
            this.buttonRepSaleOfUser.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonRepSaleOfUser.Location = new System.Drawing.Point(4, 459);
            this.buttonRepSaleOfUser.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRepSaleOfUser.Name = "buttonRepSaleOfUser";
            this.buttonRepSaleOfUser.Size = new System.Drawing.Size(297, 37);
            this.buttonRepSaleOfUser.TabIndex = 50;
            this.buttonRepSaleOfUser.Text = "Отчет: какие покупатели получают скидку";
            this.buttonRepSaleOfUser.UseVisualStyleBackColor = false;
            this.buttonRepSaleOfUser.Click += new System.EventHandler(this.buttonRepSaleOfUser_Click);
            // 
            // buttonReportAllSalesForUsers
            // 
            this.buttonReportAllSalesForUsers.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonReportAllSalesForUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReportAllSalesForUsers.Location = new System.Drawing.Point(4, 418);
            this.buttonReportAllSalesForUsers.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReportAllSalesForUsers.Name = "buttonReportAllSalesForUsers";
            this.buttonReportAllSalesForUsers.Size = new System.Drawing.Size(297, 37);
            this.buttonReportAllSalesForUsers.TabIndex = 49;
            this.buttonReportAllSalesForUsers.Text = "Отчет: какие скидки может получать покупатель";
            this.buttonReportAllSalesForUsers.UseVisualStyleBackColor = false;
            this.buttonReportAllSalesForUsers.Click += new System.EventHandler(this.buttonReportAllSalesForUsers_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnUsersLogin,
            this.ColumnUsersHash,
            this.ColumnUsersTariph,
            this.ColumnUsersDate});
            this.dataGridViewUsers.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewUsers.Location = new System.Drawing.Point(438, 4);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.Size = new System.Drawing.Size(677, 410);
            this.dataGridViewUsers.TabIndex = 48;
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellContentClick);
            // 
            // ColumnUsersLogin
            // 
            this.ColumnUsersLogin.HeaderText = "Логин покупателя";
            this.ColumnUsersLogin.MinimumWidth = 6;
            this.ColumnUsersLogin.Name = "ColumnUsersLogin";
            this.ColumnUsersLogin.Width = 125;
            // 
            // ColumnUsersHash
            // 
            this.ColumnUsersHash.HeaderText = "Хеш-значени логина";
            this.ColumnUsersHash.MinimumWidth = 6;
            this.ColumnUsersHash.Name = "ColumnUsersHash";
            this.ColumnUsersHash.Width = 125;
            // 
            // ColumnUsersTariph
            // 
            this.ColumnUsersTariph.HeaderText = "Тариф";
            this.ColumnUsersTariph.MinimumWidth = 6;
            this.ColumnUsersTariph.Name = "ColumnUsersTariph";
            this.ColumnUsersTariph.Width = 125;
            // 
            // ColumnUsersDate
            // 
            this.ColumnUsersDate.HeaderText = "Дата подключения";
            this.ColumnUsersDate.MinimumWidth = 6;
            this.ColumnUsersDate.Name = "ColumnUsersDate";
            this.ColumnUsersDate.Width = 125;
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSaleSale,
            this.ColumnSaleTariph,
            this.ColumnSaleDate});
            this.dataGridViewSales.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewSales.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewSales.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.RowHeadersWidth = 51;
            this.dataGridViewSales.RowTemplate.Height = 24;
            this.dataGridViewSales.Size = new System.Drawing.Size(429, 410);
            this.dataGridViewSales.TabIndex = 47;
            // 
            // ColumnSaleSale
            // 
            this.ColumnSaleSale.HeaderText = "Скидка";
            this.ColumnSaleSale.MinimumWidth = 6;
            this.ColumnSaleSale.Name = "ColumnSaleSale";
            this.ColumnSaleSale.Width = 125;
            // 
            // ColumnSaleTariph
            // 
            this.ColumnSaleTariph.HeaderText = "Тариф";
            this.ColumnSaleTariph.MinimumWidth = 6;
            this.ColumnSaleTariph.Name = "ColumnSaleTariph";
            this.ColumnSaleTariph.Width = 125;
            // 
            // ColumnSaleDate
            // 
            this.ColumnSaleDate.HeaderText = "Срок пользования тарифом";
            this.ColumnSaleDate.MinimumWidth = 6;
            this.ColumnSaleDate.Name = "ColumnSaleDate";
            this.ColumnSaleDate.Width = 125;
            // 
            // from_file_button
            // 
            this.from_file_button.BackColor = System.Drawing.Color.PowderBlue;
            this.from_file_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.from_file_button.Location = new System.Drawing.Point(1002, 522);
            this.from_file_button.Name = "from_file_button";
            this.from_file_button.Size = new System.Drawing.Size(112, 45);
            this.from_file_button.TabIndex = 46;
            this.from_file_button.Text = "Загрузить";
            this.from_file_button.UseVisualStyleBackColor = false;
            this.from_file_button.Click += new System.EventHandler(this.from_file_button_Click_1);
            // 
            // to_file
            // 
            this.to_file.BackColor = System.Drawing.Color.PowderBlue;
            this.to_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.to_file.Location = new System.Drawing.Point(1002, 470);
            this.to_file.Name = "to_file";
            this.to_file.Size = new System.Drawing.Size(112, 45);
            this.to_file.TabIndex = 45;
            this.to_file.Text = "Сохранить";
            this.to_file.UseVisualStyleBackColor = false;
            this.to_file.Click += new System.EventHandler(this.to_file_Click_1);
            // 
            // refresh_users
            // 
            this.refresh_users.BackColor = System.Drawing.Color.PowderBlue;
            this.refresh_users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_users.Location = new System.Drawing.Point(1002, 419);
            this.refresh_users.Name = "refresh_users";
            this.refresh_users.Size = new System.Drawing.Size(112, 45);
            this.refresh_users.TabIndex = 1;
            this.refresh_users.Text = "Обновить";
            this.refresh_users.UseVisualStyleBackColor = false;
            this.refresh_users.Click += new System.EventHandler(this.refresh_users_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(2, 2);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1124, 593);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.sale_provider);
            this.tabPage3.Controls.Add(this.label40);
            this.tabPage3.Controls.Add(this.label39);
            this.tabPage3.Controls.Add(this.user_provider);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.sale_length);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.sale_tariph);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.sale_num);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.add_sale);
            this.tabPage3.Controls.Add(this.add_user);
            this.tabPage3.Controls.Add(this.user_tariph);
            this.tabPage3.Controls.Add(this.user_date);
            this.tabPage3.Controls.Add(this.user_login);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(1116, 567);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Добавить";
            // 
            // sale_provider
            // 
            this.sale_provider.Location = new System.Drawing.Point(797, 273);
            this.sale_provider.Margin = new System.Windows.Forms.Padding(2);
            this.sale_provider.Name = "sale_provider";
            this.sale_provider.Size = new System.Drawing.Size(199, 20);
            this.sale_provider.TabIndex = 45;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(659, 275);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(120, 13);
            this.label40.TabIndex = 44;
            this.label40.Text = "Название провайдера";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(42, 275);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(120, 13);
            this.label39.TabIndex = 43;
            this.label39.Text = "Название провайдера";
            this.label39.Click += new System.EventHandler(this.label39_Click);
            // 
            // user_provider
            // 
            this.user_provider.Location = new System.Drawing.Point(186, 273);
            this.user_provider.Margin = new System.Windows.Forms.Padding(2);
            this.user_provider.Name = "user_provider";
            this.user_provider.Size = new System.Drawing.Size(199, 20);
            this.user_provider.TabIndex = 42;
            this.user_provider.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(659, 242);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "Срок пользования";
            // 
            // sale_length
            // 
            this.sale_length.Location = new System.Drawing.Point(797, 242);
            this.sale_length.Margin = new System.Windows.Forms.Padding(2);
            this.sale_length.Name = "sale_length";
            this.sale_length.Size = new System.Drawing.Size(199, 20);
            this.sale_length.TabIndex = 40;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(659, 210);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Название тарифа";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // sale_tariph
            // 
            this.sale_tariph.Location = new System.Drawing.Point(797, 210);
            this.sale_tariph.Margin = new System.Windows.Forms.Padding(2);
            this.sale_tariph.Name = "sale_tariph";
            this.sale_tariph.Size = new System.Drawing.Size(199, 20);
            this.sale_tariph.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(659, 177);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "Процент скидки";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // sale_num
            // 
            this.sale_num.Location = new System.Drawing.Point(797, 177);
            this.sale_num.Margin = new System.Windows.Forms.Padding(2);
            this.sale_num.Name = "sale_num";
            this.sale_num.Size = new System.Drawing.Size(199, 20);
            this.sale_num.TabIndex = 36;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(42, 246);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(118, 13);
            this.label24.TabIndex = 35;
            this.label24.Text = "Используемый тариф";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(42, 213);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(103, 13);
            this.label23.TabIndex = 33;
            this.label23.Text = "Дата подключения";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // add_sale
            // 
            this.add_sale.BackColor = System.Drawing.Color.LightSkyBlue;
            this.add_sale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_sale.Location = new System.Drawing.Point(753, 313);
            this.add_sale.Margin = new System.Windows.Forms.Padding(2);
            this.add_sale.Name = "add_sale";
            this.add_sale.Size = new System.Drawing.Size(130, 34);
            this.add_sale.TabIndex = 31;
            this.add_sale.Text = "Добавить";
            this.add_sale.UseVisualStyleBackColor = false;
            this.add_sale.Click += new System.EventHandler(this.add_sale_Click);
            // 
            // add_user
            // 
            this.add_user.BackColor = System.Drawing.Color.LightSkyBlue;
            this.add_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_user.Location = new System.Drawing.Point(143, 313);
            this.add_user.Margin = new System.Windows.Forms.Padding(2);
            this.add_user.Name = "add_user";
            this.add_user.Size = new System.Drawing.Size(130, 34);
            this.add_user.TabIndex = 30;
            this.add_user.Text = "Добавить";
            this.add_user.UseVisualStyleBackColor = false;
            this.add_user.Click += new System.EventHandler(this.button8_Click);
            // 
            // user_tariph
            // 
            this.user_tariph.Location = new System.Drawing.Point(186, 240);
            this.user_tariph.Margin = new System.Windows.Forms.Padding(2);
            this.user_tariph.Name = "user_tariph";
            this.user_tariph.Size = new System.Drawing.Size(199, 20);
            this.user_tariph.TabIndex = 27;
            // 
            // user_date
            // 
            this.user_date.Location = new System.Drawing.Point(186, 207);
            this.user_date.Margin = new System.Windows.Forms.Padding(2);
            this.user_date.Name = "user_date";
            this.user_date.Size = new System.Drawing.Size(199, 20);
            this.user_date.TabIndex = 25;
            // 
            // user_login
            // 
            this.user_login.Location = new System.Drawing.Point(186, 173);
            this.user_login.Margin = new System.Windows.Forms.Padding(2);
            this.user_login.Name = "user_login";
            this.user_login.Size = new System.Drawing.Size(199, 20);
            this.user_login.TabIndex = 23;
            this.user_login.TextChanged += new System.EventHandler(this.user_login_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label20.Location = new System.Drawing.Point(760, 129);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(129, 18);
            this.label20.TabIndex = 22;
            this.label20.Text = "Добавить скидку";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label21.Location = new System.Drawing.Point(128, 129);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(161, 18);
            this.label21.TabIndex = 21;
            this.label21.Text = "Добавить покупателя";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(42, 177);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 13);
            this.label22.TabIndex = 20;
            this.label22.Text = "Логин покупателя";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage4.Controls.Add(this.label37);
            this.tabPage4.Controls.Add(this.sale_find_provider);
            this.tabPage4.Controls.Add(this.label36);
            this.tabPage4.Controls.Add(this.user_find_login);
            this.tabPage4.Controls.Add(this.label29);
            this.tabPage4.Controls.Add(this.sale_find_size);
            this.tabPage4.Controls.Add(this.button9);
            this.tabPage4.Controls.Add(this.label25);
            this.tabPage4.Controls.Add(this.sale_find_tariph);
            this.tabPage4.Controls.Add(this.button10);
            this.tabPage4.Controls.Add(this.label27);
            this.tabPage4.Controls.Add(this.label28);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(1116, 567);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Найти";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(693, 267);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(120, 13);
            this.label37.TabIndex = 47;
            this.label37.Text = "Название провайдера";
            this.label37.Click += new System.EventHandler(this.label37_Click);
            // 
            // sale_find_provider
            // 
            this.sale_find_provider.Location = new System.Drawing.Point(827, 263);
            this.sale_find_provider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sale_find_provider.Name = "sale_find_provider";
            this.sale_find_provider.Size = new System.Drawing.Size(199, 20);
            this.sale_find_provider.TabIndex = 46;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(62, 228);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(99, 13);
            this.label36.TabIndex = 45;
            this.label36.Text = "Логин покупателя";
            this.label36.Click += new System.EventHandler(this.label36_Click);
            // 
            // user_find_login
            // 
            this.user_find_login.Location = new System.Drawing.Point(194, 223);
            this.user_find_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_find_login.Name = "user_find_login";
            this.user_find_login.Size = new System.Drawing.Size(199, 20);
            this.user_find_login.TabIndex = 44;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(693, 232);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(89, 13);
            this.label29.TabIndex = 33;
            this.label29.Text = "Процент скидки";
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // sale_find_size
            // 
            this.sale_find_size.Location = new System.Drawing.Point(827, 228);
            this.sale_find_size.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sale_find_size.Name = "sale_find_size";
            this.sale_find_size.Size = new System.Drawing.Size(199, 20);
            this.sale_find_size.TabIndex = 32;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightGreen;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Location = new System.Drawing.Point(773, 314);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(130, 34);
            this.button9.TabIndex = 31;
            this.button9.Text = "Найти";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(693, 198);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(97, 13);
            this.label25.TabIndex = 30;
            this.label25.Text = "Название тарифа";
            // 
            // sale_find_tariph
            // 
            this.sale_find_tariph.Location = new System.Drawing.Point(827, 194);
            this.sale_find_tariph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sale_find_tariph.Name = "sale_find_tariph";
            this.sale_find_tariph.Size = new System.Drawing.Size(199, 20);
            this.sale_find_tariph.TabIndex = 29;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LightGreen;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Location = new System.Drawing.Point(158, 269);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(130, 34);
            this.button10.TabIndex = 28;
            this.button10.Text = "Найти";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label27.Location = new System.Drawing.Point(786, 154);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(102, 18);
            this.label27.TabIndex = 25;
            this.label27.Text = "Найти скидку";
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label28.Location = new System.Drawing.Point(155, 176);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(134, 18);
            this.label28.TabIndex = 24;
            this.label28.Text = "Найти покупателя";
            this.label28.Click += new System.EventHandler(this.label28_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage8.Controls.Add(this.label26);
            this.tabPage8.Controls.Add(this.sale_del_provider);
            this.tabPage8.Controls.Add(this.label31);
            this.tabPage8.Controls.Add(this.sale_del_size);
            this.tabPage8.Controls.Add(this.label32);
            this.tabPage8.Controls.Add(this.sale_del_tar);
            this.tabPage8.Controls.Add(this.label33);
            this.tabPage8.Controls.Add(this.user_del_login);
            this.tabPage8.Controls.Add(this.button11);
            this.tabPage8.Controls.Add(this.del_user);
            this.tabPage8.Controls.Add(this.label34);
            this.tabPage8.Controls.Add(this.label35);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1116, 567);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "Удалить";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(714, 269);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(120, 13);
            this.label26.TabIndex = 43;
            this.label26.Text = "Название провайдера";
            // 
            // sale_del_provider
            // 
            this.sale_del_provider.Location = new System.Drawing.Point(854, 265);
            this.sale_del_provider.Margin = new System.Windows.Forms.Padding(2);
            this.sale_del_provider.Name = "sale_del_provider";
            this.sale_del_provider.Size = new System.Drawing.Size(199, 20);
            this.sale_del_provider.TabIndex = 42;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(714, 234);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(89, 13);
            this.label31.TabIndex = 41;
            this.label31.Text = "Процент скидки";
            // 
            // sale_del_size
            // 
            this.sale_del_size.Location = new System.Drawing.Point(854, 230);
            this.sale_del_size.Margin = new System.Windows.Forms.Padding(2);
            this.sale_del_size.Name = "sale_del_size";
            this.sale_del_size.Size = new System.Drawing.Size(199, 20);
            this.sale_del_size.TabIndex = 40;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(714, 200);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(97, 13);
            this.label32.TabIndex = 39;
            this.label32.Text = "Название тарифа";
            // 
            // sale_del_tar
            // 
            this.sale_del_tar.Location = new System.Drawing.Point(854, 196);
            this.sale_del_tar.Margin = new System.Windows.Forms.Padding(2);
            this.sale_del_tar.Name = "sale_del_tar";
            this.sale_del_tar.Size = new System.Drawing.Size(199, 20);
            this.sale_del_tar.TabIndex = 38;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(60, 208);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(99, 13);
            this.label33.TabIndex = 37;
            this.label33.Text = "Логин покупателя";
            // 
            // user_del_login
            // 
            this.user_del_login.Location = new System.Drawing.Point(194, 204);
            this.user_del_login.Margin = new System.Windows.Forms.Padding(2);
            this.user_del_login.Name = "user_del_login";
            this.user_del_login.Size = new System.Drawing.Size(199, 20);
            this.user_del_login.TabIndex = 36;
            this.user_del_login.TextChanged += new System.EventHandler(this.user_del_login_TextChanged);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Salmon;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Location = new System.Drawing.Point(810, 306);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(130, 34);
            this.button11.TabIndex = 35;
            this.button11.Text = "Удалить";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // del_user
            // 
            this.del_user.BackColor = System.Drawing.Color.Salmon;
            this.del_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del_user.Location = new System.Drawing.Point(150, 246);
            this.del_user.Margin = new System.Windows.Forms.Padding(2);
            this.del_user.Name = "del_user";
            this.del_user.Size = new System.Drawing.Size(130, 34);
            this.del_user.TabIndex = 30;
            this.del_user.Text = "Удалить";
            this.del_user.UseVisualStyleBackColor = false;
            this.del_user.Click += new System.EventHandler(this.del_user_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label34.Location = new System.Drawing.Point(807, 157);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(119, 18);
            this.label34.TabIndex = 27;
            this.label34.Text = "Удалить скидку";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label35.Location = new System.Drawing.Point(157, 157);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(151, 18);
            this.label35.TabIndex = 26;
            this.label35.Text = "Удалить покупателя";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage9);
            this.tabControlMain.Controls.Add(this.tabPage10);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1136, 623);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.tabControl1);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage9.Size = new System.Drawing.Size(1128, 597);
            this.tabPage9.TabIndex = 0;
            this.tabPage9.Text = "Провайдеры и тарифы";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.tabControl2);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage10.Size = new System.Drawing.Size(1128, 597);
            this.tabPage10.TabIndex = 1;
            this.tabPage10.Text = "Покупатели и скидки";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Location = new System.Drawing.Point(6, 502);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(295, 66);
            this.button2.TabIndex = 33;
            this.button2.Text = "Сравнение ХФ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 623);
            this.Controls.Add(this.tabControlMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Справочники";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTariphs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProviders)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Provider_title;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tariph_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Add_provider_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tariph_cost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tariph_speed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button find_tariph;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tariph_find_provider;
        private System.Windows.Forms.Button find_provider;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox provider_find_title;
        private System.Windows.Forms.Button del_tariph_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tariph_del_title;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tariph_del_provider;
        private System.Windows.Forms.Button del_provider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox provider_del_title;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button add_sale;
        private System.Windows.Forms.Button add_user;
        private System.Windows.Forms.TextBox user_tariph;
        private System.Windows.Forms.TextBox user_date;
        private System.Windows.Forms.TextBox user_login;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox sale_tariph;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox sale_num;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox sale_length;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox sale_find_size;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox sale_find_tariph;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tariph_find_title;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button del_user;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox sale_del_size;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox sale_del_tar;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox user_del_login;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox user_find_login;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox tariph_provider;
        private System.Windows.Forms.TextBox user_provider;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox sale_provider;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox sale_del_provider;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox sale_find_provider;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.CheckBox checkBoxAddTariphTV;
        private System.Windows.Forms.CheckBox checkBoxAddTariphInternet;
        private System.Windows.Forms.Button refresh_provider;
        private System.Windows.Forms.Button refresh_users;
        private System.Windows.Forms.Button save_provider;
        private System.Windows.Forms.Button load_provider;
        private System.Windows.Forms.Button to_file;
        private System.Windows.Forms.Button from_file_button;
        private System.Windows.Forms.DataGridView dataGridViewTariphs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTariphPoviderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTariphHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTariphName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTariphType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTariphSpeed;
        private System.Windows.Forms.DataGridView dataGridViewProviders;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProviderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProviderTariph;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProviderCost;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSaleSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSaleTariph;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSaleDate;
        private System.Windows.Forms.Button buttonReportAllTariphType;
        private System.Windows.Forms.Button buttonReportAllSalesForUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsersLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsersHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsersTariph;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsersDate;
        private System.Windows.Forms.Button buttonRepAllUsers;
        private System.Windows.Forms.Button buttonRepSaleOfUser;
        private System.Windows.Forms.Button button2;
    }
}
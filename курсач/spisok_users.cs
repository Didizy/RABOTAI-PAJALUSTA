using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace курсач
{
   public class spisok_users
    {

        public class nest
        {
            public int hash;
            public string login;
            public string date;
            public spisok_tariph.nest tariph;
            public spisok_users.nest chain;//для метода цепочек

            public nest next, prev, chain_next, chain_prev;
            /*public nest(int i)
            {
                hash = i;
                login = "";
                date = "";

            }*/
        }

        int num_of_elements, max_elements;
        public nest first;

        public spisok_users()
        {
            first = null;
            max_elements = 100;
            num_of_elements = 0;
            /*first = new nest(0);
            nest curr = first;
            for (int i = 1; i < max_elements; i++)
            {
                curr.next = new nest(i);
                curr.next.prev = curr;
                curr = curr.next;
            }
            curr.next = first;
            first.prev = curr;
            curr.chain_next = null;
            curr.chain_prev = curr;*/

        }
        public bool free(nest temp)//проверка на пустую ячейку
        {
             return ((temp.login == "") && (temp.tariph == null));
        }

        public int get_hash (string login)
        {
            int help = login.GetHashCode();
            int h1 = help % max_elements;// на (int)login ругается
            return h1;
        }

        public void add(string login, string date, spisok_tariph.nest tariph)
        {
            int j = get_hash(login);
            nest curr = first;
            bool added = false;

            if(curr == null)
            {
                curr = new nest();
                first = curr;
                curr.hash = j;
                curr.login = login;
                curr.date = date;
                curr.next = curr;
                curr.prev = curr;
                curr.chain = curr;
                curr.tariph = tariph;
                num_of_elements++;
            }
            else
            {
                while (!added)
                {
                    int curr_hash = get_hash(login);
                    while (curr.hash != curr_hash)
                        curr = curr.next;

                    if (free(curr))
                    {
                        curr.login = login;
                        curr.date = date;
                        added = true;
                        num_of_elements++;
                        curr.tariph = tariph;
                        curr.prev = curr;
                        curr.next = first;
                    }
                    else
                    {
                        while (!free(curr))
                            curr = curr.chain_next;

                        curr.login = login;
                        curr.date = date;
                        added = true;
                        num_of_elements++;
                        curr.tariph = tariph;

                        curr.chain_next = null;
                        curr.chain_prev = curr;
                    }
                }
            }
           

        }

        public nest find(string login /*spisok_tariph.nest tariph*/)//исправить, циклится
        {
            //int hash = getkey(login);
            //int j = 0;
            nest curr = first;
            int hash = get_hash(login);

            if (curr == null)
            {
                return null;
            }
            else if (hash == curr.hash)
            {
                while(curr!=null)
                {
                    if (curr.login == login)
                        return curr;
                }
                return null;
            }
            else
            {
                //nest check = first;
                curr = curr.next;

                while (curr != first)
                {
                    if (curr.login == login)
                        return curr;
                }
                return null;
            }


            /*while (true)
            {
                int curr_hash = get_hash(login);
                while (curr.hash != curr_hash)
                {
                    curr = curr.next;
                }
                if ((curr.login == login))*//* && curr.tariph == tariph))*//*
                {
                    return curr;
                }
                else
                    curr = curr.chain_next;
                if (j == num_of_elements - 1)
                    return null;
            }*/
        }

        public void delete(string login/*, spisok_tariph.nest tariph*/)
        {
            nest curr = find(login);
            if (curr != null)
            {
                if (curr == curr.chain_prev)
                {
                    curr.login = "";
                    curr.date = "";
                    curr.tariph = null;
                }
                else
                {
                    curr.chain_next = curr.chain_prev;
                    curr.chain_prev = curr.chain_next;
                    //free(curr);//вроде как free удаляет
                }

            }
            else
            {
                //error
            }
        }
        public bool Can_get_sale(spisok_users.nest u, tree_sale.root s)
        {
            int time = Convert.ToInt32(s.date);
            int user_day = (Convert.ToInt32(u.date[0])-48) * 10 + (Convert.ToInt32(u.date[1])-48);
            int user_month = (Convert.ToInt32(u.date[3])-48) * 10 + (Convert.ToInt32(u.date[4])-48);
            int user_year = (Convert.ToInt32(u.date[8])-48) * 10 + (Convert.ToInt32(u.date[9])-48);
            int compare_day = 1;
            int compare_month = 1;
            int compare_year = 20;
            int years = 0;
            while (time >= 12)
            {
                time -= 12;
                years++;

            }
            if (compare_year - years < user_year)
            {
                return false;
            }
            if (user_month + time > 12)
            {
                user_month -= 12 + time;
                user_year++;
            }
            if (user_year + years > compare_year)
            {
                return false;
            }
            if ((user_day > compare_day)&&(user_month>=compare_month))
            {
                return false;

            }
            return true;
        }
      
    }
}

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace курсач
{
   public class spisok_users
    {
        //тут должна появится хт

        public class nest
        {
            //public int hash;
            public string login;
            public string date;
            public int hash;
            public spisok_tariph.nest tariph;
            public nest next, prev;//, first;//для метода цепочек

            public nest(string login, string date, spisok_tariph.nest tariph)
            {
                this.login = login;
                this.date = date;
                this.tariph = tariph;

                //chain_next = first;
            }

        }

        public int max_elements = 2;
        public nest[] table;
        public int comparisons = 0;

        public spisok_users()
        {
            table = new nest[max_elements];
            for (int i = 0; i < max_elements; i++)
                table[i] = null;
        }

/*        public class nest
        {
            public int hash;
            public string login;
            public string date;
            public spisok_tariph.nest tariph;
            public spisok_users.nest chain;//для метода цепочек

            public nest next, prev, chain_next, chain_prev;
            *//*public nest(int i)
            {
                hash = i;
                login = "";
                date = "";

            }*//*
        }*/


        //public nest first;

 /*        public spisok_users()
        {
           first = null;
            max_elements = 100;*/
            //num_of_elements = 0;
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
            curr.chain_prev = curr;

        }*/
        public bool free(nest temp)//проверка на пустую ячейку
        {
            //return ((temp.login == "") && (temp.tariph == null));
            if (((temp.login == "") && (temp.tariph == null)) || (temp == null))
                return false;
            else
                return true;
            //return ((temp.login == "") && (temp.tariph == null)) || (temp == null);
        }

        public int get_hash (string login)
        {
            double hash = 0;

            foreach (char c in login)
                hash = hash + c;

            hash *= 0.618033;
            hash -= (int)hash;
            int h1 = (int)(hash * max_elements) % max_elements;
            return h1;
        }
        public int compare_int(string a, string b)//сравнение строк
        {
            int t = Convert.ToInt32(a);
            int k = Convert.ToInt32(b);
            if (t == k)
                return 0;
            else if (t < k)
                return -1;
            return 1;
        }
        public int compare(string a, string b)//сравнение строк
        {


            for (int i = 0; ((i < a.Length) && (i < b.Length)); i++)
            {
                if (a[i] == b[i])
                    continue;
                else if (a[i] < b[i])
                    return -1;
                else
                    return 1;

            }
            return 0;
        }
/*        public bool add(string login, string date, spisok_tariph.nest tariph)
        {
            int curr_hash = get_hash(login);
            nest curr = first;
            

            if (curr == null)
            {
                first = new nest();
                first.hash = curr_hash;
                first.login = login;
                first.date = date;
                
                first.tariph = tariph;
                first.next = first;
                first.prev = first;
                first.chain_next = null;

                return true;
            }
            else
            {
                while (true)
                {
                    while ((curr.hash != curr_hash) && (curr.next != first) && (curr_hash > curr.hash))
                    {
                        curr = curr.next;
                    }

                    if ((curr.hash > curr_hash)&&(curr == first))
                    {
                        nest temp = new nest();
                        temp.login = login;
                        temp.date = date;
                        temp.tariph = tariph;
                        temp.hash = curr_hash;
                        first.prev.next = temp;
                        temp.prev = first.prev;
                        first.prev = temp;
                        temp.next = first;
                        first = temp;
                        temp.chain_next = null;
                        return true;
                    }
                    if ((curr.next == first)&&(curr_hash>curr.hash))
                    {
                            nest temp = new nest();
                            temp.login = login;
                            temp.date = date;
                            temp.tariph = tariph;
                            temp.hash = curr_hash;

                            curr.next = temp;
                            temp.prev = curr;
                            temp.next = first;
                            first.prev = temp;

                            temp.chain_next = null;
                            return true;
                    }
                    else if(curr_hash<curr.hash)
                    {
                        nest temp = new nest();
                        temp.login = login;
                        temp.date = date;
                        temp.hash = curr_hash;
                        temp.tariph = tariph;

                        curr.prev.next = temp;
                        temp.prev = curr.prev;
                        curr.prev = temp;
                        temp.next = curr;
                        temp.chain_next = null;
                        return true;
                    }
                    else
                    {
                        while (curr.chain_next != null)
                            curr = curr.chain_next;
                        nest temp = new nest();
                        temp.login = login;
                        temp.date = date;
                        temp.hash = curr_hash;
                        temp.tariph = tariph;

                        temp.chain_next = null;
                        temp.chain_prev = curr;
                        curr.chain_next = temp;
                        return true;
                    }
                    
                }
            }
           

        }*/

        public bool add(string login, string date, spisok_tariph.nest tariph)
        {
            nest temp = new nest(login, date, tariph);
            int hash = get_hash(login);

            if (table[hash] == null)
            {
                table[hash] = temp;
                table[hash].next = table[hash];
                table[hash].prev = table[hash];
                return true;
            }
            else
            {

                temp.next = table[hash].next;
                table[hash].next.prev = temp;
                table[hash].next = temp;
                temp.prev = table[hash];
                /*nest newtemp = table[hash].next;
                table[hash].next = newtemp;
                newtemp.prev = table[hash];
                newtemp.next = table[hash].next.next;
                table[hash].next.next.prev = newtemp*/
                return true;
            }
        }

        public nest find(string login)/*spisok_tariph.nest tariph*///исправить, циклится
        {
            //nest curr = first;
            int hash = get_hash(login);
            nest start = table[hash];

            if (start == null)
            {
                return null;
            }
            else
            {
                if (start.login == login)
                    return start;
                else
                {
                    nest temp = start.next;
                    while (temp != start)
                    {
                        if (temp.login == login)
                            return temp;
                        else
                            temp = temp.next;
                    }
                }

                return null;
            }

            /*if (curr == null)
            {
                return null;
            }
            else if (hash == curr.hash)
            {
                while(curr!=null)
                {
                    comparisons++;
                    if (curr.login == login)
                        return curr;

                    curr = curr.chain_next;
                }
                return null;
            }
            else
            {
                //nest check = first;
                curr = curr.next;
                while (curr != first)
                {
                    if (curr.hash==hash)
                    {
                        while(curr!=null)
                        {
                            comparisons++;
                            if (curr.login == login)
                                return curr;
                            curr = curr.chain_next;
                        }
                        return null;

                    }
                    curr = curr.next;
                }    

                return null;
            }*/
        }

        public bool delete(string login)//*, spisok_tariph.nest tariph*//*)
        {
            nest curr = find(login);
            if (curr != null)
            {
                if (curr != curr.prev && curr !=curr.next)
                {
                    curr.prev.next = curr.next;
                    curr.next.prev = curr.prev;

                    curr.next = null;
                    curr.prev = null;
                }
                else
                {
                    curr.next = null;
                    curr.prev = null;
                    curr = null;
                }
                return true;

            }
            else
            {
                return false;
            }
        }
        public bool Can_get_sale(spisok_users.nest u, tree_sale.root s)
        {
            int time = Convert.ToInt32(s.date);
            int user_day = (Convert.ToInt32(u.date[0])-48) * 10 + (Convert.ToInt32(u.date[1])-48);
            int user_month = (Convert.ToInt32(u.date[3])-48) * 10 + (Convert.ToInt32(u.date[4])-48);
            int user_year = (Convert.ToInt32(u.date[8])-48) * 10 + (Convert.ToInt32(u.date[9])-48);
            int compare_day = 10;
            int compare_month = 7;
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
            else if (user_month + time > 12)
            {
                user_month -= 12 + time;
                user_year++;
            }
            else if (user_year + years > compare_year)
            {
                return false;
            }
            else if ((user_day > compare_day)&&(user_month>=compare_month)&&(user_year+years==compare_year))
            {
                return false;

            }
            return true;
        }

        public tree_sale.root check_for_sale(spisok_tariph.nest tar, tree_sale.root s, spisok_users.nest u)
        {
            if (s == null)
                return null;
            tree_sale.root s1 = check_for_sale(tar, s.left, u);
            tree_sale.root s2 = check_for_sale(tar, s.right, u);
            if ((u.tariph == s.tariph) && (Can_get_sale(u, s)))
            {
                if (s2 != null)
                {
                    if (s2.size.Length > s.size.Length)
                        return s2;
                    else if (s2.size[0] > s.size[0])
                        return s2;
                    else if (s2.size[1] > s.size[1])
                        return s2;
                }
                else
                    return s;
            }
            else
                if ((s1 != null) || (s2 != null))
                {
                    if (s2 != null)
                        return s2;
                    else
                        return s1;
                }
                  return null;
            
            
        }
    }
}

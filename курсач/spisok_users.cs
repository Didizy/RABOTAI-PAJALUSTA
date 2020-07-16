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
        public int comparisons = 0;
        public class nest
        {
            public int hash;
            public string login;
            public string date;
            public spisok_tariph.nest tariph;
            public spisok_users.nest chain;//для метода цепочек

            public nest next, prev, chain_next, chain_prev;
        }

        public int max_elements; //num_of_elements, 
        public nest first;

        public spisok_users()
        {
            first = null;
            max_elements = 10;
            //num_of_elements = 0;
        }
/*        public bool free(nest temp)//проверка на пустую ячейку
        {
            //return ((temp.login == "") && (temp.tariph == null));
            if (((temp.login == "") && (temp.tariph == null)) || (temp == null))
                return false;
            else
                return true;
            //return ((temp.login == "") && (temp.tariph == null)) || (temp == null);
        }
*/
        public int get_hash (string login)
        {
            //int help = login.GetHashCode();
            double hash = 0;

            foreach (char c in login)
                hash = hash + c;

            hash *= 0.618033;
            hash -= (int)hash;
            int h1 = (int)(hash * max_elements) % max_elements;
            return h1;
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
        public bool add(string login, string date, spisok_tariph.nest tariph)
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

                //num_of_elements++;
                return true;
            }
            else
            {
                while (true)
                {
                    curr_hash = get_hash(login);

                    while ((curr.hash != curr_hash) && (curr.next != first) && (curr_hash > curr.hash))
                    {

                        curr = curr.next;
                    }

                    if (curr.next == first)
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
           

        }
        public nest find(string login)/*spisok_tariph.nest tariph*///исправить, циклится
        {
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
            }
        }

        public bool delete(string login)/*, spisok_tariph.nest tariph*/
        {
            nest curr = find(login);
            if (curr != null)
            {
                /*if (curr==first)
                {
                    if (curr.chain_next==null)
                    {

                        curr.next = first;
                    }
                }
                else if ((curr.chain_next != null) && (curr.chain_prev == null))
                {
                    nest temp = new nest();

                    curr.chain_next = null;
                    temp.chain_prev = null;
                    curr.prev.next = temp;
                    curr.next.prev = temp;
                    temp.prev = curr.prev;
                    temp.next = curr.next;
                }
                if else()
                {
                    curr.prev.next = curr.next;
                    curr.next.prev = curr.prev;
                }*/
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

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
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
            public nest(int i)
            {
                hash = i;
                login = "";
                date = "";
            }
        }

        int num_of_elements, max_elements;
        public nest first;

        public spisok_users()
        {
            num_of_elements = 0;
            max_elements = 100;
            first = new nest(0);
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

        }
        public bool free(nest temp)//проверка на пустую ячейку
        {
                return ((temp.login == "") && (temp.tariph == null));
        }
        /*public int gethash_1(int k)//k -ключ, достаём из getkey
        {
            int temp = ((k / max_elements) + 1) * (max_elements / 10 + 1);
            return temp;

        }
        public int gethash_2(int k)//k -ключ, достаём из getkey
        {

            int temp = (k % (max_elements - 1) + 1);
            return temp;

        }
        public int getkey(string login)//рандомная хеш функция
        {
            int temp = 0;
            for (int i = 0; i < login.Length; i++)
                temp += (int)login[i] * i;
            return temp;

        }*/

        public int get_hash (string login)
        {
            int h1 = Convert.ToInt32(login) % max_elements;// на (int)login ругается
            return h1;
        }

        public void add(int k, string login, string date, spisok_tariph.nest tariph)
        {
            int j = 0;
            nest curr = first;
            bool added = false;
            while (!added)
            {
                int curr_hash = get_hash(login);
                while (curr.hash != curr_hash)
                {
                    curr = curr.next;
                }

                if (free(curr))
                {
                    curr.login = login;
                    curr.date = date;
                    added = true;
                    num_of_elements++;
                    curr.tariph = tariph; 
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

        public nest find(string login /*spisok_tariph.nest tariph*/)
        {
            //int hash = getkey(login);
            int j = 0;
            nest curr = first;
            while (true)
            {
                int curr_hash = get_hash(login);
                while (curr.hash != curr_hash)
                {
                    curr = curr.next;
                }
                if ((curr.login == login))/* && curr.tariph == tariph))*/
                {
                    return curr;
                }
                else
                    curr = curr.chain_next;
                if (j == num_of_elements - 1)//такого элемента ещё нет, хз, что пока выводим, но это есть
                    return null;
            }
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
    }
}

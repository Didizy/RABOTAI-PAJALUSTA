using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсач
{
    public class spisok_tariph
    {

        public class nest
        {
            public int hash;
            public string name;
            public int type;//1 - интернет, 2 - интернет и тв, 3 - только тв
            public int speed;
            public tree_providers.root provider;
            public nest next, prev;
            public nest(int i)
            {
                hash = i;
                name = "";
                type = 0;
                speed = 0;
            }

        }
        int num_of_elements, max_elements;
        nest first;

        public spisok_tariph()
        {
            num_of_elements = 0;
            max_elements = 2;
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

        }
        public bool free(nest temp)//проверка на пустую ячейку
        {
            if ((temp.name == "")&&(temp.provider==null))
                return true;
            else
                return false;


        }
        public int gethash_1(int k)//k -ключ, достаём из getkey
        {
            int temp =  ((k / max_elements) + 1) * (max_elements / 10 + 1);
            return temp;

        }
        public int gethash_2(int k)//k -ключ, достаём из getkey
        {
            
            int temp = (k % (max_elements - 1) + 1);
            return temp;

        }
        public int getkey(string name)//рандомная хеш функция
        {
            int temp = 0;
            for (int i = 0; i < name.Length; i++)
                temp += (int)name[i] * i;
            return temp;

        }
        public void add(int k, string name, int type, int speed, tree_providers.root provider)// добавление нового элемента
        {
            if (num_of_elements == max_elements)
            {
                resize();
                k = getkey(name);
            }
            int j = 0;
            nest curr = first;
            bool added = false;
            while (!added)
            {
                int curr_hash = (gethash_1(k) + j * gethash_2(k)) % max_elements;
                while (curr.hash != curr_hash)
                {
                    curr = curr.next;
                }
                if (free(curr))
                {
                    curr.name = name;
                    curr.type = type;
                    curr.speed = speed;
                    added = true;
                    num_of_elements++;
                    curr.provider = provider;
                }
                else
                    j++;

            }
        }
        public void resize()//увеличиваем размер таблицы
        {
            max_elements *= 2;
            nest temp_first = first;
            first = new nest(0);
            nest curr = first;
            for (int i = 1; i < max_elements; i++)//создание новой таблицы
            {
                curr.next = new nest(i);
                curr.next.prev = curr;
                curr = curr.next;
            }
            curr.next = first;
            first.prev = curr;
            for (int i = 0; i < num_of_elements; i++)//перезаписывание в новую таблицу
            {
                add(getkey(temp_first.name), temp_first.name, temp_first.type, temp_first.speed, temp_first.provider);
                num_of_elements--;
                temp_first = temp_first.next;

            }
        }

        public nest find(string name,tree_providers.root provider)
        {
            int hash = getkey(name);
            int j = 0;
            nest curr = first;
            while (true)
            {
                int curr_hash = (gethash_1(hash) + j * gethash_2(hash)) % max_elements;
                while (curr.hash != curr_hash)
                {
                    curr = curr.next;
                }
                if ((curr.name == name) &&curr.provider == provider)
                {
                    return curr;

                }
                else
                    j++;
                if (j == num_of_elements)//такого элемента ещё нет, хз, что пока выводим, но это есть
                    return null;

            }

        }
        public void delete(string name, tree_providers.root provider) {
                nest curr = find(name, provider);
            if (curr != null) { 
                curr.name = "";
                curr.speed = 0;
                curr.type = 0;
                curr.provider = null;
            }
            else
            {
                //error
            }
        }
    }
   
}

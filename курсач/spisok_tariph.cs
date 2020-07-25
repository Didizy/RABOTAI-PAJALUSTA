using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсач
{
    public class spisok_tariph
    {
        public int comparisons = 0;

        public class nest
        {
            public bool deleted;
            //public int hash;
            public string name;
            public int hash;
            public int type;//1 - интернет, 2 - интернет и тв, 3 - только тв
            public int speed;
            public tree_providers.root provider;
            public nest()
            {
                name = "";
                type = 0;
                speed = 0;
                provider = null;
                deleted = false;
            }
            //public nest next, prev;
           /* public nest(int i)
            {
                hash = i;
                name = "";
                type = 0;
                speed = 0;
                deleted = false;
            }*/

        }
        public int num_of_elements, max_elements;
        public nest[] mas;

        public spisok_tariph()
        {
            num_of_elements = 0;
            max_elements = 8;
            mas = new nest[max_elements];
            for (int i = 0; i < max_elements; i++)
                mas[i] = new nest();
            
           /* first = new nest(0);
            nest curr = first;
            for (int i = 1; i < max_elements; i++)
            {
                curr.next = new nest(i);
                curr.next.prev = curr;
                curr = curr.next;
            }
            curr.next = first;
            first.prev = curr;*/

        }
        public bool free(nest temp)//проверка на пустую ячейку
        {
            if (((temp.name == "") && (temp.provider == null)) || (temp.deleted))
                return true;
            else
                return false;


        }
        public int gethash_1(int k)//k -ключ, достаём из getkey
        {
            int temp = ((k / max_elements) + 1) * (max_elements / 10 + 1)%max_elements;
            return temp;

        }
        public int gethash_2(int k)//k -ключ, достаём из getkey
        {

            int temp = (k % (max_elements - 1) + 1);
            if (temp % 2 == 0)
                temp -= 1;

            return temp;

        }
        public int getkey(string name, string provider_title)
        {
            int temp = 0;
            int i = 0;
            for (i = 0; i < name.Length; i++)
            {
                temp += (int)name[i] * i;
            }
            /*for (int j = 0; j < provider_title.Length; j++)
            {
                temp += (int)provider_title[j] * i;
                i++;
            }*/
            return temp;

        }
        public bool add(int k, string name, int type, int speed, tree_providers.root provider)// добавление нового элемента
        {
            if (num_of_elements == max_elements)
            {
                resize();
                k = getkey(name, provider.title);
            }
            int j = 0;
            //bool added = false;
            int hash_1 = gethash_1(k);
            int hash_2 = gethash_2(k);
            while (true)
            {
                
                int curr_hash = (hash_1 + j * hash_2) % max_elements;
                /*while (curr.hash != curr_hash)
                {
                    curr = curr.next;
                }*/
                if (free(mas[curr_hash]))
                {
                    if(mas[curr_hash].deleted == false)
                        num_of_elements++;
                    mas[curr_hash].name = name;
                    mas[curr_hash].type = type;
                    mas[curr_hash].speed = speed;
                    mas[curr_hash].provider = provider;
                    mas[curr_hash].deleted = false;
                    mas[curr_hash].hash = curr_hash;
                    
                    return true;
                }
                else if ((mas[curr_hash].name == name) && (mas[curr_hash].provider == provider))
                    return false;
                else
                    j++;
                /*if (free(curr))
                {
                    curr.name = name;
                    curr.type = type;
                    curr.speed = speed;
                    added = true;
                    if(curr.deleted == false)
                    num_of_elements++;
                    curr.provider = provider;
                    curr.deleted = false;
                    return true;
                }
                else if ((curr.name == name)  && (curr.provider == provider))
                    return false;
                else
                    j++;*/

            }
        }
        public void resize()//увеличиваем размер таблицы
        {
            max_elements *= 2;
            nest[] temp = mas;
            mas = new nest[max_elements];
            for(int i = 0; i < max_elements; i++)
            {
                mas[i] = new nest();
            }
            for(int i = 0; i < max_elements/2; i++)
            {
                if (!free(temp[i]))
                {
                    add(getkey(temp[i].name, temp[i].provider.title), temp[i].name, temp[i].type, temp[i].speed, temp[i].provider);
                }
            }
            //nest temp_first = first;
            //first = new nest(0);
            //nest curr = first;
            /*for (int i = 1; i < max_elements; i++)//создание новой таблицы
            {
                curr.next = new nest(i);
                curr.next.prev = curr;
                curr = curr.next;
            }
            curr.next = first;
            first.prev = curr;
            for (int i = 0; i < num_of_elements; i++)//перезаписывание в новую таблицу
            {
                add(getkey(temp_first.name, temp_first.provider.title), temp_first.name, temp_first.type, temp_first.speed, temp_first.provider);
                num_of_elements--;
                temp_first = temp_first.next;

            }*/
        }

        public nest find(string name, tree_providers.root provider)
        {
            int hash = getkey(name, provider.title);
            int j = 0;
            //int tar_checked = 0;
            //nest curr = first;
            while (true)
            {
                int curr_hash = (gethash_1(hash) + j * gethash_2(hash)) % max_elements;
               // if (tar_checked == num_of_elements)
                 //   return null;
               /* while (curr.hash != curr_hash)
                {
                    curr = curr.next;
                }*/
                //tar_checked++;
                if (free(mas[curr_hash]))
                    return null;
                if ((mas[curr_hash].name == name) && (mas[curr_hash].provider == provider)&&(!mas[curr_hash].deleted))
                {
                    comparisons++;
                    return mas[curr_hash];
                }
                else
                    comparisons++;
                j++;



            }

        }
        public void delete(string name, tree_providers.root provider)
        {
            nest curr = find(name, provider);
            if (curr != null)
            {
                //num_of_elements;
                curr.deleted = true;
            }
            else
            {
                //error
            }
        }
    }

}

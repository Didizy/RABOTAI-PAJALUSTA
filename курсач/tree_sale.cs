using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсач
{
    class tree_sale
    {
        public class root
        {
            public string title;
            public string size;// размер скидки
            public string date;// срок пользования тарифом
            public spisok_tariph.nest tariph;
            public root left, right;
            public struct info
            {
                public string size;// name;
                public string date;//int cost;
            }
            public info[] arr = new info[5];

            public root(string size)
            {
                this.title = size;
                date = "";
                left = right = null;
            }
        }
        public root main = null;

        public tree_sale() { }

        public int compare(string a, string b)//сравнение строк
        {
            if (a == b)
                return 0;
            for (int i = 0; ((i < a.Length) && (i < b.Length)); i++)
            {
                if (a[i] == b[i])
                    continue;
                else if (a[i] < b[i])
                    return -1;
                else
                    return 1;

            }
            return 5;
        }
        public void add_sale(string size)
        {
            bool placed = false;
            if (main == null)
                main = new root(size);
            else
            {
                root curr = main;
                while (!placed)
                {
                    int i = compare(size, curr.title);
                    if (i == -1)
                        if (curr.left == null)
                        {
                            root temp = new root(size);
                            curr.left = temp;
                            placed = true;
                        }
                        else
                            curr = curr.left;
                    else if (i == 1)
                        if (curr.right == null)
                        {
                            root temp = new root(size);
                            curr.right = temp;
                            placed = true;
                        }
                        else
                            curr = curr.right;
                    else if (i == 0)
                    {
                        //error, уже существует
                    }


                }
            }
        }
        public root find(string size)//поиск
        {
            if (main == null)
            {
                //error
                return null;
            }
            else
            {
                root curr = main;
                while (true)
                {
                    int i = compare(size, curr.title);
                    if (i == 0)
                        return curr;
                    else if (i == -1)
                        if (curr.left != null)
                            curr = curr.left;
                        else
                            return null;
                    else if (i == 1)
                        if (curr.right != null)
                            curr = curr.right;
                        else
                            return null;


                }
            }

        }
        public root find_max(root from_this)//поиск мин справа, если не находит ищет макс слева
        {
            root curr;
            root check;
            if (from_this.right != null)
            {
                curr = from_this.right;
                while (curr.left != null)
                    curr = curr.left;
                return curr;
            }
            else 
            { 
                if (from_this.left != null)
                {
                    curr = from_this.left;
                    check = from_this;
                }
                else
                    return null;
                while (true)
                {
                    if (curr.right == null)
                    {
                        check.right = curr.left;
                        return curr;
                    }
                    else
                    {
                        check = curr;
                        curr = curr.right;
                    }
                }
            }
        }
        public void delete(string size)//удаление 
        {
            bool left = true;
            root parent = main;
            bool deleted = false;
            root curr = main;
            int i = compare(size, main.title);
            if (i == 0)//удаляем корень дерева, проверка на что заменить
            {
                root swap = find_max(main);
                if (swap == null)
                    main = main.right;
                else
                {
                    swap.left = main.left;
                    swap.right = main.right;
                    main = swap;
                }
                return;
            }
            else if (i == -1)
            {
                left = true;
                curr = main.left;
            }

            else if (i == 1)
            {
                left = false;
                curr = main.right;
            }


            while (!deleted)
            {

                i = compare(size, curr.title);
                if (i == -1)
                {
                    parent = curr;
                    left = true;
                    curr = curr.left;
                }
                else if (i == 1)
                {
                    parent = curr;
                    left = false;
                    curr = curr.right;
                }

                else if (i == 0)
                {

                    deleted = true;
                    root swap = find_max(curr);
                    if (swap == null)
                    {
                        if (left)
                        {
                            parent.left = curr.right;
                        }
                        else
                        {
                            parent.right = curr.right;
                        }

                    }
                    else
                    {
                        if (left)
                        {
                            parent.left = swap;
                        }
                        else
                        {
                            parent.right = swap;
                        }
                    }

                }


            }
        }


    }
}

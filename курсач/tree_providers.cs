using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace курсач
{
    public class tree_providers
    {
        public class root
        {
            public string title;
            public root left, right;
            public int current ;
            public int max;
            public struct info
            {
               public string name;
               public int cost;
            }
            public info[] arr = new info[5];

            public root(string name) {
                this.title = name;
                current = 0;
                left = right = null;
                max = 5;
            }
        }
        public root main = null;

        public tree_providers()
        {

        }

        public int compare(string a, string b)//сравнение строк
        {
            
                
            for(int i = 0; ((i < a.Length) && (i < b.Length)); i++)
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
        public void add_Provider(string name)
        {
            bool placed = false;
            if (main == null)
                main = new root(name);
            else
            {
                root curr= main;
                while (!placed) { 
                int i = compare(name, curr.title);
                    if (i == -1)
                        if (curr.left == null)
                        {
                            root temp = new root(name);
                            curr.left = temp;
                            placed = true;
                        }
                        else
                            curr = curr.left;
                    else if (i == 1)
                        if (curr.right == null)
                        {
                            root temp = new root(name);
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
        public root find(string name)//поиск
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
                    int i = compare(name, curr.title);
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
        public root find_max(root from_this)//поиск макс слева
        {
            root curr;
            root check;
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
        public void delete(string name)//удаление 
        {
            bool left = true;
            root parent = main;
            bool deleted = false;
            root curr = main;
            int i = compare(name, main.title);
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

                i = compare(name, curr.title);
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
                    if(swap == null)
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
        public void add_tariph(string name, int cost,root pr)
        {
            if (pr.current == pr.max)
            {
                Array.Resize(ref pr.arr, pr.max + 10);
                pr.max += 10;
            }
            pr.arr[pr.current].name = name;
            pr.arr[pr.current].cost = cost;
            pr.current++;
        }
        public void del_tariph(string name, int cost, root pr)
        {
            for (int i = 0; i < pr.current; i++) 
                if ((pr.arr[i].name == name) && (pr.arr[i].cost == cost))
                {
                    for (int j = i; j < pr.current - 1; j++)
                        pr.arr[j] = pr.arr[j + 1];
                }
            pr.current--;
        }
        public void change_tariph(string name,int cost, string new_name,int new_cost, root pr)
        {
            for(int i = 0; i<pr.current;i++)
                if ((pr.arr[i].name == name) && (pr.arr[i].cost == cost))
                {
                    if (new_name != "")
                        pr.arr[i].name = new_name;
                    if (new_cost != 0)
                        pr.arr[i].cost = new_cost;
                }

        }
   /*     public root.info get_tariph(root pr, int ind)
        {
            return pr.arr[ind];
        }*/
        public root print_provider(int ind,root parent,ref int curr)
        {
            if (parent.left != null)
            {
                root left = print_provider(ind, parent.left, ref curr);
                if(left!=null)
                    return left;
            }
            
            curr++;
            if (ind == curr)
                return parent;
            else if (parent.right!=null)
            
            {
                root right = print_provider(ind, parent.right, ref curr);
                if (right != null) 
                    return right;
            }
            return null;

        }

    }
}


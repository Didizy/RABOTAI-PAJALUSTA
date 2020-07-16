using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace курсач
{
    public class tree_providers
    {
        public int comparisons = 0;
        public class root
        {
            public string title;
            public root left, right;
            public int current_tariph ;
            public int max_tariph;
            public int current_user;
            public int max_user;
            public string[] users = new string[5];
            public struct info
            {
               public string name;
               public int cost;
            }
            public info[] arr = new info[5];


            public root(string name) {
                title = name;
                current_tariph = 0;
                left = right = null;
                max_tariph = 5;
                max_user = 5;
                current_user = 0;
                
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
        public bool add_Provider(string name)
        {

            if (main == null)
            {
                main = new root(name);
                return true;
            }
            else
            {
                root curr = main;
                while (true)
                {
                    int i = compare(name, curr.title);
                    if (i == -1)
                        if (curr.left == null)
                        {
                            root temp = new root(name);
                            curr.left = temp;
                            return true;
                        }
                        else
                            curr = curr.left;
                    else if (i == 1)
                        if (curr.right == null)
                        {
                            root temp = new root(name);
                            curr.right = temp;
                            return true;
                        }
                        else
                            curr = curr.right;
                    else if (i == 0)
                    {
                        return false;
                    }


                }
            }
        }
        public root find(string name)//поиск
        {
            if (main == null)
            {
                comparisons++;
                //error
                return null;
            }
            else
            {
                root curr = main;
                while (true)
                {
                    int i = compare(name, curr.title);
                    comparisons++;
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
        public bool delete(string name)//удаление 
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
                return true;
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
                if (curr == null)
                    return false;
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
                            swap.left = curr.left;
                            swap.right = curr.right;
                            parent.left = swap;
                        }
                        else
                        {
                            swap.left = curr.left;
                            swap.right = curr.right;
                            parent.right = swap;
                        }
                    }
                    return true;
                }
            }
            return false;
        }
        public bool add_tariph(string name, int cost,string provider_name)
        {
            root pr = find(provider_name);
            if (pr == null)
                return false;
            if (pr.current_tariph == pr.max_tariph)
            {
                Array.Resize(ref pr.arr, pr.max_tariph + 10);
                pr.max_tariph += 10;
            }
            for(int i =0; i< pr.max_tariph; i++)
            {
                if (pr.arr[i].name == name)
                    return false;
            }
            pr.arr[pr.current_tariph].name = name;
            pr.arr[pr.current_tariph].cost = cost;
            pr.current_tariph++;
            return true;
        }
        public bool del_tariph(string name, root pr)
        {
            for (int i = 0; i < pr.current_tariph; i++) 
                if ((pr.arr[i].name == name))
                {
                    for (int j = i; j < pr.current_tariph - 1; j++)
                        pr.arr[j] = pr.arr[j + 1];
                    pr.arr[pr.current_tariph - 1].name = "";
                    pr.arr[pr.current_tariph - 1].cost = 0;
                    pr.current_tariph--;
                    return true;
                }
            return false;
           
        }
       /* public void change_tariph(string name,int cost, string new_name,int new_cost, root pr)
        {
            for(int i = 0; i<pr.current_tariph;i++)
                if ((pr.arr[i].name == name) && (pr.arr[i].cost == cost))
                {
                    if (new_name != "")
                        pr.arr[i].name = new_name;
                    if (new_cost != 0)
                        pr.arr[i].cost = new_cost;
                }

        }*/
        /*private root.info get_tariph(root pr,int ind)
        {
            return pr.arr[ind];
        }*/
        /*public root print_provider(int ind,root parent,ref int curr)
        {
            if (parent == null)
                return null;
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

        }*/
        public bool add_user(string login, string provider_name)
        {
            root a = find(provider_name);
           if (a.current_user == a.max_user)
            {
                Array.Resize(ref a.users, a.max_user + 5);
                a.max_user += 5;
                
            }
           for(int i = 0; i < a.max_user; i++)
            {
                if (a.users[i] == login)
                    return false;
            }
            a.users[a.current_user] = login;
            a.current_user++;
            return true;
                
        }
        //public void change_user()
        public bool delete_user(string login, string provider_name)
        {
            root pr = find(provider_name);
            for (int i = 0; i < pr.max_user; i++)
            {
                if (pr.users[i] == login)
                {
                    for(int j = i; j < pr.max_user - 1; j++)
                    {
                        pr.users[j] = pr.users[j + 1];
                    }
                    pr.users[pr.current_user-1] = "";
                    pr.current_user--;
                    return true;
                }
            }
            return false;
        }
    }
}


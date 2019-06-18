using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class BinSearchTree : ISetSorted
    {
        public Node root;
        public Node current;

        /***********************/
        /********SEARCH*********/
        /***********************/
        public bool Search(int elem)
        {
            if (root == null)
                return false;
            else
            {
                Node index = root;
                while (index != null)
                {
                    if (index.value > elem)
                        index = index.left;
                    else if (index.value < elem)
                        index = index.right;
                    else
                    {
                        current = index;
                        Console.WriteLine("gefunden");
                        return true; //index.wert == elem => gefunden
                    }

                }
                Console.WriteLine("Objekt nicht vorhanden");
                return false; //komplett durch und index == null => nicht gefunden
            }
        }

        /***********************/
        /********INSERT*********/
        /***********************/
        public virtual bool Insert(int elem)
        {
            if (root == null)
                root = new Node(elem, null);
            else
                Insert(root, elem);
            Console.WriteLine("eingefügt");
            return true;
        }
        private void Insert(Node index, int elem)
        {
            if (index.value > elem)
            {
                if (index.left == null)
                {
                    index.left = new Node(elem, index);
                    current = index.left;
                }
                else
                {
                    Insert(index.left, elem);
                }
            }
            else if (index.value < elem)
            {
                if (index.right == null)
                {
                    index.right = new Node(elem, index);
                    current = index.right;
                }
                else
                {
                    Insert(index.right, elem);
                }
            }
            else return;
        }

        /***********************/
        /********Delete*********/
        /***********************/
        public virtual bool Delete(int elem)
        {
            if (root == null) { return false; }

            Node index = root;
            while (index != null)
            {
                if (index.value == elem)
                    break;
                else if (index.value < elem)
                    index = index.right;
                else
                    index = index.left;
            }
            if (index == null) { return false; }

            Delete(index);
            return true;
        }
        private void Delete(Node node)
        {
            Node parent = node.parent;

            if(node.left == null && node.right == null) //Blatt ohne Nachfolger
            {
                if (parent.left == node)
                    parent.left = null;
                else parent.right = null;
            }
            else if (node.left == null || node.right == null && node.left != node.right) //Zu Löschendes Blatt hat nur einen Nachfolger
            {
                if(node.left == null)
                {
                    if (node.right.left == null && node.right.right == null)
                    {
                        if (parent.left == node)
                            parent.left = node.right;
                        else parent.right = node.right;
                    }
                    else //Falls nachfolgendes Element auch nachfolger hat
                    {
                        if (parent.left == node)
                        {
                            if (node.left != null)
                                parent.left = node.left;
                            else parent.left = node.right;
                        }
                        else
                        {
                            if (node.left != null)
                                parent.right = node.left;
                            else parent.right = node.right;
                        }
                    }
                }
                else if(node.right == null)
                {
                    if (node.left.left == null && node.left.right == null)
                    {
                        if (parent.left == node)
                            parent.left = node.left;
                        else parent.right = node.left;
                    }
                    else //Falls nachfolgendes Element auch nachfolger hat
                    {
                        if (parent.left == node)
                        {
                            if (node.left != null)
                                parent.left = node.left;
                            else parent.left = node.right;
                        }
                        else
                        {
                            if (node.left != null)
                                parent.right = node.left;
                            else parent.right = node.right;
                        }
                    }
                }
            }
            else if (node.left != null && node.right != null) //Zu Löschendes Blatt hat zwei Nachfolger
            {
                Node index = node;
                index = index.left;
                while (index.right != null) //Am ende steht in index letzes Element
                {
                    index = index.right;
                }
                //Blatt wird zu löschendem Element
                node.value = index.value;
                Delete(index);
            }
        }


        /***********************/
        /********Print*********/
        /***********************/
        public virtual void Print()
        {
            Console.WriteLine("Choose if: PREORDER = 1, INORDER = 2, POSTORDER = 3");
            int order = Convert.ToInt16(Console.ReadLine());
            if (order == 1 || order == 2 || order == 3)
            {
                Print(root, order);
            }
        }   
        private void Print(Node node, int order)
        {
            if (node == null)
                return;
            if (order == 1)
            {
                if (node.parent != null)
                {
                    if (node.parent.right == node)
                    {
                        if (Treap.type == "Treap")
                        {
                            Console.WriteLine(node.value + ", Prio: " + node.prio + " r");
                        }
                        else
                        {
                            Console.WriteLine(node.value + " r");
                        }
                    }
                    else
                    {
                        if (Treap.type == "Treap")
                        {
                            Console.WriteLine(node.value + ", Prio: " + node.prio + " l");
                        }
                        else
                        {
                            Console.WriteLine(node.value + " l");
                        }
                    }
                }
                else
                {
                    if (Treap.type == "Treap")
                    {
                        Console.WriteLine(node.value + ", Prio: " + node.prio + " ich bin eine Wurzel");
                    }
                    else
                    {
                    Console.WriteLine(node.value + " ich bin eine Wurzel");
                    }
                }

                if (node.left != null)
                    Print(node.left, order);
                if (node.right != null)
                    Print(node.right, order);
            }
            else if (order == 2)
            {
                if (node.left != null)
                    Print(node.left, order);
                if (Treap.type == "Treap")
                {
                    Console.WriteLine(node.value + ", Prio: " + node.prio);
                }
                else
                {
                    Console.WriteLine(node.value);
                }
                if (node.right != null)
                    Print(node.right, order);
            }
            else if (order == 3)
            {
                if (node.left != null)
                    Print(node.left, order);
                if (node.right != null)
                    Print(node.right, order);
                if (Treap.type == "Treap")
                {
                    Console.WriteLine(node.value + ", Prio: " + node.prio);
                }
                else
                {
                    Console.WriteLine(node.value);
                }
            }
        }
    }
}

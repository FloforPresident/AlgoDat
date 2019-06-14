using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class BinSearchTree : ISetSorted
    {
        class Node
        {
            public Node left;
            public Node right;
            public Node parent;
            public int value;

            public Node(int value)
            {
                this.value = value;
            }


            /***********************/
            /********Print*********/
            /***********************/
            public static void print(Node node, int order)
            {
                if (node == null)
                    return;

                if (order == 1)
                {
                    Console.WriteLine(node.value);
                    if (node.left != null)
                        print(node.left, order);
                    if (node.right != null)
                        print(node.right, order);
                }
                else if (order == 2)
                {
                    if (node.left != null)
                        print(node.left, order);
                    Console.WriteLine(node.value);
                    if (node.right != null)
                        print(node.right, order);
                }
                else if (order == 3)
                {
                    if (node.left != null)
                        print(node.left, order);
                    if (node.right != null)
                        print(node.right, order);
                    Console.WriteLine(node.value);
                }
            }
        }

        Node root;


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
                        return true; //index.wert == elem => gefunden
                }
                return false; //komplett durch und index == null => nicht gefunden
            }
        }

        /***********************/
        /********INSERT*********/
        /***********************/
        public bool Insert(int elem)
        {
            if (root == null)
                root = new Node(elem);
            else
                Insert(root, elem);
            return true;
        }
        private void Insert(Node index, int elem)
        {
            while (index != null)
            {
                if (index.value > elem)
                {
                    if (index.left == null)
                    {
                        index.left = new Node(elem);
                        return;
                    }
                    else
                        index = index.left;
                }
                else if (index.value < elem)
                {
                    if (index.right == null)
                    {
                        index.right = new Node(elem);
                        return;
                    }
                    else
                        index = index.right;
                }
                else return;
            }
        }

        /***********************/
        /********DELETE*********/
        /***********************/
        public bool Delete(int elem)
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

            Node delete = index; //umspeichern damit index später wiederverwertet werden kann / delete ist Node dass gelöscht wird

            if (delete.left == null && delete.right == null) //Blatt ohne Nachfolger
            {
                delete = null;
                Console.WriteLine("Ich bin hier");
                return true;
            }
            if (delete.left == null || delete.right == null && delete.left != delete.right) //Zu Löschendes Blatt hat nur einen Nachfolger
            {
                if (delete.left == null)
                {
                    delete = delete.right;
                }
                if (delete.right == null)
                {
                    delete = delete.left;
                }
                return true;
            }


            if (delete.left != null && delete.right != null)
            {
                index = index.left;
                while (index.right != null)
                {
                    index = index.right;
                }
                delete = index;
                index = null;
                return true;
            }
            return false;
        }


        /***********************/
        /********Print*********/
        /***********************/
        public void Print()
        {
            Console.WriteLine("Choose if: PREORDER = 1, INORDER = 2, POSTORDER = 3");
            int order = Convert.ToInt16(Console.ReadLine());
            if (order == 1 || order == 2 || order == 3)
            {
                Node.print(root, order);
            }
        }
    }
}

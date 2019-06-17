using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class AVLTree : BinSearchTree
    {
        Node root;

        public int Anzahl()
        {
            if (root == null)
                return 0;
            else
            {
                return 1 + Anzahl(root.left) + Anzahl(root.right);
            }
        }
        private int Anzahl(Node node)
        {
            if (root == null)
                return 0;
            else
            {
                return 1 + Anzahl(node.left) + Anzahl(node.right);
            }
        }
        
        public int Hoehe()
        {
            int l = 0, r = 0;
            if(root.left != null)
                l = Hoehe(root.left) + 1;

            if (root.right != null)
                r = Hoehe(root.right) + 1;

            return Math.Max(l, r);
        }
        private int Hoehe(Node Node)
        {
            int l = 0, r = 0;
            if (Node.left != null)
                l = Hoehe(Node.left) + 1;

            if (Node.right != null)
                r = Hoehe(Node.right) + 1;

            return Math.Max(l, r);
        }

        /***********************/
        /********INSERT*********/
        /***********************/
        public override bool Insert(int elem)
        {
            if (root == null)
            {
                root = new Node(elem, null);
            }
            else
                Insert(root, elem);
            return true;
        }
        private void Insert(Node node, int elem)
        {
            if (node.value > elem)
            {
                if (node.left == null)
                    node.left = new Node(elem, node);
                else
                {
                    Insert(node.left, elem);

                    int r, l;
                    if (node.left != null)
                        l = node.left.Hoehe();
                    else l = 0;
                    if (node.right != null)
                        r = node.left.Hoehe();
                    else r = 0;

                    if (l - r == 2)
                    {
                        if (elem - node.left.value < 0)
                            node = rotateWithLeftChild(node);
                        else
                            node = doubleRotateWithRightChild(node);
                    }
                }
            }
            else if (node.value < elem)
            {
                if (node.right == null)
                    node.right = new Node(elem, node);
                else
                {
                    Insert(node.right, elem);

                    int r, l;
                    if (node.left != null)
                        l = node.left.Hoehe();
                    else l = 0;
                    if (node.right != null)
                        r = node.right.Hoehe();
                    else r = 0;

                    if (r - l == 2)
                    {
                        if(elem - node.right.value > 0)
                            node = rotateWithRightChild(node);
                        else
                            node = doubleRotateWithLeftChild(node);
                    }
                }
            }
            else return;
        }
        private Node rotateWithLeftChild(Node n2)
        {
            Node n1 = n2.left;
            n2.left = n1.right;
            n1.right = n2;
            return n1;
        }
        private Node rotateWithRightChild(Node n1)
        {
            Node n2 = n1.right;
            n1.right = n2.left;
            n2.left = n1;
            return n2;
        }
        private Node doubleRotateWithRightChild(Node n3)
        {
            n3.left = rotateWithRightChild(n3.left);
            return rotateWithLeftChild(n3);
        }
        private Node doubleRotateWithLeftChild(Node n1)
        {
            n1.right = rotateWithLeftChild(n1.right);
            return rotateWithRightChild(n1);
        }

        /***********************/
        /********Print*********/
        /***********************/
        public override void Print()
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

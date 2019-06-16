using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class AVLTree : BinSearchTree
    {
        AVLNode root;

        public int Anzahl()
        {
            if (root == null)
                return 0;
            else
            {
                return 1 + Anzahl(root.left) + Anzahl(root.right);
            }
        }
        private int Anzahl(BinSearchNode node)
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
        private int Hoehe(BinSearchNode BinSearchNode)
        {
            int l = 0, r = 0;
            if (BinSearchNode.left != null)
                l = Hoehe(BinSearchNode.left) + 1;

            if (BinSearchNode.right != null)
                r = Hoehe(BinSearchNode.right) + 1;

            return Math.Max(l, r);
        }

        /***********************/
        /********INSERT*********/
        /***********************/
        public new bool Insert(int elem)
        {
            if (root == null)
            {
                root = new AVLNode(elem, null);
            }
            else
                Insert(root, elem);
            return true;
        }
        private void Insert(AVLNode node, int elem)
        {
            if (node.value > elem)
            {
                if (node.left == null)
                    node.left = new AVLNode(elem, node);
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
                    node.right = new AVLNode(elem, node);
                else
                {
                    Insert(node.right, elem);

                    int r, l;
                    if (node.left != null)
                        l = node.left.Hoehe();
                    else l = 0;
                    if (node.right != null)
                        r = node.left.Hoehe();
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
        private AVLNode rotateWithLeftChild(AVLNode n2)
        {
            AVLNode n1 = n2.left;
            n2.left = n1.right;
            n1.right = n2;
            return n1;
        }
        private AVLNode rotateWithRightChild(AVLNode n1)
        {
            AVLNode n2 = n1.right;
            n1.right = n2.left;
            n2.left = n1;
            return n2;
        }
        private AVLNode doubleRotateWithRightChild(AVLNode n3)
        {
            n3.left = rotateWithRightChild(n3.left);
            return rotateWithLeftChild(n3);
        }
        private AVLNode doubleRotateWithLeftChild(AVLNode n1)
        {
            n1.right = rotateWithLeftChild(n1.right);
            return rotateWithRightChild(n1);
        }

        /***********************/
        /********Print*********/
        /***********************/
        public new void Print()
        {
            Console.WriteLine("Choose if: PREORDER = 1, INORDER = 2, POSTORDER = 3");
            int order = Convert.ToInt16(Console.ReadLine());
            if (order == 1 || order == 2 || order == 3)
            {
                AVLNode.print(root, order);
            }
        }
    }
}

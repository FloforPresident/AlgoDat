using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class AVLTree : BinSearchTree
    {
        public int getHeight(Node node)
        {
            int l = 0, r = 0;
            if(node != null)
            {
            l += getHeight(node.left) + 1;
            r += getHeight(node.right) + 1;
            }
            return Math.Max(l, r);
        }
        public override bool Insert(int elem)
        {
            if (root == null)
            {
                root = new Node(elem, null);
            }
            else
            {
                Insert(root, elem);
            }
            Console.WriteLine("eingefügt");
            return true;
        }
        private void Insert(Node current, int elem)
        {
            Node node = new Node(elem, current);

            if (node.value < current.value)
            {
                if (current.left == null)
                {
                    current.left = node;
                }
                else
                {
                    Insert(current.left, node.value);
                    orderTree(current);
                }
            }
            else if (node.value > current.value)
            {
                if (current.right == null)
                {
                    current.right = node;
                }
                else
                {
                    Insert(current.right, node.value);
                    orderTree(current);
                }
            }
            else if (node.value == current.value)
                return;
        }

        private Node rotateWithLeftChild(Node n2)
        {
            Node n1 = n2.left;
            n2.left = n1.right;
            n1.right = n2;

            if (n1.parent.parent == null)
            {
                n1.parent = null;
                root = n1;
            }
            else
            {
                n1.parent = n1.parent.parent;
                if (n1.value > n1.parent.value)
                    n1.parent.right = n1;
                else n1.parent.left = n1;
            }
            n2.parent = n1;

            return n1;
        }
        private Node rotateWithRightChild(Node n1)
        {
            Node n2 = n1.right;
            n1.right = n2.left;
            n2.left = n1;

            if (n2.parent.parent == null)
            {
                n2.parent = null;
                root = n2;
            }
            else
            {
                n2.parent = n2.parent.parent;
                if (n2.value > n2.parent.value)
                    n2.parent.right = n2;
                else n2.parent.left = n2;
            }
            n1.parent = n2;

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

        private Node orderTree(Node current)
        {
            int balance = getBalance(current);

            if (balance > 1)
            {
                if (current.left.value < current.value)
                {
                    current = rotateWithLeftChild(current);
                }
                else
                {
                    current = doubleRotateWithLeftChild(current);
                }
            }
            else if (balance < -1)
            {
                if (current.right.value < current.value)
                {
                    current = doubleRotateWithRightChild(current);
                }
                else
                {
                    current = rotateWithRightChild(current);
                }
            }

            return current;
        }

        // Get Balance factor of node N
        private int getBalance(Node current)
        {
            int l = getHeight(current.left);
            int r = getHeight(current.right);
            int b_factor = l - r;
            return b_factor;
        }

        public override bool Delete(int number)
        {
            base.Delete(number);

            orderTree(root);

            return true;
        }
    }
}

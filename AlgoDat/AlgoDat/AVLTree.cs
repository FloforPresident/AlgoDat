using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class AVLTree : BinSearchTree
    {
        private int height(Node n)
        {
            if (n == null)
                return 0;
            return n.height;
        }
        public override bool Insert(int elem)
        {
            if (root == null)
            {
                root = new Node(elem, null);
            }
            else
                Insert(elem, root);
            return true;
        }
        private void Insert(int elem, Node node)
        {
            //1. Neues Element Hinzufügen
            if (elem < node.value)
                node.left = new Node(elem, node);
            else if (elem > node.value)
                node.right = new Node(elem, node);
            else return;

            //2. Höhe von node updaten
            node.height = Math.Max(height(node.left), height(node.right)) + 1;

            //3. Checken ob node unbalanciert wird
            int balance = getBalance(node);

            //Wenn unbalanciert gibts 4 Fälle:
            //Left Left Case
            // Left Left Case
            if (balance > 1 && elem < node.left.value)
                rightRotate(node);

            // Right Right Case
            if (balance < -1 && elem > node.right.value)
                leftRotate(node);

            // Left Right Case
            if (balance > 1 && elem > node.left.value)
            {
                node.left = leftRotate(node.left);
                rightRotate(node);
            }

            // Right Left Case
            if (balance < -1 && elem < node.right.value)
            {
                node.right = rightRotate(node.right);
                leftRotate(node);
            }
        }

        private Node rightRotate(Node y)
        {
            Node x = y.left;
            Node T2 = x.right;

            // Perform rotation
            x.right = y;
            y.left = T2;

            // Update heights
            y.height = Math.Max(height(y.left), height(y.right)) + 1;
            x.height = Math.Max(height(x.left), height(x.right)) + 1;

            // Return new root
            return x;
        }
        private Node leftRotate(Node x)
        {
            Node y = x.right;
            Node T2 = y.left;

            // Perform rotation
            y.left = x;
            x.right = T2;

            //  Update heights
            x.height = Math.Max(height(x.left), height(x.right)) + 1;
            y.height = Math.Max(height(y.left), height(y.right)) + 1;

            // Return new root
            return y;
        }

        // Get Balance factor of node N
        private int getBalance(Node N)
        {
            if (N == null)
                return 0;
            return height(N.left) - height(N.right);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    public class Node
    {
        public Node left;
        public Node right;
        public int value;
        public Node parent;

        public Node(int Value, Node Parent)
        {
            this.value = Value;
            this.parent = Parent;
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

        /***********************/
        /********HOEHE*********/
        /***********************/
        public int Hoehe()
        {
            int l = 0, r = 0;
            if (this.left != null)
                l = this.left.Hoehe() + 1;

            if (this.right != null)
                r = this.right.Hoehe() + 1;

            return Math.Max(l, r);
        }
    }
}

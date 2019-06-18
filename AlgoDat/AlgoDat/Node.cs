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
        public int height = 1;

        public int prio;
        Random zufall = new Random();

        public Node(int Value, Node Parent)
        {
            this.value = Value;
            this.parent = Parent;
            left = null;
            right = null;
            prio = zufall.Next(0, 100);
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
                if (node.parent != null)
                {
                    if (node.parent.right == node)
                        Console.WriteLine(node.value + " r");
                    else
                        Console.WriteLine(node.value + " l");
                }
                else Console.WriteLine(node.value + " ich bin eine Wurzel");

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
}

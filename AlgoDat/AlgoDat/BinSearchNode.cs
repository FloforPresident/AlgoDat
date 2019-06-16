using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    public class BinSearchNode
    {
        public BinSearchNode left;
        public BinSearchNode right;
        public int value;
        public BinSearchNode parent;

        public BinSearchNode(int Value, BinSearchNode Parent)
        {
            this.value = Value;
            this.parent = Parent;
        }


        /***********************/
        /********Print*********/
        /***********************/
        public static void print(BinSearchNode node, int order)
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
}

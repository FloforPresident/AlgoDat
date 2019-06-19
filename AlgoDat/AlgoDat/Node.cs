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

        public int prio;
        private static Random zufall = new Random();

        public Node(int Value, Node Parent)
        {
            this.value = Value;
            this.parent = Parent;
            left = null;
            right = null;
            prio = zufall.Next(100);
        }
    }
}

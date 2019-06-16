using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    public class AVLNode : BinSearchNode
    {
        public new AVLNode left, right;
        public AVLNode(int Value, AVLNode Parent) : base(Value, Parent)
        {
            value = Value;
            parent = Parent;
        }

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

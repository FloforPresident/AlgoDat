using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class Treap : BinSearchTree, ISetSorted
    {
        public Node root;
        //Node pointer = current; //kein Plan warum
        public override bool Insert(int elem)
        {
            if (root == null) //Baum existiert noch nicht
            {
                base.Insert(elem);
                return true;
            }
            else
            {
                base.Insert(elem);
            }
            Heapbedingung(current);

            return false;
        }

        public override bool Delete(int elem)
        {
            return false;
        }

        private void Heapbedingung(Node n)
        {

        }

        public void LeftRotation(Node n)
        {

        }

        public void RightRotation (Node n)
        {

        }
    }
}

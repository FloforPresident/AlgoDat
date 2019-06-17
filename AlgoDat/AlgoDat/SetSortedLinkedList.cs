using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class SetSortedLinkedList : MultiSetSortedList, ISetSorted
    {
        public new bool Insert(int elem)
        {
            if (Search(elem) == true)//element enthalten
            {
                return false;
            }
            else
            {
                LElement newelem = new LElement(elem);
                _search_(elem);
                if (prev == null)
                {
                    newelem.next = root;
                    root = newelem;
                }
                else
                {
                    newelem.next = prev.next;
                    prev.next = newelem;
                }
                return true;
            }
        }
    }
}

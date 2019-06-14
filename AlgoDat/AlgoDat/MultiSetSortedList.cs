using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class MultiSetSortedList : SupportList, IMultiSetSorted
    {
        public bool Insert(int elem)
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

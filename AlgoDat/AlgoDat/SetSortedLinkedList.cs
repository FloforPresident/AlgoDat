using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class SetSortedLinkedList : MultiSetSortedList, ISetSorted
    {
        public bool Search(int elem) { return false; }
        public bool Insert(int elem) { return false; }
        public bool Delete(int elem) { return false; }
        public void Print(int elem) { }
    }
}

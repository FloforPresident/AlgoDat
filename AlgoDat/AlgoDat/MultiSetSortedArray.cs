using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class MultiSetSortedArray : SupportArray, IMultiSetSorted
    {
        public bool Search(int elem) { return false; }
        public bool Insert(int elem) { return false; }
        public bool Delete(int elem) { return false; }
        public void Print(int elem) { }
    }
}

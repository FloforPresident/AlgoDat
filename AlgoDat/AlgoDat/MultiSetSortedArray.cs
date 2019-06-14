using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class MultiSetSortedArray : SupportArray, IMultiSetSorted
    {
        public override bool Search(int elem) { return false; }
        public override bool Insert(int elem) { return false; }
        public override bool Delete(int elem) { return false; }
    }
}

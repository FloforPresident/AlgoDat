using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class SetSortedArray: MultiSetSortedArray, ISetSorted
    {
        public override bool Insert(int elem) { return false; }
    }
}

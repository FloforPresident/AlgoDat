using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class MultiSetUnsortedArray : SupportArray, IMultiSet
    {
        //print in SupportArray
        public virtual bool Insert(int a) { return false; }
        public bool Search(int a) { return false; }
        public bool Delete(int a) { return false; }
    }
}

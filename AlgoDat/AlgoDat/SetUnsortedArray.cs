using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class SetUnsortedArray : MultiSetUnsortedArray, ISet
    {
        public override bool Insert(int a)
        {
            return false;
        }
    }
}

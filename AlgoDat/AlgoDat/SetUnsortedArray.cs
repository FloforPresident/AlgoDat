using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class SetUnsortedArray : MultiSetUnsortedArray, ISet
    {
        public override bool Insert(int newElem)
        {
            if (!Search(newElem))
            {
                int i = SearchIndex(0);

                if (i >= 0)
                {
                    myArray[i] = newElem;
                    Console.WriteLine("inserted");
                    return true;
                }
            }
            Console.WriteLine("not inserted");
            return false;
        }        
    }
}

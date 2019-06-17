using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class SetSortedArray : MultiSetSortedArray, ISetSorted
    {
        public override bool Insert(int elem)
        {
            Search(elem);

            if (searchindex != -1)//Element existiert schon einmal
            {
                Console.WriteLine("Element existiert bereits");
                return false;
            }
            else //Element existiert noch nicht
            {
                if (InsertElemaftersearch(elem))
                {
                    return true;
                }
            }
            Console.WriteLine("Irgendwas stimmt nicht");
            return false;
        }
    }
}

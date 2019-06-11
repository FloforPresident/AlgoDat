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
                for (int i = 0; i < myArray.Length; i++)
                {
                    if (myArray[i] == 0)
                    {
                        myArray[i] = newElem;
                        Console.WriteLine("inserted");
                        return true;
                    }
                }
                Console.WriteLine("array is full");
                return false;
            }
            Console.WriteLine("already in array");
            return false;
        }
    }
}

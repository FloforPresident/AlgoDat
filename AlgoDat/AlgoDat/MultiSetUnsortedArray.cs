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
        public override bool Search(int elem)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == elem)
                {
                    Console.WriteLine("found");
                    return true;
                }
            }
            Console.WriteLine("not found");
            return false;
        }

        protected int SearchIndex(int elem)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if(myArray[i] == elem)
                {
                    return i;
                }
            }
            return -1;
        }

        public override bool Insert(int newElem)
        {
            int i = SearchIndex(0);
            if(i >= 0 && newElem > 0)
            {
                myArray[i] = newElem;
                Console.WriteLine("inserted");
                return true;
            }
            else
            {
                Console.WriteLine("not inserted");
                return false;
            }
                
        }

        public override bool Delete(int elem)
        {
            if(!Search(elem))
            {
                return false;
            }
            else
            {
                int i = SearchIndex(elem);
                myArray[i] = 0;
                Console.WriteLine("deleted");
                return true;
            }
        }
    }
}

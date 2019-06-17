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
        public bool Search(int elem)
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

        public virtual bool Insert(int newElem)
        {
            int index = SearchIndex(-1);
            if (index >= 0 && newElem > -1)
            {
                myArray[index] = newElem;
                Console.WriteLine("inserted");
                return true;
            }
            else
            {
                Console.WriteLine("not inserted");
                return false;
            }

        }

        public virtual bool Delete(int elem)
        {
            if(!Search(elem))
            {
                return false;
            }
            else
            {
                int i = SearchIndex(elem);
                if(myArray.Contains(-1)) //array is not full
                {
                    myArray[i] = myArray[SearchIndex(-1)-1];
                    myArray[SearchIndex(-1)-1] = -1;               
                }
                else //if array is full
                {
                    myArray[i] = myArray[myArray.Length - 1];
                    myArray[myArray.Length - 1] = -1;
                }
                Console.WriteLine("deleted");
                return true;
            }
        }
    }
}

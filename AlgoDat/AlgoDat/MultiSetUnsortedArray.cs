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
                    Console.WriteLine("gefunden");
                    return true;
                }
            }
            Console.WriteLine("nicht gefunden");
            return false;
        }

        public virtual bool Insert(int newElem)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if(myArray[i] == 0)
                {
                    myArray[i] = newElem;
                    Console.WriteLine("inserted");
                    return true;
                }
            }
            Console.WriteLine("Array is full");
            return false;
        }


        public bool Delete(int elem)
        {
            if(!Search(elem))
            {
                Console.WriteLine("not found");
                return false;
            }
            else
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    if(myArray[i] == elem)
                    {
                        myArray[i] = 0;
                        Console.WriteLine("deleted");
                        return true;
                    }
                }
            }
            Console.WriteLine("ERROR");
            return false;
        }
    }
}

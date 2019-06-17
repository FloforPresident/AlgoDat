using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class HashTabQuadProb : MultiSetUnsortedArray
    {
        public override bool Insert(int newElem)
        {
            int trials = 0;
            while (trials < 100)
            {
                int index = ((4 * newElem + 3) + trials * Math.Abs(trials)) % myArray.Length;
                if (myArray[index] == -1)
                {
                    myArray[index] = newElem;
                    Console.WriteLine("inserted");
                    return true;
                }
                if (trials == 0)
                {
                    trials++;
                }
                else if (trials > 0)
                {
                    trials *= -1;
                }
                else 
                {
                    trials *= -1;
                    trials++;
                }
            }
            Console.WriteLine("not inserted");
            return false;
        }
        public override bool Delete(int elem)
        {
            if (!Search(elem))
            {
                return false;
            }
            else
            {
                int i = SearchIndex(elem);
                myArray[i] = -1;
                Console.WriteLine("deleted");
                return true;
            }
        }
    }
}

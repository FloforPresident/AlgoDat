using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    abstract class SupportArray
    {
        public int[] myArray = new int[50]; //array declaration

        public void Print()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

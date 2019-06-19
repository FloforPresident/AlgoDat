using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    abstract class SupportArray
    {
        public int[] myArray = new int[7]; //array declaration

        // Konstruktor um Array mit -1 als Default zu füllen
        public SupportArray()
        {
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                myArray[i] = -1;
            }
        }

        public void Print()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] != -1)
                {
                    Console.Write(myArray[i] + " ");
                }
        }
            Console.WriteLine();
        }
    }
}

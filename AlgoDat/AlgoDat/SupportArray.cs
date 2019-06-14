using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    abstract class SupportArray :IDictonary
    {
        public int[] myArray = new int[50]; //array declaration
        public abstract bool Search(int elem);
        public abstract bool Insert(int elem);
        public abstract bool Delete(int elem);

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

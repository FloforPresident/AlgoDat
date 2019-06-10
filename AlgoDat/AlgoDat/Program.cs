using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 2;
            }
            SetUnsortedArray test1 = new SetUnsortedArray();


            //BinSearchTree Test
            BinSearchTree testTree = new BinSearchTree();
            testTree.Insert(9);
            testTree.Insert(4);
            testTree.Insert(10);
            testTree.Insert(2);
            Console.WriteLine(testTree.Search(1));
        }
    }
}

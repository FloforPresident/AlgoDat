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
            ////Haupt Bibliotheksprogramm
            //IDictonary myArray = null;

            ////which kind of array
            //bool libraryRuns = true;

            //Console.WriteLine("Wählen Sie die Art Ihres Wörterbuchs aus:\n" +
            //    "1. Multiset unsorted Array\n" +
            //    "2. Multiset Sorted Array\n" +
            //    "3. Set unsorted Array\n"   +
            //    "4. Set sorted Array\n"  +
            //    "");
            //while (libraryRuns)
            //{
            //    string a = Console.ReadLine();
            //    if (a == "1")
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Sie haben sich für ein Multiset unsorted Array entschieden");
            //        myArray = new MultiSetUnsortedArray();
            //        libraryRuns = false;
            //    }
            //    else if (a == "2")
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Sie haben sich für ein Multiset sorted Array entschieden");
            //        myArray = new MultiSetSortedArray();
            //        libraryRuns = false;
            //    }
            //    else if (a == "3")
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Sie haben sich für ein Set unsorted Array entschieden");
            //        myArray = new SetUnsortedArray();
            //        libraryRuns = false;
            //    }
            //    else if (a == "4")
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Sie haben sich für ein Set sorted Array entschieden");
            //        myArray = new SetSortedArray();
            //        libraryRuns = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Bitte geben Sie eine der Möglichkeiten an");
            //        continue;
            //    }
            //}

            ////what to do with array
            //ShowOptions();
            //bool optionsRun = true;
            //while (optionsRun)
            //{
            //    Console.Write("\nWählen Sie eine Option für Ihr Array aus: ");
            //    string b = Console.ReadLine();
                
            //    if (b == "1")
            //    {
            //        Console.Write("\nPrint Array: ");
            //        myArray.Print();
            //    }
            //    else if (b == "2")
            //    {
            //        Console.WriteLine("\nSearch Element: ");
            //        int c = Convert.ToInt32(Console.ReadLine());
            //        myArray.Search(c);
            //    }
            //    else if (b == "3")
            //    {
            //        Console.WriteLine("\nInsert Element: ");
            //        int c = Convert.ToInt32(Console.ReadLine());
            //        myArray.Insert(c);
            //    }
            //    else if (b == "4")
            //    {
            //        Console.WriteLine("\nDelete Element: ");
            //        int c = Convert.ToInt32(Console.ReadLine());
            //        myArray.Delete(c);
            //    }
            //    else if (b == "5")
            //    {
            //        Console.Clear();
            //        ShowOptions();
            //    }
            //    else
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Bitte geben Sie eine der Möglichkeiten an");
            //        ShowOptions();
            //        continue;
            //    }
            //}





            //AB HIER DIE METHODEN TESTEN



            //BinSearchTree Test
            Console.WriteLine("\n\n--------BinTree--------");
            BinSearchTree testTree = new BinSearchTree();
            testTree.Insert(9);
            testTree.Insert(4);
            testTree.Insert(10);
            testTree.Insert(2);

            testTree.Print();
        }
        public static void ShowOptions()
        {
            Console.WriteLine("1. Print array\n" +
                "2. Search element\n" +
                "3. Insert element\n" +
                "4. Delete element\n" +
                "5. Clear console");
        }
    }
}

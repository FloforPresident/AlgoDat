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
            //Haupt Bibliotheksprogramm
            //bool libraryRuns = true;
            //while(libraryRuns)
            //{
            //    Console.WriteLine("1. Multiset unsorted Array");
            //    Console.WriteLine("2. Set unsorted Array\n");

            //    Console.Write("Wählen Sie einen Bibliothekstyp aus: ");
            //    string a = Console.ReadLine();
            //    if(a == "1")
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Sie haben sich für ein Multiset unsorted Array entschieden");
            //        MultiSetUnsortedArray myArray = new MultiSetUnsortedArray();

            //        Console.WriteLine("1. Print array");
            //        Console.WriteLine("2. Search element");
            //        Console.WriteLine("3. Insert element");
            //        Console.WriteLine("4. Delete element");
            //        Console.WriteLine("5. Clear console");
            //        bool optionsRun = true;
            //        while (optionsRun)
            //        {
            //            Console.Write("Wählen Sie eine Option für Ihr Array aus: ");
            //            string b = Console.ReadLine();

            //            if (b == "1")
            //            {
            //                myArray.Print();
            //            }
            //            else if (b == "2")
            //            {
            //                int c = Convert.ToInt32(Console.ReadLine());
            //                myArray.Search(c);
            //            }
            //            else if (b == "3")
            //            {
            //                int c = Convert.ToInt32(Console.ReadLine());
            //                myArray.Insert(c);
            //            }
            //            else if (b == "4")
            //            {
            //                int c = Convert.ToInt32(Console.ReadLine());
            //                myArray.Delete(c);
            //            }
            //            else if (b == "5")
            //            {
            //                Console.Clear();
            //                Console.WriteLine("1. Print array");
            //                Console.WriteLine("2. Search element");
            //                Console.WriteLine("3. Insert element");
            //                Console.WriteLine("4. Delete element");
            //                Console.WriteLine("5. Clear console");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Bitte geben Sie eine der Möglichkeiten an");
            //                Console.Clear();
            //                continue;
            //            }
            //        }
            //    }
            //    else if(a == "2")
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Sie haben sich für ein Set unsorted Array entschieden");
            //        SetUnsortedArray myArray = new SetUnsortedArray();

            //        Console.WriteLine("1. Print array");
            //        Console.WriteLine("2. Search element");
            //        Console.WriteLine("3. Insert element");
            //        Console.WriteLine("4. Delete element");
            //        Console.WriteLine("5. Clear console");
            //        bool optionsRun = true;
            //        while (optionsRun)
            //        {
            //            Console.Write("Wählen Sie eine Option für Ihr Array aus: ");
            //            string b = Console.ReadLine();

            //            if (b == "1")
            //            {
            //                myArray.Print();
            //            }
            //            else if (b == "2")
            //            {
            //                int c = Convert.ToInt32(Console.ReadLine());
            //                myArray.Search(c);
            //            }
            //            else if (b == "3")
            //            {
            //                int c = Convert.ToInt32(Console.ReadLine());
            //                myArray.Insert(c);
            //            }
            //            else if (b == "4")
            //            {
            //                int c = Convert.ToInt32(Console.ReadLine());
            //                myArray.Delete(c);
            //            }
            //            else if (b == "5")
            //            {
            //                Console.Clear();
            //                Console.WriteLine("1. Print array");
            //                Console.WriteLine("2. Search element");
            //                Console.WriteLine("3. Insert element");
            //                Console.WriteLine("4. Delete element");
            //                Console.WriteLine("5. Clear console");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Bitte geben Sie eine der Möglichkeiten an");
            //                Console.Clear();
            //                continue;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Bitte geben Sie eine der Möglichkeiten an");
            //        Console.Clear();
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
            Console.WriteLine(testTree.Search(1));
        }
    }
}

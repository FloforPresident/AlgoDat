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
            IDictonary myArray = null;
            
            //which kind of array
            bool libraryRuns = true;

            Console.WriteLine("\n---- MULTISET UNSORTED ----" +
                "\n1. Multiset unsorted list\n" +
                "2. Multiset unsorted array\n" +
                "\n------ SET UNSORTED -------\n" +
                "3. Set unsorted list\n" +
                "4. Set unsorted array\n" +
                "\n----- MULTISET SORTED -----\n" +
                "5. Set sorted list\n" +
                "6. Multiset sorted array\n" + 
                "\n-------- SET SORTED --------\n" +
                "6. Set sorted list\n" +
                "8. Set sorted array\n" +
                "");
            while (libraryRuns)
            {
                Console.WriteLine("Wählen Sie die Art Ihres Wörterbuchs aus:\n");
                string a = Console.ReadLine();
                if (a == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Sie haben sich für ein Multiset unsorted Array entschieden");
                    myArray = new MultiSetUnsortedArray();
                    libraryRuns = false;
                }
                else if (a == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Sie haben sich für ein Set unsorted Array entschieden");
                    myArray = new SetUnsortedArray();
                    libraryRuns = false;
                }
                else if (a == "6")
                {
                    Console.Clear();
                    Console.WriteLine("Sie haben sich für ein Multiset sorted Array entschieden");
                    myArray = new MultiSetSortedArray();
                    libraryRuns = false;
                }
                else if (a == "8")
                {
                    Console.Clear();
                    Console.WriteLine("Sie haben sich für ein Set sorted Array entschieden");
                    myArray = new SetSortedArray();
                    libraryRuns = false;
                }
                else
                {
                    Console.WriteLine("Bitte geben Sie eine der Möglichkeiten an");
                    continue;
                }
            }

            //what to do with array
            ShowOptions();
            bool optionsRun = true;
            while (optionsRun)
            {
                Console.Write("\nWählen Sie eine Option für Ihr Array aus: ");
                string b = Console.ReadLine();

                try
                {
                    if (b == "1")
                    {
                        Console.Write("\nPrint Array: ");
                        myArray.Print();
                    }
                    else if (b == "2")
                    {
                        Console.WriteLine("\nSearch Element: ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        myArray.Search(c);
                    }
                    else if (b == "3")
                    {
                        Console.WriteLine("\nInsert Element: ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        myArray.Insert(c);
                    }
                    else if (b == "4")
                    {
                        Console.WriteLine("\nDelete Element: ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        myArray.Delete(c);
                    }
                    else if (b == "5")
                    {
                        Console.Clear();
                        ShowOptions();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Bitte geben Sie eine der Möglichkeiten an");
                        ShowOptions();
                        continue;
                    }

            }
                catch
            {
                Console.WriteLine("Eingabe muss ein Integer sein");
            }
        }





            //AB HIER DIE METHODEN TESTEN



            //BinSearchTree Test
            //S = {2, 3, 10, 11, 12, 25, 56, 67, 98}
            //25, 98, 10, 56, 10, 11, 67, 2, 12, 25, 3
            Console.WriteLine("\n\n--------BinTree--------");
            BinSearchTree testTree = new BinSearchTree();
            testTree.Insert(25);
            testTree.Insert(98);
            testTree.Insert(10);
            testTree.Insert(56);
            testTree.Insert(10);
            testTree.Insert(11);
            testTree.Insert(67);
            testTree.Insert(2);
            testTree.Insert(12);
            testTree.Insert(25);
            testTree.Insert(3);

            //Console.WriteLine(testTree.Delete(12)); 
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

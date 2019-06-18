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
                "5. Multiset sorted list\n" +
                "6. Multiset sorted array\n" +
                "\n-------- SET SORTED --------\n" +
                "7. Set sorted list\n" +
                "8. Set sorted array\n" +
                "\n------------ TREE -----------\n" +
                "9. Bin tree\n" +
                "10. AVL tree\n" +
                "11. Treap\n" + 
                "\n----------- HASHING ---------\n" +
                "12. Quadratisch sondiertes Hasharray\n" +
                "13. Seperat verkettete Liste\n" +
                "");
            while (libraryRuns)
            {
                Console.WriteLine("Wählen Sie die Art Ihres Wörterbuchs aus:\n");
                string a = Console.ReadLine();
                if (a == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Sie haben sich für eine multiset unsorted list entschieden");
                    myArray = new MultiSetUnsortedLinkedList();
                    libraryRuns = false;
                }
                if (a == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Sie haben sich für ein multiset unsorted Array entschieden");
                    myArray = new MultiSetUnsortedArray();
                    libraryRuns = false;
                }
                if (a == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Sie haben sich für eine set unsorted list entschieden");
                    myArray = new SetUnsortedLinkedList();
                    libraryRuns = false;
                }
                else if (a == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Sie haben sich für ein set unsorted Array entschieden");
                    myArray = new SetUnsortedArray();
                    libraryRuns = false;
                }
                else if (a == "5")
                {
                    Console.Clear();
                    Console.WriteLine("Sie haben sich für eine multiset sorted list entschieden");
                    myArray = new MultiSetSortedList();
                    libraryRuns = false;
                }
                else if (a == "6")
                {
                    Console.Clear();
                    Console.WriteLine("Sie haben sich für ein multiset sorted Array entschieden");
                    myArray = new MultiSetSortedArray();
                    libraryRuns = false;
                }
                else if (a == "7")
                {
                    Console.Clear();
                    Console.WriteLine("Sie haben sich für eine set sorted list entschieden");
                    myArray = new SetSortedLinkedList();
                    libraryRuns = false;
                }
                else if (a == "8")
                {
                    Console.Clear();
                    Console.WriteLine("Sie haben sich für ein Set sorted Array entschieden");
                    myArray = new SetSortedArray();
                    libraryRuns = false;
                }
                else if (a == "9")
                {
                    Console.Clear();
                    Console.WriteLine("Sie haben sich für einen bin search tree entschieden");
                    myArray = new BinSearchTree();
                    libraryRuns = false;
                }
                else if (a == "10")
                {
                    Console.Clear();
                    Console.WriteLine("Sie haben sich für einen AVL tree entschieden");
                    myArray = new AVLTree();
                    libraryRuns = false;
                }
                else if (a == "11")
                {
                    Console.Clear();
                    Console.WriteLine("Sie haben sich für einen Treap entschieden");
                    myArray = new Treap();
                    libraryRuns = false;
                }
                else if (a == "12")
                {
                    Console.Clear();
                    Console.WriteLine("Sie haben sich für ein quadratisch sondiertes Array entschieden");
                    myArray = new HashTabQuadProb();
                    libraryRuns = false;
                }
                else if (a == "13")
                {
                    Console.Clear();
                    Console.WriteLine("Sie haben sich für eine seperat verkettete Liste entschieden");
                    myArray = new HashTabSepChain();
                    libraryRuns = false;
                }
                else
                {
                    continue;
                }
            }

            //what to do with array
            ShowOptions(myArray);
            bool optionsRun = true;
            while (optionsRun)
            {
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
                        ShowOptions(myArray);
                    }
                    else if (b == "Q" || b == "q")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                        ShowOptions(myArray);
                        continue;
                    }

                }
                catch(Exception e)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
        }
       





            //AB HIER DIE METHODEN TESTEN



            //BinSearchTree Test
            //S = { 2, 3, 10, 11, 12, 25, 56, 67, 98}
            //25, 98, 10, 56, 10, 11, 67, 2, 12, 25, 3
            //Console.WriteLine("\n\n--------BinTree--------");
            //BinSearchTree testTree = new BinSearchTree();
            //testTree.Insert(25);
            //testTree.Insert(98);
            //testTree.Insert(10);
            //testTree.Insert(56);
            //testTree.Insert(10);
            //testTree.Insert(11);
            //testTree.Insert(67);
            //testTree.Insert(54);
            //testTree.Insert(2);
            //testTree.Insert(12);
            //testTree.Insert(25);
            //testTree.Insert(3);

            //Console.WriteLine(testTree.Delete(98));
            //testTree.Print();

            //Console.WriteLine("\n\n--------AVLTree--------");
            //AVLTree avlTree = new AVLTree();
            //avlTree.Insert(63);
            //avlTree.Insert(34);
            //avlTree.Insert(2);
            ////avlTree.Insert(14);
            ////avlTree.Insert(54);
            ////avlTree.Insert(50);
            ////avlTree.Insert(69);
            //////avlTree.Insert(67);
            //////avlTree.Insert(68);
            //////avlTree.Insert(21);

            //avlTree.Print();


            //Multi Set Sorted Arrays Test
            //myArray = new MultiSetSortedArray();
            //libraryRuns = false;

            //Console.WriteLine("=====================");
            //Console.WriteLine("======einfügen======");
            //Console.WriteLine("=====================");

            //Console.WriteLine("");
            //Console.WriteLine("=4=======================");
            //myArray.Insert(4);
            //myArray.Print();

            //Console.WriteLine("");
            //Console.WriteLine("=4=======================");
            //myArray.Insert(4);
            //myArray.Print();

            //Console.WriteLine("");
            //Console.WriteLine("=0=======================");
            //myArray.Insert(0);
            //myArray.Print();


            //Console.WriteLine("");
            //Console.WriteLine("=2=======================");
            //myArray.Insert(2);
            //myArray.Print();

            //Console.WriteLine("");
            //Console.WriteLine("=12======================");
            //myArray.Insert(12);
            //myArray.Print();

            //Console.WriteLine("");
            //Console.WriteLine("=8=======================");
            //myArray.Insert(8);
            //myArray.Print();

            //Console.WriteLine("");
            //Console.WriteLine("=9=======================");
            //myArray.Insert(9);
            //myArray.Print();

            //Console.WriteLine("");
            //Console.WriteLine("=10=======================");
            //myArray.Insert(10);
            //myArray.Print();

            //Console.WriteLine("");
            //Console.WriteLine("=12======================");
            //myArray.Insert(12);
            //myArray.Print();

            //Console.WriteLine("");
            //Console.WriteLine("=10=======================");
            //myArray.Insert(10);
            //myArray.Print();

            //Console.WriteLine("");
            //Console.WriteLine("=8=======================");
            //myArray.Insert(8);
            //myArray.Print();

            //Console.WriteLine("");
            //Console.WriteLine("=15======================");
            //myArray.Insert(15);
            //myArray.Print();

            //Console.WriteLine("");
            //Console.WriteLine("=3======================");
            //myArray.Insert(3);
            //myArray.Print();

            //Console.WriteLine("");
            //Console.WriteLine("=20======================");
            //myArray.Insert(20);
            //myArray.Print();

            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("=====================");
            //Console.WriteLine("======suchen======");
            //Console.WriteLine("=====================");
            //Console.WriteLine("");

            //Console.WriteLine("=12======================");
            //myArray.Search(12);

            //Console.WriteLine("");
            //Console.WriteLine("=8======================");
            //myArray.Search(8);

            //Console.WriteLine("");
            //Console.WriteLine("=15======================");
            //myArray.Search(15);

            //Console.WriteLine("");
            //Console.WriteLine("=10======================");
            //myArray.Search(10);

            //Console.WriteLine("");
            //Console.WriteLine("=3======================");
            //myArray.Search(3);

            //Console.WriteLine("");
            //Console.WriteLine("=20======================");
            //myArray.Search(20);

            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("=====================");
            //Console.WriteLine("======löschen======");
            //Console.WriteLine("=====================");
            //Console.WriteLine("");

            //Console.WriteLine("=8======================");
            //myArray.Delete(8);
            //myArray.Print();

            //Console.WriteLine("");
            //Console.WriteLine("=8======================");
            //myArray.Delete(8);
            //myArray.Print();

            //Console.WriteLine("");
            //Console.WriteLine("=3======================");
            //myArray.Delete(3);
            //myArray.Print();

            //Console.WriteLine("");
            //Console.WriteLine("=15======================");
            //myArray.Delete(15);
            //myArray.Print();

            //Console.WriteLine("");
            //Console.WriteLine("=4======================");
            //myArray.Delete(4);
            //myArray.Print();

            //Console.WriteLine("");
            //Console.WriteLine("=12======================");
            //myArray.Delete(12);
            //myArray.Print();

            //Console.WriteLine("");
            //Console.WriteLine("=20======================");
            //myArray.Delete(20);
            //myArray.Print();



            //Set Sorted Arrays Test
            //myArray = new SetSortedArray();
            //libraryRuns = false;

            //Console.WriteLine("=====================");
            //Console.WriteLine("======einfügen======");
            //Console.WriteLine("=====================");
            //Console.WriteLine("");

            //Console.WriteLine("=4=======================");
            //myArray.Insert(4);
            //myArray.Print();
            //Console.WriteLine("");

            //Console.WriteLine("=2=======================");
            //myArray.Insert(2);
            //myArray.Print();
            //Console.WriteLine("");

            //Console.WriteLine("=12======================");
            //myArray.Insert(12);
            //myArray.Print();
            //Console.WriteLine("");

            //Console.WriteLine("=8=======================");
            //myArray.Insert(8);
            //myArray.Print();
            //Console.WriteLine("");

            //Console.WriteLine("=12======================");
            //myArray.Insert(12);
            //myArray.Print();
            //Console.WriteLine("");

            //Console.WriteLine("=8=======================");
            //myArray.Insert(8);
            //myArray.Print();
            //Console.WriteLine("");

            //Console.WriteLine("=10======================");
            //myArray.Insert(10);
            //myArray.Print();
            //Console.WriteLine("");

            //Console.WriteLine("=15======================");
            //myArray.Insert(15);
            //myArray.Print();

            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("=====================");
            //Console.WriteLine("======suchen======");
            //Console.WriteLine("=====================");
            //Console.WriteLine("");

            //Console.WriteLine("=12======================");
            //myArray.Search(12);
            //Console.WriteLine("");

            //Console.WriteLine("=8======================");
            //myArray.Search(8);
            //Console.WriteLine("");

            //Console.WriteLine("=15======================");
            //myArray.Search(15);
            //Console.WriteLine("");

            //Console.WriteLine("=10======================");
            //myArray.Search(10);
            //Console.WriteLine("");

            //Console.WriteLine("=3======================");
            //myArray.Search(3);
            //Console.WriteLine("");

            //Console.WriteLine("=20======================");
            //myArray.Search(20);

            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("=====================");
            //Console.WriteLine("======löschen======");
            //Console.WriteLine("=====================");
            //Console.WriteLine("");

            //Console.WriteLine("=8======================");
            //myArray.Delete(8);
            //myArray.Print();
            //Console.WriteLine("");

            //Console.WriteLine("=3======================");
            //myArray.Delete(3);
            //myArray.Print();
            //Console.WriteLine("");

            //Console.WriteLine("=15======================");
            //myArray.Delete(15);
            //myArray.Print();
            //Console.WriteLine("");

            //Console.WriteLine("=4======================");
            //myArray.Delete(4);
            //myArray.Print();

            //Console.ReadLine();

            //Console.WriteLine("\n\n--------TreapTest--------");
            //Treap testtreap = new Treap();

            //Console.WriteLine("==Insert===============");
            //Console.WriteLine("==4===============");
            //testtreap.Insert(4);

            //Console.WriteLine();
            //Console.WriteLine("==3===============");
            //testtreap.Insert(3);

            //Console.WriteLine();
            //Console.WriteLine("==7===============");
            //testtreap.Insert(7);

            //Console.WriteLine();
            //Console.WriteLine("==20===============");
            //testtreap.Insert(20);

            //Console.WriteLine();
            //Console.WriteLine("==5===============");
            //testtreap.Insert(5);

            //Console.WriteLine();
            //Console.WriteLine("==18===============");
            //testtreap.Insert(18);

            //Console.WriteLine();
            //Console.WriteLine("==2===============");
            //testtreap.Insert(2);

            //Console.WriteLine();
            //Console.WriteLine("==2===============");
            //testtreap.Insert(2);

            //Console.WriteLine();
            //Console.WriteLine("==Delete===============");
            //Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("==2===============");
            //testtreap.Delete(2);

            //Console.WriteLine();
            //Console.WriteLine("==30===============");
            //testtreap.Delete(30);

            //Console.WriteLine();
            //Console.WriteLine("==7===============");
            //testtreap.Delete(7);

            //testtreap.Print();
            //Console.WriteLine();
            //Console.WriteLine();

            //testtreap.Print();





        }
        public static void ShowOptions(object a)
        {
            Console.WriteLine(a + "\n");

            Console.WriteLine("1. Print array\n" +
                "2. Search element\n" +
                "3. Insert element\n" +
                "4. Delete element\n" +
                "PRESS ENTER TO Clear console\n" + 
                "Q TO QUIT");
            Console.Write("\nWählen Sie eine Option für Ihr Array aus: ");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class MultiSetSortedArray : SupportArray, IMultiSetSorted
    {
        protected int searchindex;

        //protected int SearchIndex(int elem)
        //{
        //    for (int i = 0; i < myArray.Length; i++)
        //    {
        //        if (myArray[i] == elem)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}
        public override bool Search(int elem)
        {
            int min = 0;
            int max = myArray.GetLength(0)-1;
            //int guess = (min + max) / 2;

            while (min<=max)
            {
                int guess = (min + max) / 2;
                if (myArray[guess] == elem)
                {
                    searchindex = guess;
                    Console.WriteLine("gefunden");
                    return true;
                }
                if (elem < myArray[guess])
                {
                    max = guess - 1;
                }
                else
                {
                    min = guess + 1;
                }
            }
            searchindex = -1;
            Console.WriteLine("nicht gefunden");
            return false;

            //while (myArray[guess] != elem)
            //{
            //    if (min > max)
            //    {
            //        searchindex = -1;
            //        Console.WriteLine("nicht gefunden");
            //        return false;
            //    }
            //    guess = (max + min) / 2;

            //    if (myArray[guess] < elem)
            //    {
            //        min = guess + 1;
            //    }
            //    else
            //    {
            //        max = guess - 1;
            //    }
            //}
            //searchindex = guess;
            //Console.WriteLine("gefunden");
            //return true;
        }

        public override bool Insert(int elem)
        {
            Search(elem);
            

            if (searchindex != -1)//Element existiert schon einmal
            {
                for (int j = myArray.Length-1; j > searchindex; j--)
                {
                    myArray[j] = myArray[j - 1];
                }
                myArray[searchindex + 1] = elem;
                Console.WriteLine("eingefügt");
                return true;
            }
            else //Element existiert noch nicht
            {
                int pos = 0;
                int current = myArray[pos];
                int next = myArray[pos + 1];

                if (elem < current || myArray[pos] == 0) //Objekt wird an erster Stelle eingefügt
                {
                    for (int j = myArray.Length-1; j > 0; j--)
                    {
                        myArray[j] = myArray[j - 1];
                    }
                    myArray[0] = elem;

                    Console.WriteLine("eingefügt");
                    return true;
                }
                else if (elem > current) //Objekt wird mittendrin eingefügt
                {
                    for (int k = 0; k < myArray.Length-1; k++) //Array durchlaufen
                    {
                        if ((elem > myArray[k] && elem < myArray[k + 1]) || (elem > myArray[k] && myArray[k + 1] == 0)) //falls elem zwischen aktuellem und nächstem Wert ist oder falls elem an letzter Stelle eingefügt werden soll
                        {
                            for (int j = myArray.Length-1; j > k; j--) //Alle Werte rechts von kleinerem Wert nach rechts verschieben
                            {
                                myArray[j] = myArray[j - 1];
                                pos = j;
                            }
                            break;
                        }
                    }
                    myArray[pos] = elem; //Elem auf Stelle des größeren Wertes setzen
                    Console.WriteLine("eingefügt");
                    return true;
                }
            }
            Console.WriteLine("irgendwas passt nicht");
            return false;
        }

        public override bool Delete(int elem)
        {
            Search(elem);
            if (!Search(elem)) //Element ist im Array nicht vorhanden
            {
                Console.WriteLine("Element nicht vorhanden");
                return false;
            }
            else
            {
                for (int j = searchindex; j < myArray.GetLength(0); j++)
                {
                    myArray[j] = myArray[j - 1]; //alle Elemente rechts von i werden um eins nach links verschoben
                }
                Console.WriteLine("Element entfernt");
                return true;
            }
        }
    }
}

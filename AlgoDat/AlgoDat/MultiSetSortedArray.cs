using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class MultiSetSortedArray : SupportArray, IMultiSetSorted
    {
        int i = 0;
        public override bool Search(int elem)
        {
            int min = 0;
            int max = myArray.GetLength(0) - 1;
            int guess = max / 2;

            while (myArray[guess] != elem)
            {
                if (myArray[guess] < elem)
                {
                    min = guess + 1;
                }
                else
                {
                    max = guess - 1;
                }
                guess = (max + min) / 2;

                if (min > max)
                {
                    Console.WriteLine("nicht gefunden");
                    return false;
                }
                i++;
            }
            Console.WriteLine("gefunden");
            return true;
        }

        public override bool Insert(int elem)
        {
            if (Search(elem))//Element existiert schon einmal
            {
                for (int j = myArray.GetLength(0); j > i; j--)
                {
                    myArray[j] = myArray[j - 1];
                }
                myArray[i] = elem;
                return true;
            }
            else //Element existiert noch nicht
            {
                int pos = 0;
                int current = myArray[pos];
                int next = myArray[pos + 1];

                if (elem < current) //Objekt wird an erster Stelle eingefügt
                {
                    for (int j = myArray.GetLength(0); j > 1; j--)
                    {
                        myArray[j] = myArray[j - 1];
                    }
                    myArray[0] = elem;

                    Console.WriteLine("eingefügt");
                    return true;
                }
                else if (elem > current) //Objekt wird mittendrin eingefügt
                {
                    for (int i = 0; i < myArray.GetLength(0); i++) //Array durchlaufen
                    {
                        if (elem > myArray[i] && elem < myArray[i + 1]) //falls elem zwischen aktuellem und nächstem Wert ist
                        {
                            for (int j = myArray.GetLength(0); j > i; j--) //Alle Werte rechts von kleinerem Wert nach rechts verschieben
                            {
                                myArray[j] = myArray[j - 1];
                            }
                            break;
                        }
                    }
                    myArray[i + 1] = elem; //Elem auf Stelle des größeren Wertes setzen
                    Console.WriteLine("eingefügt");
                    return true;
                }
            }
            Console.WriteLine("irgendwas passt nicht");
            return false;
        }

        public override bool Delete(int elem)
        {
            if (!Search(elem)) //Element ist im Array nicht vorhanden
            {
                Console.WriteLine("Element nicht vorhanden");
                return false;
            }
            else
            {
                for (int j = i; j < myArray.GetLength(0); j++)
                {
                    myArray[j] = myArray[j - 1]; //alle Elemente rechts von i werden um eins nach links verschoben
                }
                Console.WriteLine("Element entfernt");
                return true;
            }
        }
    }
}

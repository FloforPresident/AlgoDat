using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class SetSortedArray : MultiSetSortedArray, ISetSorted
    {
        //protected int searchindex;

        public override bool Insert(int elem)
        {
            Search(elem);

            if (searchindex != -1)//Element existiert schon einmal
            {
                Console.WriteLine("Element existiert bereits!");
                return false;
            }
            else //Element existiert noch nicht
            {
                int pos = 0;
                int current = myArray[pos];
                int next = myArray[pos + 1];

                if (elem < current || myArray[pos] == 0) //Objekt wird an erster Stelle eingefügt
                {
                    for (int j = myArray.Length - 1; j > 0; j--)
                    {
                        myArray[j] = myArray[j - 1];
                    }
                    myArray[0] = elem;

                    Console.WriteLine("eingefügt");
                    return true;
                }
                else if (elem > current) //Objekt wird mittendrin eingefügt
                {
                    for (int k = 0; k < myArray.Length - 1; k++) //Array durchlaufen
                    {
                        if ((elem > myArray[k] && elem < myArray[k + 1]) || (elem > myArray[k] && myArray[k + 1] == 0)) //falls elem zwischen aktuellem und nächstem Wert ist oder falls elem an letzter Stelle eingefügt werden soll
                        {
                            for (int j = myArray.Length - 1; j > k; j--) //Alle Werte rechts von kleinerem Wert nach rechts verschieben
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


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class SetSortedArray : MultiSetSortedArray, ISetSorted
    {
            int i = 0;

        public override bool Insert(int elem)
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
            Console.WriteLine("irgendwas passt nicht");
            return false;
        }
    }
}

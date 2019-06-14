using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    abstract public class SupportList
    {
        protected class LElement
        {
            public int element;
            public LElement next;
            public LElement(int element)
            {
                this.element = element;
                next = null;
            }
        }
        protected LElement root, prev;

        public bool Delete(int elem)
        {
            if (Search(elem) == true)
            {
                _search_(elem);

                if (prev == null)
                {
                    root = root.next;
                    return true;
                }
                else
                {
                    prev.next = prev.next.next;
                    return true;
                }
            }
            return false;
        }

        public bool Search(int elem)
        {
            LElement current = root;
            while (current != null)
            {
                if (current.element == elem)
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }

        protected void _search_(int elem)
        {
            prev = null;
            LElement current = root;
            if (Search(elem) == true) // wenn element in Liste existiert
            {
                if (elem == root.element)
                {
                }
                else
                {
                    while (current != null) // wenn element nicht am anfang
                    {
                        if (current.next.element == elem)
                        {
                            prev = current;
                            break;
                        }
                        current = current.next;
                    }
                }
            }
            else // wenn element nicht in Liste ( für sorte liste)
            {
                if (root == null)
                {
                }
                else
                {
                    if (root.element < current.element) //falls kleiner als root
                    {
                    }
                    else
                    {
                        while (current != null) //
                        {

                            if (current.next == null || current.next.element > elem)
                            {
                                prev = current;
                                break;
                            }
                            current = current.next;
                        }
                    }
                }
            }
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine();
            LElement current = root;
            if (current == null)
            {
                Console.WriteLine(" Liste ist leer ");
                return;
            }
            while (current.next != null)
            {
                Console.Write(" " + current.element + ",");
                current = current.next;
            }
            Console.WriteLine(" "+ current.element);
        }
    }
}

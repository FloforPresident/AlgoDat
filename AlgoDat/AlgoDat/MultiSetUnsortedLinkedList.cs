using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class MultiSetUnsortedLinkedList : SupportList, IMultiSet
    {
        class LElement
        {
            public int element;
            public LElement next;
            public LElement(int elem)
            {
                this.element = elem;
                next = null;
            }
        }
        LElement root;
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

        public bool Insert(int elem)
        {
            if (root == null)
            {
                root = new LElement(elem);
            }
            else
            {
                LElement current = root;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new LElement(elem);
            }
            return false;
        }

        public bool Delete(int elem)
        {
            if (Search(elem) == true)
            {
                LElement current = root;
                LElement previous = null;

                while (current.next != null && elem != current.element)
                {
                    previous = current;
                    current = current.next;
                }
                if (current.element == root.element)
                {
                    root = root.next;
                }
                else
                {
                    previous.next = current.next;
                }
                return true;
            }
            return false;
        }

        public void Print()
        {
            LElement current = root;
            if (current == null)
            {
                Console.WriteLine(" Liste ist leer ");
                return;
            }
            while (current.next != null)
            {
                Console.WriteLine(current.element);
                current = current.next;
            }
            Console.WriteLine(current.element);
        }
    }
}

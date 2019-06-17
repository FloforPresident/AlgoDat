using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class SetUnsortedLinkedList : MultiSetUnsortedLinkedList, ISet 
    {
        
        public new bool Insert(int elem)
        {
            if (!Search_Help(elem))
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
                return true;
            }
            return false;
        }
        
        
    }
}

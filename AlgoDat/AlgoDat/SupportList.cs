using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    abstract public class SupportList
    {
        class LElement
        {
            public int element;
            public LElement next;
            public LElement(int element)
            {
                this.element = element;
                next = null;
            }
        }
        LElement root;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    interface IDictonary
    {
        bool Search(int elem);
        bool insert(int elem);
        bool delete(int elem);
        void print();
    }
}

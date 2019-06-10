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
        bool Insert(int elem);
        bool Delete(int elem);
        void Print(int elem);
    }
}

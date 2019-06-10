using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    interface ISet : IMultiSet
    {
        new bool Insert(int elem);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class HashTabQuadProb 
    {
        int[] thisArray;
        int value;
        public HashTabQuadProb(int[] thisArray, int value)
        {
            this.thisArray = thisArray;
            this.value = value;
        }
        public int getHashIndex()
        {
            int trials = 0;
            while(trials < 10000)
            {
                int index = ((4 * value + 3)+trials*trials) % thisArray.Length;
                if(thisArray[index] == 0)
                {
                    return index;
                }
                if(trials == 0)
                {
                    trials++;
                }
                else if(trials > 0)
                {
                    trials *= -1;
                }
                else
                {
                    trials *= -1;
                    trials++;
                }
            }
            return -1;
        }
    }
}

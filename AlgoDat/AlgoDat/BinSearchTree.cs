using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class BinSearchTree : ISetSorted
    {
        private class Blatt
        {
            public Blatt links;
            public Blatt rechts;
            public int wert;

            public Blatt(int wert)
            {
                this.wert = wert;
            }
        }
        Blatt wurzel;


        /***********************/
        /********SEARCH*********/
        /***********************/
        public bool Search(int elem) {
            if (wurzel == null)
                return false;
            else
            {
                Blatt index = wurzel;
                while(index != null)
                {
                    if (index.wert > elem)
                        index = index.links;
                    else if (index.wert < elem)
                        index = index.rechts;
                    else
                        return true; //index.wert == elem => gefunden
                }
                return false; //komplett durch und index == null => nicht gefunden
            }
        }

        /***********************/
        /********INSERT*********/
        /***********************/
        public bool Insert(int elem)
        {
            if(wurzel == null)
            {
                wurzel = new Blatt(elem);
            }
            else
            {
                Insert(wurzel, elem);
            }
            return true;
        }
        private void Insert(Blatt parent, int elem)
        {
            while(parent != null)
            {
                if(parent.wert > elem)
                {
                    if (parent.links == null)
                    {
                        parent.links = new Blatt(elem);
                        return;
                    }
                    else
                        parent = parent.links;
                }
                else if (parent.wert < elem)
                {
                    if (parent.rechts == null)
                    {
                        parent.rechts = new Blatt(elem);
                        return;
                    }
                    else
                        parent = parent.rechts;
                }
            }
        }
        public bool Delete(int elem) { return false; }
        public void Print() { }
    }
}

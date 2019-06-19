using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class HashTabSepChain :ISet
    {
        class HashNode
        {
            int key;
            HashNode next;
            public HashNode(int key)
            {
                this.key = key;
                next = null;
            }
            public int GetKey()
            {
                return key;
            }
            public void SetNextNode(HashNode obj)
            {
                next = obj;
            }
            public HashNode GetNextNode()
            {
                return this.next;
            }
        }

        HashNode[] table;
        const int size = 10;

        public HashTabSepChain()
        {
            table = new HashNode[size];
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = null;
            }
        }
        public bool Insert(int key)
        {
            if (Search_Help(key))
            {
                Console.WriteLine("Wert existiert schon!");
                return false;
            }

            HashNode nObj = new HashNode(key);
            int hash = Hash(key);
            if (table[hash] != null)
            {
                nObj.SetNextNode(table[hash]);
            }
            table[hash] = nObj;
            Console.WriteLine("Wert wurde eingetragen!");
            return true;
        }
        public bool Search(int key)
        {
            int hash = Hash(key);
            HashNode current = table[hash];
            if (current == null)
            {
                Console.WriteLine("Wert wurde nicht gefunden!");
                return false;
            }
            while (current.GetKey() != key && current.GetNextNode() != null)
            {
                current = current.GetNextNode();
            }
            if (current.GetKey() == key)
            {
                Console.WriteLine("Wert wurde gefunden!");
                return true;
            }
            else
            {
                return false; 
            }
            
        }
        public bool Search_Help(int key)
        {
            int hash = Hash(key);
            HashNode current = table[hash];
            if (current == null)
            {
                return false;
            }
            while (current.GetKey() != key && current.GetNextNode() != null)
            {
                current = current.GetNextNode();
            }
            return (current.GetKey() == key);
          

        }
        public bool Delete(int key)
        {
            if (!Search(key))
                return false;

            int hash = Hash(key);
            bool isRemoved = false;

            if (table[hash].GetKey() == key)
            {
                table[hash] = table[hash].GetNextNode();
                isRemoved = true;
            }
            else
            {
                HashNode current = table[hash];
                while (current != null)
                {
                    if (current.GetNextNode() != null)
                    {
                        if (current.GetNextNode().GetKey() == key)
                        {
                            HashNode newNext = current.GetNextNode().GetNextNode();
                            current.SetNextNode(newNext);
                            isRemoved = true;
                            break;
                        }
                        else
                        {
                            current = current.GetNextNode();
                        }
                    }

                }
            }
            if (!isRemoved)
            {
                return false;
            }
            return true;
        }
        public void Print()
        {
            HashNode current = null;
            for (int i = 0; i < table.Length; i++)
            {
                current = table[i];
                while (current != null)
                {
                    Console.Write(current.GetKey() + " ");
                    current = current.GetNextNode();
                }
                Console.WriteLine();
            }
        }
        private int Hash(int value)
        {
            return value % size;
        }
    }
}

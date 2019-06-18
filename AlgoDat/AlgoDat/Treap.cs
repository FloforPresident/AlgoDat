using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
    class Treap : BinSearchTree
    {
        public static string type;
        public override bool Insert(int elem)
        {
            Node pointer = current;

            if (root == null) //Baum existiert noch nicht
            {
                base.Insert(elem); //Insert als Blatt wie bei BinSearchTree
                return true; //Neues Element ist Wurzel
            }
            else
            {
                base.Insert(elem); //Insert als Blatt wie bei BinSearchTree
            }
            Heapbedingung(current);

            return false;
        }

        private void Heapbedingung(Node n)
        {
            if (n != null)
            {
                while (n.parent != null && n != null && n.parent.prio > n.prio)
                {
                    if (n.value < n.parent.value) //ist linkes Kind
                    {
                        RightRotation(n); //rotiere rechts(n.Parent)
                    }
                    else //ist rechtes Kind
                    {
                        LeftRotation(n); //rotiere links(n.Parent)
                    }
                }
            }
        }

        public void LeftRotation(Node n)
        {
            Node temp;
            if (n != null)
            {
                if (n.parent == root) //Mutterwurzel ist root
                {
                    temp = n.left;
                    root = n;
                    root.left = n.parent;
                    n.parent = null;
                    root.left.parent = root;
                    root.left.right = temp;
                    if (temp != null)
                    {
                        root.left.right.parent = root.left;
                    }
                }
                else
                {
                    temp = n.left;
                    n.left = n.parent;
                    n.parent = n.parent.parent;
                    if (n.value < n.parent.value)
                        n.parent.left = n;
                    else
                        n.parent.right = n;
                    n.left.parent = n;
                    n.left.right = temp;
                    if (temp != null)
                    {
                        n.left.right.parent = n.left;
                    }
                }
            }
        }

        public void RightRotation(Node n)
        {
            Node temp;
            if (n != null)
            {
                if (n.parent == root) //Mutterwurzel ist root
                {
                    temp = n.right;
                    root = n;
                    root.right = n.parent;
                    n.parent = null;
                    root.right.parent = root;
                    root.right.left = temp;
                    if (temp != null)
                    {
                        root.right.left.parent = root.right;
                    }
                }
                else
                {
                    temp = n.right;
                    n.right = n.parent;
                    n.parent = n.parent.parent;
                    if (n.value < n.parent.value)
                        n.parent.left = n;
                    else
                        n.parent.right = n;
                    n.right.parent = n;
                    n.right.left = temp;
                    if (temp != null)
                    {
                        n.right.left.parent = n.right;
                    }
                }
            }
        }

        public override bool Delete(int elem)
        {
            Node pointer = null;
            if (Search(elem))
            {
                pointer = current;
            }
            else
            {
                Console.WriteLine("Element nicht vorhanden");
                return false;
            }

            while (pointer.left != null || pointer.right != null) //Pointer zu Blatt machen
            {
                if (pointer.right == null || (pointer.left != null && pointer.left.prio < pointer.right.prio))
                    RightRotation(pointer.left);
                else
                    LeftRotation(pointer.right);

            }
            if (base.Delete(pointer.value)) //pointer (Blatt) löschen
            {
                Console.WriteLine("Element gelöscht");
                return true;
            }

            Console.WriteLine("Irgendwas stimmt nicht");
            return false;
        }

        public override void Print()
        {
                type = "Treap";
                base.Print();
        }
    }
}

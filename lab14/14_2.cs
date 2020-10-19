using System;
using System.Collections.Generic;
using System.Text;

namespace CircularLinkedListNameSpace
{
    class CircularLinkedList<T>
    {
        private T current;
        private CircularLinkedList<T> next;

        public CircularLinkedList(T value)
        {
            current = value;
            next = this;
        }

        public CircularLinkedList Insdata(int value)
        {
            CircularLinkedList node = new CircularLinkedList(value);
            if (this.next == this)
            {
                node.next = this;
                this.next = node;
            }
            else
            {
                CircularLinkedList temp = this.next;
                node.next = temp;
                this.next = node;
            }

            return node;
        }

        public int Deldata()
        {
            if (this.next == this)
            {
                System.Console.WriteLine("\nOnly one node...");
                return 0;
            }

            CircularLinkedList node = this.next;
            this.next = this.next.next;
            node = null;
            return 1;
        }

        public void Traverse()
        {
            Traverse(this);
        }

        public void Traverse(CircularLinkedList node)
        {
            if (node == null)
                node = this;
            System.Console.WriteLine("Forward Direction...");
            CircularLinkedList snode = node;
            do
            {
                System.Console.WriteLine(node.current);
                node = node.next;
            } while (node != snode);
        }

        public int Gnodes()
        {
            return Gnodes(this);
        }

        public int Gnodes(CircularLinkedList node)
        {
            if (node == null)
                node = this;
            int count = 0;
            CircularLinkedList snode = node;
            do
            {
                count++;
                node = node.next;
            } while (node != snode);

            System.Console.WriteLine("\nCurrent Node Value : " + node.current.ToString());
            System.Console.WriteLine("\nTotal nodes :" + count.ToString());
            return count;
        }
    }

    class Program
        {
            static void Main(string[] args)
            {
                // CircularLinkedList<string> list = new CircularLinkedList<string>("Init");
                // list.Shift();
                // list.Add("1");
                // list.Shift();
                // list.Add("2");
                // list.Shift();
                // list.Add("3");
                // //list.Shift();
                // Console.WriteLine(list.Remove());
                // Console.WriteLine(list.Remove());
                // Console.WriteLine(list.Remove());
                // list.Remove();

            }
        }
    }

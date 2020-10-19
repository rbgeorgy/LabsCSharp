using System;
using System.Collections.Generic;
using System.Text;
namespace BinaryTrees
{
// Двоичное дерево поиска
    public class SearchTree
    {
        private int _count;

        public int Count => _count;

        class Node
        {
            public double Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node(double val)
            {
                Value = val;
                Left = Right = null;
            }
        }
        Node root = null;
        public void Add(double val)
        {
            if (root == null)
            {
                root = new Node(val);
                _count = 1;
                return;
            }
            Node current = root;
            while (true)
            {
                if (val < current.Value)
                {
                    if (current.Left == null)
                    {
                        current.Left = new Node(val);
                        _count++;
                        return;
                    }
                    else
                        current = current.Left;
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = new Node(val);
                        _count++;
                        return;
                    }
                    else
                        current = current.Right;
                }
            }
        }
        public bool Search(double val)
        {
            if (root == null)
                return false;
            Node current = root;
            while (true)
            {
                if (val < current.Value)
                {
                    if (current.Left == null)
                        return false;
                    else
                        current = current.Left;
                }
                else if (val > current.Value)
                {
                    if (current.Right == null)
                        return false;
                    else
                        current = current.Right;
                }
                else
                    return true;
            }
        }
        public void InOrderWalk()
        {
            InOrderWalk(root);
            Console.WriteLine();
        }
        void InOrderWalk(Node t)
        {
            if (t != null)
            {
                InOrderWalk(t.Left);
                Console.Write(t.Value + " ");
                InOrderWalk(t.Right);
            }
        }

        public bool IsEmpty()
        {
            return (root == null);
        }

        public void Clear()
        {
            root = null;
            _count = 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SearchTree tree = new SearchTree();
            tree.Add(4);
            tree.Add(2);
            tree.Add(0);
            tree.Add(3);
            tree.Add(6);
            tree.Add(5);
            tree.Add(9);
            Console.WriteLine("Симметричный обход дерева:");
            tree.InOrderWalk();
            for (double x= 0; x < 10; x++)
            {
                if (tree.Search(x))
                    Console.WriteLine("Элемент {0} содержится в дереве", x);
                else
                    Console.WriteLine("Элемент {0} отсутствует в дереве", x);
            }

            Console.WriteLine(tree.IsEmpty());
            Console.WriteLine(tree.Count);
            tree.Clear();
            Console.WriteLine(tree.IsEmpty());
            Console.WriteLine(tree.Count);
        }
    }
}
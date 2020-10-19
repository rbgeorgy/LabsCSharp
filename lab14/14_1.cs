using System;
using System.Collections.Generic;
using System.Text;
namespace StackNameSpace
{

    
    class Node<T>
    {
        public T Value {get; set;}
        public Node<T> Next {get; set;}
    }

    class Stack<T>
    {
        private Node<T> _peek;
        
        public void Push(T Val)
        {
            Node<T> temp = new Node<T>();
            temp.Value = (T) Val;
            temp.Next = _peek;
            _peek = temp;
        }

        public T Pop()
        {
            Node<T> temp= new Node<T>();
        
            if(_peek == null)
                Console.Write("Stack Underflow");
            
            temp = _peek;
            if (_peek.Next != null)
            {
                _peek = _peek.Next;
            }

            T ret = temp.Value;
            temp = null;
            return ret;
        }

        public void Clear()
        {
            _peek = null;
        }

        public bool IsEmpty()
        {
            return _peek == null;
        }

        public override string ToString()
        {
            string ret = "";
            Node<T> current = _peek;
            while(current != null){
                ret += current.Value.ToString() + " ";
                current = current.Next;
            }
            return ret;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           Stack<string> stack = new Stack<string>();
           stack.Push("told me");
           stack.Push("once");
           stack.Push("Somebody");
           Console.WriteLine(stack.ToString());
           stack.Pop();
           stack.Push("Nobody");
           Console.WriteLine(stack.ToString());
           stack.Clear();
           Console.WriteLine(stack.IsEmpty());

        }
    }
}
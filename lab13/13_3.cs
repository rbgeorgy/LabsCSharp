using System;
namespace ConsoleApplication5
{

    public class StackException : Exception
    {
        public StackException(string messg) : base(messg)
        {
        }
    }

    class Stack
    {

        private int _capacity;

        private int _peek;
        double[] _data; // = new double[_capacity];

        public Stack(int capacity)
        {
            _capacity = capacity;
            _data = new double[_capacity];
            _peek = -1;
        }

        public Stack()
        {
            _capacity = 10;
            _data = new double[_capacity];
            _peek = -1;
        }

        public void Push(double item)
        {
            if (_peek >= _capacity)
            {
                throw new StackException("Stack Overflow");
            }
            else
            {
                _data[++_peek] = item;
            }
        }

        public double Pop()
        {
            if (_peek < 0)
            {
                throw new StackException("Stack Underflow");
            }
            else
            {
                return _data[_peek--];
            }
        }
        
        public double Peek()
        {
            if (_peek < 0)
            {
                throw new StackException("Stack Underflow");
            }
            else
            {
                return _data[_peek];
            }
        }

        public override string ToString()
        {
            string res = "";
            
            if(!IsEmpty())
                for(int i = 0; i <= _peek; i++)
                {
                    res += _data[i].ToString() + " ";
                }

            return res;
        }

        public void Clear()
        {
            _data = new double[_capacity];
            _peek = -1;
        }

        public bool IsEmpty()
        {
            return (_peek < 0);
        }

    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(343);
            stack.Push(3324);
            stack.Push(3532);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.ToString());
            stack.Pop();
            stack.Pop();
            Console.WriteLine(stack.ToString());
            stack.Clear();
            Console.WriteLine(stack.IsEmpty());
            try
            {
                stack.Pop();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
using System;
namespace ConsoleApplication5
{

    public class QueueException : Exception
    {
        public QueueException(string messg) : base(messg)
        {
        }
    }

    class Queue
    {

        private int _capacity;

        private int _peek;
        private int _rear;
        
        double[] _data; // = new double[_capacity];

        public Queue(int capacity)
        {
            _capacity = capacity;
            _data = new double[_capacity];
            _peek = -1;
            _rear = -1;
        }

        public Queue()
        {
            _capacity = 10;
            _data = new double[_capacity];
            _peek = -1;
            _rear = -1;
        }

        public void Enqueue(double item)
        {
            if (_rear == _capacity - 1)
            {
                throw new QueueException("Queue Overflow");
            }
            else
            {
                if (_peek == -1) _peek = 0;
                _data[++_rear] = item;
            }
        }

        public double Dequeue()
        {
            if (_peek < 0 || _peek > _rear)
            {
                throw new QueueException("Queue Underflow");
            }
            else
            {
                return _data[_peek++];
            }
        }
        
        public double Peek()
        {
            if (_peek < 0 || _peek > _rear)
            {
                throw new QueueException("Queue Underflow");
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
            {
                for (int i = _peek; i <= _rear; i++)
                {
                    res += _data[i].ToString() + " ";
                }
            }

            return res;
        }

        public void Clear()
        {
            _data = new double[_capacity];
            _peek = -1;
            _rear = -1;
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
            Queue Queue = new Queue();
            Queue.Enqueue(343);
            Queue.Enqueue(3324);
            Queue.Enqueue(3532);
            Console.WriteLine(Queue.Peek());
            Console.WriteLine(Queue.ToString());
            Queue.Dequeue();
            Queue.Dequeue();
            Console.WriteLine(Queue.ToString());
            Queue.Clear();
            Console.WriteLine(Queue.IsEmpty());
            try
            {
                Queue.Dequeue();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
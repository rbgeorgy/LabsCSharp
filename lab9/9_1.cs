using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp5
{
    interface ISequence
    {
        double GetElement(int i);
        double Sum(int i);
    }

    class ArithmeticProgression: ISequence
    {
        private double _firstElem;
        private double _step;

        public ArithmeticProgression(double a, double b)
        {
            _firstElem = a;
            _step = b;
        }

        public double GetElement(int i)
        {
            return _firstElem + _step * (i - 1);
        }

        public double Sum(int i)
        {
            return i * ((2 * _firstElem + _step * (i - 1)) / 2);
        }
    }
    
    class GeometricProgression: ISequence
    {
        private double _firstElem;
        private double _step;

        public GeometricProgression(double b, double q)
        {
            _firstElem = b;
            _step = q;
        }

        public double GetElement(int i)
        {
            return _firstElem * Math.Pow(_step, i - 1);
        }

        public double Sum(int i)
        {
            return (_firstElem - this.GetElement(i) * _step) * (1 - _step);
        }
    }

    class Program
    {
        public static double Sum(ISequence seq, int n)
        {
            return seq.Sum(n);
        }

        static void Main(string[] args)
        {
            double s = Sum(new ArithmeticProgression(1, 2), 10);
            Console.WriteLine(s);
            double gs = Sum(new GeometricProgression(1, 2), 10);
            Console.WriteLine(gs);
        }
    }
}

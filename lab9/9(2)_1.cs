using System;
using System.Net.Mail;

namespace ConsoleApp7
{

    struct Parallelogram
    {
        private double _a;
        private double _b;
        private double _alpha;

        public double _B => _b;
        public double _A => _a;
        public double _Alpha => _alpha;

        public Parallelogram(double a, double b, double alpha)
        {
            _a = a;
            _b = b;
            _alpha = alpha;
        }

        public string Kind()
        {
            if (_alpha == 90)
            {
                if (_a == _b) return "Квадрат";
                else
                {
                    return "Прямоугольник";
                }
            }
            else if(_a == _b) return "Ромб";
            else return  ("Обычный параллелограм");
        }

        public void Info()
        {
            Console.WriteLine("Стороны параллелограма равны {0} и {1}, угол равен {2}", _a, _b, _alpha);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            Parallelogram[] array = new Parallelogram[399];
            int k1 = 0, k2 = 0, k3 = 0;
            for (int i = 1; i < 400; i++)
            {
                array[i-1] = new Parallelogram(rand.Next(i, 400), rand.Next(i, 400), rand.Next(1, 91));

                if (array[i - 1].Kind() == "Квадрат")
                {
                    k1++;
                    continue;
                }

                if (array[i-1].Kind() == "Прямоугольник")
                {
                    k2++;
                    continue;
                }

                if (array[i-1].Kind() == "Ромб")
                {
                    k3++;
                    continue;
                }
            }
            Console.WriteLine("Квадратов {0}, Прямоугольников {1}, Ромбов {2}.", k1, k2, k3);

        }
    }
}

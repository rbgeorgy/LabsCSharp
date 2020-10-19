using System;

namespace ConsoleApp9
{
    class Triangle
    {
        private double first_side;
        private double second_side;
        private double third_side;
        
        public Triangle(double first, double second, double third)
        {
            try
            {
                if (first + second <= third || first + third <= second || third + second <= first)
                    throw new ArgumentException("Треугольнмка с такими сторонами не существует!");
                first_side = first;
                second_side = second;
                third_side = third;
            }
            catch (ArgumentException e)//поймаем в Майне, выведем потом, чтобы избежать дублирования сообщения
            {
                throw;
            }
        }

        public void Show()
        {
            Console.WriteLine("a = " + first_side + " b = " + second_side + " c = " + third_side);
        }

        public String Kind()
        {
            if (first_side == second_side && first_side == third_side)
                return "Равносторонний";
            else if (first_side == second_side || first_side == third_side || third_side == second_side)
                return "Равнобедренный";
            else return "Разносторонний";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны");
            double a = 0, b = 0, c = 0;
            try
            {
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    throw new Exception("Введено отрицательное или нулевое значение для сторон!");
                }

                Triangle abc = new Triangle(a, b, c);
                abc.Show();
                Console.Write(abc.Kind());

            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат вводимых чисел!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

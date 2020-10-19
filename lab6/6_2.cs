using System;

namespace ConsoleApp1
{

    class Triangle
    {
        private double first_side { get; set; }
        private double second_side { get; set; }
        private double third_side { get; set; }
        

        public Triangle(double first, double second, double third)
        {
            first_side = first;
            second_side = second;
            third_side = third;
        }

        public void Show()
        {
            Console.WriteLine("a = " + first_side + " b = " + second_side + " c = " + third_side);
        }

        public String Kind()
        {
            if (first_side == second_side && first_side == third_side)
                return "Равносторонний";
            else if (first_side + second_side <= third_side || first_side + third_side <= second_side ||
                     third_side + second_side <= first_side)
                return "Данного треугольника не существует";
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
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            
            Triangle abc = new Triangle(a, b, c);
            abc.Show();
            Console.Write(abc.Kind());
        }
    }
}

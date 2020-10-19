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

            double a, b, c;
            Console.WriteLine("Введите число элементов массива");
            int n = Convert.ToInt32(Console.ReadLine());
            Triangle[] array = new Triangle[n];
            int k1 = 0, k2 = 0, k3 = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите стороны");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
                array[i] = new Triangle(a, b, c);
                Console.WriteLine(array[i].Kind());
                switch (array[i].Kind())
                {
                    case "Разносторонний":
                        k1++;
                        break;
                    case  "Равнобедренный":
                        k2++;
                        break;
                    case  "Равносторонний":
                        k3++;
                        break;

                }
            }
            Console.WriteLine("Разносторонних " + k1 + " Равнобедренных " + k2 + " Равносторонних " + k3);
        }
    }
}

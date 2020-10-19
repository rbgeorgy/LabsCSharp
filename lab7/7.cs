using System;

namespace ConsoleApp3
{

    class Matrix2
    {
        private double a11;
        private double a12;
        private double a21;
        private double a22;
        
        public Matrix2(double a11, double a12, double a21, double a22)
        {
            this.a11 = a11;
            this.a12 = a12;
            this.a21 = a21;
            this.a22 = a22;
        }
        
        public Matrix2(double a11, double a22)
        {
            this.a11 = a11;
            this.a12 = 0;
            this.a21 = 0;
            this.a22 = a22;
        }

        public Matrix2(Matrix2 obj) : this(obj.a11, obj.a12, obj.a21, obj.a22)
        {
        }

        public double Det()
        {
            return a11 * a22 - a12 * a21;
        }

        public Matrix2 Transpose()
        {
            return new Matrix2(a11, a21, a12, a22);
        }

        public static Matrix2 operator +(Matrix2 one, Matrix2 two)
        {
            return  new Matrix2(one.a11 + two.a11, one.a12 + two.a12, one.a21 + two.a21, one.a22 + two.a22);
        }
        
        public static Matrix2 operator -(Matrix2 one, Matrix2 two)
        {
            return  new Matrix2(one.a11 - two.a11, one.a12 - two.a12, one.a21 - two.a21, one.a22 - two.a22);
        }
        
        public static Matrix2 operator *(Matrix2 one, Matrix2 two)
        {
            double A11 = one.a11 * two.a11 + one.a12 * two.a21;
            double A12 = one.a11 * two.a12 + one.a12 * two.a22;
            double A21 = one.a21 * two.a11 + one.a22 * two.a21;
            double A22 = one.a21 * two.a12 + one.a22 * two.a22;
            return  new Matrix2(A11, A12, A21, A22);
        }
        
        public static Matrix2 operator *(Matrix2 one, double num)
        {
            return  new Matrix2(one.a11*num, one.a12*num, one.a21*num, one.a22*num);
        }

        public void print()
        {
            Console.WriteLine(a11 + " " + a12);
            Console.WriteLine(a21 + " " + a22);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            //тесты?
            double a = 41, b = 432, c = 35, d = 654;
            Matrix2 temp = new Matrix2(a, b, c, d);
            temp.print();
            Console.WriteLine(temp.Det());
            Matrix2 temp2 = new Matrix2(temp.Transpose());
            temp2.print();
            Matrix2 temp3 = temp + temp2;
            temp3.print();
            temp3 = temp2 * 5;
            temp3.print();
            temp3 = temp * temp2;
            temp3.print();
        }
    }
}

using System;

namespace ConsoleApp2
{

    class Student
    {
        private String full_name;
        public String FullName => full_name;
        private String gender;
        public string Gender => gender;
        private int year;
        public int Year => year;

        public Student(String full_name, String gender, int year)
        {
            this.full_name = full_name;
            this.gender = gender;
            this.year = year;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число школьников");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] array = new Student[n];
            int male_cnt = 0, female_cnt = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите ФИО");
                String full_name = Console.ReadLine();
                
                
                Console.WriteLine("Введите пол(мужской/женский)");
                String gender = Console.ReadLine();
                if (gender == "мужской") male_cnt++; 
                    else female_cnt++;

                    Console.WriteLine("Введите год рождения");
                int year = Convert.ToInt32(Console.ReadLine());
                array[i] = new Student(full_name, gender, year);
            }

            if (male_cnt != 0)
            {
                Console.WriteLine("Список мальчиков " + "(всего " + male_cnt + "):");
                foreach (Student guy in array)
                {
                    if (guy.Gender == "мужской")
                        Console.WriteLine(guy.FullName + ", " + guy.Year + "-го года рождения");
                }
            }

            if (female_cnt != 0)
            {
                Console.WriteLine("Список девочек " + "(всего " + female_cnt + "):");
                foreach (Student guy in array)
                {
                    if (guy.Gender == "женский")
                        Console.WriteLine(guy.FullName + ", " + guy.Year + "-го года рождения");
                }
            }
            
        }
    }
}

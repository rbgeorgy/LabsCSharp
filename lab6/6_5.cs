using System;
using System.Runtime.Versioning;

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

    class Students
    {
        private Student[] data;

        public Students(int n)
        {
            data = new Student[n];
        }

        public Student this[int i]
        {
            get
            {
                return data[i];
            }
            set
            {
                data[i] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число школьников");
            int n = Convert.ToInt32(Console.ReadLine());
            Students group = new Students(n);
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
                group[i] = new Student(full_name, gender, year);
            }
            
            if (male_cnt != 0)
            {
                Console.WriteLine("Список мальчиков " + "(всего " + male_cnt + "):");
                for(int i = 0; i < n; i++)
                {
                    if (group[i].Gender == "мужской")
                        Console.WriteLine(group[i].FullName + ", " + group[i].Year + "-го года рождения");
                }
            }
            
            if (female_cnt != 0)
            {
                Console.WriteLine("Список девочек " + "(всего " + female_cnt + "):");
                for(int i = 0; i < n; i++)
                {
                    if (group[i].Gender == "женский")
                        Console.WriteLine(group[i].FullName + ", " + group[i].Year + "-го года рождения");
                }
            }
            
        }
    }
}

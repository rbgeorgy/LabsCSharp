using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp6
{
    /*6.2-1 Описать класс Time , соответствующий времени суток (часы и мину-
    ты). Определить в нем операции и методы сравнения. Более ранние моменты
    времени считать меньшими, чем более поздние.*/

    class Time : IEquatable<Time>, IComparable<Time>
    {
        private int _hours;
        private int _minutes;

        public int _Hours => _hours;
        public int _Minutes => _minutes;

        public Time(int hours, int minutes)
        {
            _hours = hours;
            _minutes = minutes;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Time);
        }

        public bool Equals(Time other)
        {
            if ((object) other == null) return false;
            if (other.GetType() != typeof(Time)) return false;
            if (object.ReferenceEquals(this, other)) return true;
            return _hours * 60 + _minutes == other._hours * 60 + other._minutes;
        }

        public override int GetHashCode()
        {
            int Minutes = _hours * 60 + _minutes;
            return Minutes.GetHashCode();
        }

        public static bool operator ==(Time a, Time b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Time a, Time b)
        {
            return !a.Equals(b);
        }

        public int CompareTo(Time other)
        {
            if ((object) other == null) return 1;
            return Math.Sign(_hours * 60 + _minutes - other._hours * 60 - other._minutes);
        }

        public static bool operator > (Time a, Time b)
        {
            return a.CompareTo(b) > 0;
        }
        
        public static bool operator >= (Time a, Time b)
        {
            return a.CompareTo(b) >= 0;
        }
        
        public static bool operator < (Time a, Time b)
        {
            return a.CompareTo(b) < 0;
        }
        
        public static bool operator <= (Time a, Time b)
        {
            return a.CompareTo(b) <= 0;
        }
    }

    class  TimeComparer : IComparer<Time>
    {
        public int Compare(Time x, Time y)
        {
            return Math.Sign(x._Hours * 60 + x._Minutes - y._Hours * 60 - y._Minutes);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
        }
    }
}

using  System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Написать программу, оценивающую информационную энтропию в
указанном файле.
Для этого она должна просмотреть файл побайтово и составить таблицу ча-
стот p k каждого значения байта ( k изменяется от 0 до 255). После этого можно
вычислить энтропию по формуле
H = −
255
∑
p k log 2 p k .
k=0
Информационная энтропия в данном случае будет показывать оценку коли-
чества информации, приходящейся на один байт файла. Чем она меньше, тем
сильнее можно сжать файл.
В приведённой формуле в качестве p k должны использоваться вероятности.
Так как они, вообще говоря, неизвестны, вместо них используются частоты. Ча-
стота байта — это отношение количества его вхождений к общему количеству
байтов в файле.*/
namespace ConsoleApplication16_3
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter the path to the file: ");
      string path = Console.ReadLine();
      try
      {
        using (FileStream fstream = new FileStream(@path, FileMode.Open, FileAccess.Read))
        {
          byte[] array = new byte[fstream.Length];
          fstream.Read(array, 0, array.Length);
          
          Dictionary<byte, double> hashTable = new Dictionary<byte, double>();
          Dictionary<byte, double> hashTable2 = new Dictionary<byte, double>();
          
          foreach (var i in array)
          {
            hashTable[i] = 0;
            hashTable2[i] = 0;
          }
          Console.WriteLine();
          foreach (var i in array)
          {
            hashTable[i]++;
          }
          foreach (var i in array)
          {
            hashTable2[i] = hashTable[i]/array.Length;
              //Console.WriteLine(hashTable2[i]);  
          }

          double Sum = 0;
          foreach (var i in hashTable2)
          {
            Sum += i.Value * Math.Log(i.Value, 2);
          }
          
          Console.WriteLine("Entrophy of the file is: " + -Sum);

        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}

using  System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 Написать программу, выводящую на экран список файлов с расшире-
нием «.txt» в заданной папке, в которых содержится указанное слово.
 */
namespace ConsoleApplication16_4
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter the path to the dir: ");
      string path = Console.ReadLine();
      Console.WriteLine("Enter the word which gonna find: ");
      string word = Console.ReadLine();
      List<string> list = new List<string>();
      try
      {
        DirectoryInfo dir = new DirectoryInfo(@path);
        FileInfo[] txt_files = dir.GetFiles("*.txt");
        foreach (var file in txt_files)
          using (StreamReader data = File.OpenText(@path + "/"+ file.Name))
          {
            string ret = "";
            ret = data.ReadToEnd();
            if(ret.Contains(word)) 
              list.Add(file.Name);
          }

        foreach (var i in list)
        {
          Console.WriteLine(i);
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}

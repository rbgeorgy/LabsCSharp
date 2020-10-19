using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication2
{

  abstract class Edition
  {
    private string _name;
    private string _autorName;
    public string _Name
    {
      get { return _name; }
      set { _name = value; }
    }
    
    public string _AutorName
    {
      get { return _autorName; }
      set { _autorName = value; }
    }

    public Edition(string name, string autorName)
    {
      _name = name;
      _autorName = autorName;
    }
    public abstract void Show();
  }

  class Book : Edition
  {
    private int _year;
    private string _publishingHouse;

    public Book(string name, string autorName, int year, string publishingHouse) : base(name, autorName)
    {
      _year = year;
      _publishingHouse = publishingHouse;
    }

    public override void Show()
    {
      Console.WriteLine("Название книги: {0}, имя автора: {1}, год: {2}, название издательства: {3}",
                          _Name, _AutorName, _year, _publishingHouse);
    }
  }

  class Article : Edition
  {
    private string _journalName;
    private int _number;

    public Article(string name, string autorName, string journalName, int number) : base(name, autorName)
    {
      _journalName = journalName;
      _number = number;
    }

    public override void Show()
    {
      Console.WriteLine("Название статьи: {0}, имя автора {1}, название журнала: {2}, номер журнала: {3}",
        _Name, _AutorName, _journalName, _number);
    }
  }

  class Eresurs : Edition
  {
    private string _link;
    private string _annotation;

    public Eresurs(string name, string autorName, string link, string annotation) : base(name, autorName)
    {
      _link = link;
      _annotation = annotation;
    }
    
    public override void Show()
    {
      Console.WriteLine("Название ресурса: {0}, имя автора {1}, ссылка: {2}, аннотация: {3}",
        _Name, _AutorName, _link, _annotation);
    }
  }

  internal class Program
  {
    public static void Main(string[] args)
    {
      Edition[] library = new Edition[3];
      library[1] = new Book("Моби Дик", "Герман Мелвилл", 1851, "Harper & Brothers");
      library[2] = new Article("Some name", "Some Author", "Some journal name", 184);
      library[0] = new Eresurs("Libgen", "Anonimous", "libgen.io", "free access library");

      for (int i = 0; i < 3; i++)
      {
        library[i].Show();
      }

      while (true)
      {
        Console.WriteLine("Введите имя автора");
        string querry = Console.ReadLine();
        for (int i = 0; i < 3; i++)
        {
          if(querry == library[i]._AutorName)
              library[i].Show();
        }
      }
    }
    
  }
}
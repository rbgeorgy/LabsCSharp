using System;

namespace ConsoleApplication2
{

  class Area
  {
    private double _length;
    private double _width;

    public double _Length {
      get { return _length; }
      set { _length = value; }
    }
    
    public double _Width {
      get { return _width; }
      set { _width = value; }
    }


    public Area(double l, double w)
    {
      _length = l;
      _width = w;
    }

    public virtual void Show()
    {
      Console.WriteLine("Длина = {0}, Ширина = {1}", _length, _width);
    }

    public double Square()
    {
      return _length * _width;
    }
  }

  class  Field : Area
  {
    private string _culture;
    private double _yield;//урожайномть

    public string _Culture
    {
      get { return _culture; }
      set { _culture = value; }
    }
    
    public double _Yield
    {
      get { return _yield; }
      set { _yield = value; }
    }

    public Field(double length, double width, string culture, double yield) 
           :base(length, width)
    {
      _culture = culture;
      _yield = yield;
    }

    public override void Show()
    {
      base.Show();
      Console.Write("На поле урожайности {0} произрастает культура {1}", _yield, _culture);
    }
  }

  internal class Program
  {
    public static void Main(string[] args)
    {
      Area parent = new Area(1500, 1800);
      parent.Show();
      Console.WriteLine("Площадь поля: " + parent.Square());
      
      Field son = new Field(parent._Length, parent._Width, "Пшеница", 14);
      son.Show();
    }
  }
}
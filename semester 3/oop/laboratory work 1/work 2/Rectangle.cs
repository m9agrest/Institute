using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class Rectangle
{
    private protected int _width;
    private protected int _height;


    /// <summary>
    /// Ширина прямоугольника
    /// </summary>
    public virtual int Width
    {
        get { return _width; }
        set { _width = Math.Abs(value); }
    }

    /// <summary>
    /// Высота прямоугольника
    /// </summary>
    public virtual int Height
    {
        get { return _height; }
        set { _height = Math.Abs(value); }
    }

    /// <summary>
    /// Периметр прямоугольника
    /// </summary>
    public virtual double Perimeter { get { return Width * 2 + Height * 2; } }

    /// <summary>
    /// Площадь прямоугольника
    /// </summary>
    public virtual double Square { get { return Width * Height; } }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="Width">Ширина прямоугольника</param>
    /// <param name="Height">Высота прямоугольника</param>
    public Rectangle(int Width, int Height)
    {
        this.Height = Height;
        this.Width = Width;
    }

    /// <summary>
    /// Метод увеличивающий все размеры в 2 раза
    /// </summary>
    public virtual void upSize()
    {
        Width *= 2;
        Height *= 2;
    }

    /// <summary>
    /// Текстовая информация об объекте
    /// </summary>
    /// <returns>Возвращает все параметры с их описанием в текстовом формате</returns>
    public string Info() { return ToString(); }

    public override string ToString() { return $"Высота: {Height};\nШирина: {Width};\nПериметр: {Perimeter};\nПлощадь: {Square};\n"; }
}

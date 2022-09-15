using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RectangleRounded : Rectangle
{
    private protected int _radius;


    /// <summary>
    /// Радиус углов прямоугольника
    /// </summary>
    public virtual int Radius
    {
        get { return _radius; }
        set
        {
            int v = Math.Abs(value) * 2;
            if (v > _height || v > _width)
            {
                if(v > _width)
                    _radius = _width / 2;
                if (v > _height)
                    _radius = _height / 2;
            }
            else
                _radius = Math.Abs(value);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Width">Ширина прямоугольника</param>
    /// <param name="Height">Высота прямоугольника</param>
    /// <param name="Radius">Радиус углов прямоугольника</param>
    public RectangleRounded(int Width, int Height, int Radius) : base(Width, Height)
    {
        this.Radius = Radius;
    }


    public override int Height
    {
        get => base.Height;
        set
        {
            int v = Math.Abs(value);
            if (_radius * 2 > v)
            {
                v = _radius * 2;
            }
            _height = v;
        }
    }
    public override int Width
    {
        get => base.Width;
        set
        {
            int v = Math.Abs(value);
            if (_radius * 2 > v)
            {
                v = _radius * 2;
            }
            _width = v;
        }
    }
    public override double Square { get { return base.Square - 4 * Math.Pow(Radius, 2) + Math.PI * Math.Pow(Radius, 2); } }
    public override double Perimeter { get { return base.Perimeter - 8 * Radius + 2 * Math.PI * Radius; } }
    public override void upSize()
    {
        base.upSize();
        Radius *= 2;
    }
    public override string ToString() { return $"Радиус угла: {Radius};\n" + base.ToString(); }
}

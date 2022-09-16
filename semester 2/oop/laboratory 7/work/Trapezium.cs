using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab7
{
    /// <summary>
    /// Объект для хранения и работы с фигурой трапеция
    /// </summary>
    public class Trapezium : Figure
    {
        private double widthTop;
        private double widthBottom;
        private double height;
        private double sideRight;
        private double sideLeft;
        public override double Square
        {
            get { return height * (widthTop + widthBottom) / 2; }
        }
        public override double Perimeter
        {
            get { return widthTop + widthBottom + sideRight + sideLeft; }
        }
        public override Position Center
        {
            get { return new Position(BottomLeft.X + widthBottom / 2, BottomLeft.Y + height / 2); }
        }
        /// <summary>
        /// Конструктор фигры трапеция
        /// </summary>
        /// <param name="WidthTop">Ширина верхнего основания</param>
        /// <param name="WidthBottom">Ширина нижнего основания</param>
        /// <param name="Height">Высота</param>
        public Trapezium(double WidthTop, double WidthBottom, double Height)
        {
            widthBottom = WidthBottom;
            widthTop = WidthTop;
            height = Height;
            double a = (widthBottom - widthTop) / 2;
            sideLeft = sideRight = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(height, 2));
        }
        public override string ToString()
        {
            return $"Трапеция: S = {Square}; P = {Perimeter}; position: ({Center})";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab7
{
    /// <summary>
    /// Объект для хранения и работы с фигурой прямоугольник
    /// </summary>
    public class Rectangle : Figure
    {
        private double width;
        private double height;
        public override double Square
        {
            get { return width * height; }
        }
        public override double Perimeter
        {
            get { return width * 2 + height * 2; }
        }
        public override Position Center
        {
            get { return new Position(BottomLeft.X + width / 2, BottomLeft.Y + height / 2); }
        }
        /// <summary>
        /// Конструктор прямоугольной фигуры
        /// </summary>
        /// <param name="Width">Ширина прямоугольника</param>
        /// <param name="Height">Длинна прямоугольника</param>
        public Rectangle(double Width, double Height)
        {
            width = Width;
            height = Height;
        }
        public override string ToString()
        {
            return $"Прямоугольник: S = {Square}; P = {Perimeter}; position: ({Center})";
        }
    }
}

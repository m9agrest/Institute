using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab7
{
    /// <summary>
    /// Объект для хранения и работы с фигурой круг
    /// </summary>
    public class Circle : Figure
    {
        private double radius;
        public override double Square
        {
            get { return Math.PI * Math.Pow(radius, 2); }
        }
        public override double Perimeter
        {
            get { return Math.PI * radius * 2; }
        }
        public override Position Center
        {
            get { return BottomLeft; }
        }
        /// <summary>
        /// Конструктор фигуры круг
        /// </summary>
        /// <param name="Radius">Радиус круга</param>
        public Circle(double Radius)
        {
            radius = Radius;
        }
        public override string ToString()
        {
            return $"Круг: S = {Square}; P = {Perimeter}; position: ({Center})";
        }

        /// <summary>
        /// Установить позицию фигуры
        /// </summary>
        /// <param name="p">координаты позиции, центра</param>
        public void setPosition(Position p) { BottomLeft = p; }
    }
}
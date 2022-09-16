using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab7
{
    /// <summary>
    /// Объект для хранения и работы позиций
    /// </summary>
    public class Position
    {
        /// <summary>
        /// Координата X
        /// </summary>
        public double X;
        /// <summary>
        /// Координата Y
        /// </summary>
        public double Y;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        public Position(double x, double y)
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// Конструктор, который за X и Y берёт 0
        /// </summary>
        public Position() : this(0, 0) { }

        /// <summary>
        /// Форматирование строкового представления
        /// </summary>
        /// <returns>Сформатированное строковое представление</returns>
        public override string ToString()
        {
            return $"x:{X} y:{Y}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab7
{
    /// <summary>
    /// Объект для хранения фигуры и работы с ней.
    /// Создан в качестве родителя, чтобы от него наследовались остальные фигуры
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public virtual double Square
        {
            get { return 0; }
        }
        /// <summary>
        /// Периметр фигуры
        /// </summary>
        public virtual double Perimeter
        {
            get { return 0; }
        }
        /// <summary>
        /// Базовый конструктор
        /// </summary>
        public Figure()
        {

        }

        private protected Position BottomLeft = new Position();

        /// <summary>
        /// Установить позицию фигуры
        /// </summary>
        /// <param name="p">координаты позиции, нижний левый угол</param>
        public void setPosition(Position p) { BottomLeft = p; }

        /// <summary>
        /// Позиция центра фигуры
        /// </summary>
        public virtual Position Center
        {
            get { return null; }
        }

        /// <summary>
        /// Форматирование строкового представления
        /// </summary>
        /// <returns>Сформатированное строковое представление</returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
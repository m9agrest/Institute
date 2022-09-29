using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    /// <summary>
    /// Класс описывающий знак зодиака и проверки даты на входимость ее в этот знак зодиака
    /// </summary>
    class Zodiac
    {
        #region Публичные свойства
        /// <summary>
        /// Название знака зодиака
        /// </summary>
        public string Name { get => name; }
        /// <summary>
        /// Дата начала знака зодиака
        /// </summary>
        public string Begin { get => _dateTime(begin); }
        /// <summary>
        /// Дата окончания знака зодиака
        /// </summary>
        public string End { get => _dateTime(end); }
        #endregion
        #region Приватные переменные
        /// <summary>
        /// Статичная переменная необходимая для работы с текстом
        /// </summary>
        private static CultureInfo cultureInfo = new CultureInfo("ru-RU");
        /// <summary>
        /// Переменная хранящая в себе название знака зодиака
        /// </summary>
        private string name;
        /// <summary>
        /// Переменная хранящая в себе дату начала знака зодиака
        /// </summary>
        private DateTime begin;
        /// <summary>
        /// Переменная хранящая в себе дату окончания знака зодиака
        /// </summary>
        private DateTime end;
        #endregion
        #region Приватные функции
        /// <summary>
        /// Функция, для приведения даты в стандартный вид удобный для класса
        /// </summary>
        /// <remarks>
        /// Используется 4 год, из-за того что могут попасться вескосные числа
        /// </remarks>
        /// <param name="month">Месяц</param>
        /// <param name="day">День</param>
        /// <returns>Дата</returns>
        private DateTime _dateTime(int month, int day) => new DateTime(4, month, day);
        /// <summary>
        /// Функция для преобразования даты в текст
        /// </summary>
        /// <param name="date">Дата которая будет преобразована</param>
        /// <returns>Текстовое представление даты</returns>
        private string _dateTime(DateTime date) => $"{date.Day} {date.ToString("MMMM", cultureInfo)}";
        /// <summary>
        /// Функция для преобразование названия в нормальный вид
        /// </summary>
        /// <remarks>
        /// Убирает лишнии пробелы и записывает текст с заглавной буквы
        /// </remarks>
        /// <param name="name">Название</param>
        /// <returns>Преобразованное название</returns>
        private string _name(string name) => cultureInfo.TextInfo.ToTitleCase(name.Trim());
        #endregion
        #region Функция проверки входит ли дата в знак зодиака (и его перегрузки)
        /// <summary>
        /// Функция проверки входит ли дата в знак зодиака
        /// </summary>
        /// <param name="Month">проверяемый месяц</param>
        /// <param name="Day">Проверяеммый день</param>
        /// <returns>Результат проверки</returns>
        public bool Check(int Month, int Day)
        {
            DateTime DateParams = _dateTime(Month, Day);
            DateTime E = end;
            if (end.Ticks < begin.Ticks)
            {
                E = new DateTime(5, end.Month, end.Day);
                if(DateParams.Ticks < begin.Ticks)
                    DateParams = new DateTime(5, Month, Day);
            }
            
            if (begin.Ticks <= DateParams.Ticks && DateParams.Ticks <= E.Ticks)
                return true;
            return false;
        }
        /// <summary>
        /// Функция проверки входит ли дата в знак зодиака
        /// </summary>
        /// <param name="Date">Проверяемая дата</param>
        /// <returns>Результат проверки</returns>
        public bool Check(DateTime Date) => Check(Date.Month, Date.Day);
        /// <summary>
        /// Функция проверки входит ли дата в знак зодиака
        /// </summary>
        /// <param name="Date">Проверяемая дата в тиках</param>
        /// <returns>Результат проверки</returns>
        public bool Check(long Ticks) => Check(new DateTime(Ticks));
        #endregion
        #region Конструктор (и его перегрузки)
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Name">Название занка зодиака</param>
        /// <param name="BeginMonth">Месяц начала знака зодиака</param>
        /// <param name="BeginDay">День в месяце начала знака зодиака</param>
        /// <param name="EndMonth">Месяц окончания знака зодиака</param>
        /// <param name="EndDay">День в месяце окончания знака зодиака</param>
        public Zodiac(string Name, int BeginMonth, int BeginDay, int EndMonth, int EndDay)
        {
            begin = _dateTime(BeginMonth, BeginDay);
            end = _dateTime(EndMonth, EndDay);
            name = _name(Name);
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Name">Название занка зодиака</param>
        /// <param name="Begin">Начало знака зодиака</param>
        /// <param name="End">Окончание знака зодиака</param>
        public Zodiac(string Name, DateTime Begin, DateTime End) : this(Name, Begin.Month, Begin.Day, End.Month, End.Day) { }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Name">Название занка зодиака</param>
        /// <param name="BeginTicks">Начало знака зодиака в тиках</param>
        /// <param name="EndTicks">Окончание знака зодиака в тиках</param>
        public Zodiac(string Name, long BeginTicks, long EndTicks) : this(Name, new DateTime(BeginTicks), new DateTime(EndTicks)) { }
        #endregion
        #region Переопределенные методы и функции
        public override string ToString() => $"Знак зодиака: {Name};\nНачало: {Begin};\nКонец: {End};";
        #endregion
    }
}
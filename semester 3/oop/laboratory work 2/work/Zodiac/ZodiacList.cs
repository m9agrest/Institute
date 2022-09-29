using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    /// <summary>
    /// Статический класс хранящий в себе коллекцию знаков зодиака и поиска их
    /// </summary>
    static class ZodiacList
    {
        #region Приватные переменные
        /// <summary>
        /// Статическая коллекция всех знаков зодиака
        /// </summary>
        private static List<Zodiac> list = new List<Zodiac>()
        {
            new Zodiac("овен",       3, 21,  4, 20),
            new Zodiac("телец",      4, 21,  5, 21),
            new Zodiac("близнецы",   5, 22,  6, 21),
            new Zodiac("рак",        6, 22,  7, 22),
            new Zodiac("лев",        7, 23,  8, 21),
            new Zodiac("дева",       8, 22,  9, 23),
            new Zodiac("весы",       9, 24, 10, 23),
            new Zodiac("скоприон",  10, 24, 11, 22),
            new Zodiac("стрелец",   11, 23, 12, 22),
            new Zodiac("козерог",   12, 23,  1, 20),
            new Zodiac("водолей",    1, 21,  2, 19),
            new Zodiac("рыбы",       2, 20,  3, 20)
        };
        #endregion
        #region Публичные свойства
        /// <summary>
        /// Кол-во знаков зодиака
        /// </summary>
        public static int Length { get => list.Count; }
        /// <summary>
        /// Кол-во знаков зодиака
        /// </summary>
        public static int Count { get => Length; }
        #endregion
        #region Функция получения знака зодиака по его номеру (и его перегрузки)
        /// <summary>
        /// Знак зодиака
        /// </summary>
        /// <param name="i">Номер знака зодиака от 0 до Length (11)</param>
        /// <returns>Информация о знаке зодиака</returns>
        public static Zodiac Get(int i)
        {
            if (i < 0) i = 0;
            if (i > Length) i = Length;
            return list[i];
        }
        /// <summary>
        /// Знак зодиака
        /// </summary>
        /// <param name="i">Знак зодиака</param>
        /// <returns>Информация о знаке зодиака</returns>
        public static Zodiac Get(ZodiacEnum i) { return Get((int)i); }
        #endregion
        #region Функция поиска знака зодиака (и его перегрузки)
        /// <summary>
        /// Функция поиска знака зодиака
        /// </summary>
        /// <param name="Month">Месяц</param>
        /// <param name="Day">День</param>
        /// <returns>Знак зодиака</returns>
        public static Zodiac Search(int Month, int Day)
        {
            foreach(Zodiac zodiac in list)
                if(zodiac.Check(Month, Day))
                    return zodiac;
            return null;
        }
        /// <summary>
        /// Функция поиска знака зодиака
        /// </summary>
        /// <param name="Date">Дата</param>
        /// <returns></returns>
        public static Zodiac Search(DateTime Date) => Search(Date.Month, Date.Day);
        /// <summary>
        /// Функция поиска знака зодиака
        /// </summary>
        /// <param name="Ticks">Тики</param>
        /// <returns>Знак зодиака</returns>
        public static Zodiac Search(long Ticks) => Search(new DateTime(Ticks));
        #endregion
    }
}

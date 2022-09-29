using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Person
    {
        #region Приватные переменные
        /// <summary>
        /// Статичная переменная необходимая для работы с текстом
        /// </summary>
        private static CultureInfo cultureInfo = new CultureInfo("ru-RU");
        /// <summary>
        /// Переменная хранящая в себе фамилию
        /// </summary>
        private string lastName;
        /// <summary>
        /// Переменная хранящая в себе дату родждения
        /// </summary>
        private DateTime dateBirth;
        #endregion
        #region Публичные свойства
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get => lastName; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateBirth { get => dateBirth; }
        /// <summary>
        /// Сегодня день рождения?
        /// </summary>
        public bool IsBirth { get => IsBirthDate(DateTime.Now); }
        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get => AgeDate(DateTime.Now); }
        #endregion
        #region Приватные функции
        /// <summary>
        /// Функция преобразования фамилии
        /// </summary>
        /// <remarks>
        /// Убирает лишнии пробелы и записывает текст с заглавной буквы
        /// </remarks>
        /// <param name="lastName">Фамилия</param>
        /// <returns>преобразованная фамилия</returns>
        private string _lastName(string lastName) => cultureInfo.TextInfo.ToTitleCase(lastName.Trim());
        #endregion
        /// <summary>
        /// Функция сравнивания фамилий
        /// </summary>
        /// <param name="LastName">Фамилия</param>
        /// <returns>true если фамилии одинаковые</returns>
        public bool CheckLastName(string LastName) => this.LastName.Equals(_lastName(LastName));
        #region Функция определения является ли дата - днём рождения (и его перегрузки)
        /// <summary>
        /// Функция определения является ли дата - днём рождения
        /// </summary>
        /// <param name="Ticks">Проверяемая дата в тиках</param>
        /// <returns>true если дата является днем рождения</returns>
        public bool IsBirthDate(long Ticks) => IsBirthDate(new DateTime(Ticks));
        /// <summary>
        /// Функция определения является ли дата - днём рождения
        /// </summary>
        /// <param name="Date">Проверяемая дата</param>
        /// <returns>true если дата является днем рождения</returns>
        public bool IsBirthDate(DateTime Date) => IsBirthDate(Date.Month, Date.Day);
        /// <summary>
        /// Функция определения является ли дата - днём рождения
        /// </summary>
        /// <param name="Month">Месяц проверяемой даты</param>
        /// <param name="Day">День проверяемой даты</param>
        /// <returns>true если дата является днем рождения</returns>
        public bool IsBirthDate(int Month, int Day) => Day == DateBirth.Day && Month == DateBirth.Month;
        #endregion
        #region Функция определения возраста по дате (и его перегрузки)
        /// <summary>
        /// Функция определения возраста по дате
        /// </summary>
        /// <param name="Date">Дата по которой смотрим возраст</param>
        /// <returns>Возраст</returns>
        public int AgeDate(DateTime Date)
        {
            if (Date.Ticks > DateBirth.Ticks)
                return new DateTime(Date.Ticks - DateBirth.Ticks).Year;
            return -1;
        }
        /// <summary>
        /// Функция определения возраста по дате
        /// </summary>
        /// <param name="Year">Год даты по которой смотрим возраст</param>
        /// <param name="Month">Месяц даты по которой смотрим возраст</param>
        /// <param name="Day">День даты по которой смотрим возраст</param>
        /// <returns>Возраст</returns>
        public int AgeDate(int Year, int Month, int Day) => AgeDate(new DateTime(Year, Month, Day));
        /// <summary>
        /// Функция определения возраста по дате
        /// </summary>
        /// <param name="Ticks">Дата по которой смотрим возраст в тиках</param>
        /// <returns>Возраст</returns>
        public int AgeDate(long Ticks) => AgeDate(new DateTime(Ticks));
        #endregion
        #region Конструктор (и его перегрузки)
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Lastname">Фамилия</param>
        /// <param name="DateBirth">Дата рождения</param>
        public Person(string Lastname, DateTime DateBirth)
        {
            lastName = _lastName(Lastname);
            dateBirth = DateBirth;
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Lastname">Фамилия</param>
        /// <param name="YearBirth">Год рождения</param>
        /// <param name="MonthBirth">Месяц рождения</param>
        /// <param name="DayBirth">День рождения</param>
        public Person(string Lastname, int YearBirth, int MonthBirth, int DayBirth)
            : this(Lastname, new DateTime(YearBirth, MonthBirth, DayBirth)) { }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Lastname">Фамилия</param>
        /// <param name="Tick">Дата рождения в тиках</param>
        public Person(string Lastname, long Tick)
            : this(Lastname, new DateTime(Tick)) { }
        #endregion


        #region Переопределенные методы и функции
        public override string ToString()
        {
            return $"{LastName} {dateBirth.Day} {dateBirth.ToString("MMMM", cultureInfo)} {dateBirth.Year}";
        }
        #endregion
    }
}

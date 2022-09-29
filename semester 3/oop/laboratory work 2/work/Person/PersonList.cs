using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class PersonList
    {
        #region Приватные переменные
        /// <summary>
        /// Лист хранящий в себе все карточки
        /// </summary>
        private List<Person> list;
        #endregion
        #region Приватные функции
        /// <summary>
        /// Поиск карточки по фамилии
        /// </summary>
        /// <param name="lastname">Фамилия</param>
        /// <returns>Индекс карточки</returns>
        private int index(string lastname)
        {
            for(int i = 0; i < list.Count; i++)
                if(list[i].CheckLastName(lastname))
                    return i;
            return -1;
        }
        #endregion
        #region Функция поиска карточки (и его перегрузки)
        /// <summary>
        /// Поиск карточки
        /// </summary>
        /// <param name="Lastname">Фамилия</param>
        /// <returns>Карточка</returns>
        public Person Search(string Lastname)
        {
            int i = index(Lastname);
            if(i >= 0)
                return list[i];
            return null;
        }
        /// <summary>
        /// Поиск карточки
        /// </summary>
        /// <param name="person">Карточка</param>
        /// <returns>Карточка</returns>
        public Person Search(Person person) => Search(person.LastName);
        #endregion
        #region Функция удаления карточки (и его перегрузки)
        /// <summary>
        /// Удаление карточки
        /// </summary>
        /// <param name="Lastname">Фамилия</param>
        /// <returns>результат операции</returns>
        public bool Remove(string Lastname)
        {
            int i = index(Lastname);
            if (i >= 0)
            {
                list.RemoveAt(i);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Удаление карточки
        /// </summary>
        /// <param name="person">Карточка</param>
        /// <returns>Результат операции</returns>
        public bool Remove(Person person) => Remove(person.LastName);
        #endregion
        #region Функция добавление карточки (и его перегрузки)
        /// <summary>
        /// Добавление карточки
        /// </summary>
        /// <param name="person">Карточка</param>
        /// <returns>Результат операции</returns>
        public bool Add(Person person)
        {
            int i = index(person.LastName);
            if (i == -1)
            {
                list.Add(person);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Добавление карточки
        /// </summary>
        /// <param name="Lastname">Фамилия</param>
        /// <param name="DateBirth">Дата рождения</param>
        /// <returns>Результат операции</returns>
        public bool Add(string Lastname, DateTime DateBirth) => Add(new Person(Lastname, DateBirth));
        /// <summary>
        /// Добавление карточки
        /// </summary>
        /// <param name="Lastname">Фамилия</param>
        /// <param name="YearBirth">Год рождения</param>
        /// <param name="MonthBirth">Месяц рождения</param>
        /// <param name="DayBirth">День рождения</param>
        /// <returns>Результат операции</returns>
        public bool Add(string Lastname, int YearBirth, int MonthBirth, int DayBirth) => Add(new Person(Lastname, YearBirth, MonthBirth, DayBirth));
        /// <summary>
        /// Добавление карточки
        /// </summary>
        /// <param name="Lastname">Фамилия</param>
        /// <param name="Tick">Дата рождения в тиках</param>
        /// <returns>Результат операции</returns>
        public bool Add(string Lastname, long Tick) => Add(new Person(Lastname, Tick));
        #endregion
        #region Конструктор и его перегрузки
        /// <summary>
        /// Конструктор
        /// </summary>
        public PersonList() { }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="personList">Другой PersonList</param>
        public PersonList(PersonList personList) : this(personList.list) { }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="personList">Коллекция карточек</param>
        public PersonList(List<Person> personList) => list = personList;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="person">Массив карточек</param>
        public PersonList(Person[] person) : this(person.ToList()) { }
        #endregion
    }
}

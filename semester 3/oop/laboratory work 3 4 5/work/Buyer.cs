using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace lab345
{
    public class Buyer
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Patronymic { get; set; }
        public Char Gender { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public DateTime Birthday { get; set; }
        public string Mobile { get; set; }
        public Address HomeAddress { get; set; }
        public string CreditCard { get; set; }
        public string BankAccaunt { get; set; }

        public Buyer() { }
        public Buyer(XmlNode xml)
        {
            Name = xml["name"].InnerText;
            Lastname = xml["lastname"].InnerText;
            Patronymic = xml["patronymic"].InnerText;
            Width = double.Parse(xml["width"].InnerText);
            Height = double.Parse(xml["height"].InnerText);
            Gender = xml["gender"].InnerText[0];
            Mobile = xml["mobile"].InnerText;
            CreditCard = xml["creditcard"].InnerText;
            BankAccaunt = xml["bankaccaunt"].InnerText;


            Birthday = new DateTime(
                int.Parse(xml["birthday"]["year"].InnerText),
                int.Parse(xml["birthday"]["month"].InnerText),
                int.Parse(xml["birthday"]["day"].InnerText)
                );

            HomeAddress = new Address(xml["home"]);
        }
    }
    public class Address
    {
        public string Mail { get; set; }
        public string Country { get; set; }
        public string Area { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }

        public Address() { }
        public Address(string data) 
        {
            string[] arr = data.Split("; ");
            Country = arr[0];
            Area = arr[1];
            Region = arr[2];
            City = arr[3];
            Street = arr[4];
            House = arr[5];
            Apartment = arr[6];
            Mail = arr[7];
        }
        public Address(XmlNode xml)
        {
            Mail = xml["mail"].InnerText;
            Country = xml["country"].InnerText;
            Region = xml["region"].InnerText;
            Area = xml["area"].InnerText;
            City = xml["city"].InnerText;
            Street = xml["street"].InnerText;
            House = xml["house"].InnerText;
            Apartment = xml["apartment"].InnerText;
        }
        public override string ToString()
            => $"{Country}; {Area}; {Region}; {City}; {Street}; {House}; {Apartment}; {Mail}";
    }

    /// <summary>
    /// Обхъект необходимый, для возрата текстового представления данных из других форм
    /// </summary>
    /// <remarks>
    /// ссылка на объект передается в контутруктор формы
    /// <br>
    /// ссылка на объект хранится в объекте формы
    /// <br>
    /// при измененнии Text, данное поле изменится везде
    /// <br>
    /// <br>
    /// Можно было бы просто передавать string поле в консутруктор
    /// <br>
    /// но при попытки в форме присвоить string полю новое данное, в форме изменится лишь хранимая ссылка
    /// <br>
    /// тем самым, неудасться вытащить данные
    /// </remarks>
    public class FormReturnString
    {
        public string Text;
    }
}

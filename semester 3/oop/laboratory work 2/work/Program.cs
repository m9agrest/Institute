using lab2;

class Program
{
    static void Main(string[] arg)
    {
        PersonList p = new PersonList(new List<Person>(){ 
            new Person("Ермилов", 2001, 5, 4),
            new Person("Пушкин", 1799, 5, 26),
            new Person("Толстой", 1828, 9, 9)
        });
        Person p1 = p.Search(new Person("Ермилов", 2001, 5, 4));
        Console.WriteLine(p1);
        Console.WriteLine(ZodiacList.Search(p1.DateBirth));
    }
}
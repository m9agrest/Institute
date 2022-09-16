namespace lab7
{
    public class program
    {
        /// <summary>
        /// Динамическая коллекция фигур
        /// </summary>
        public static List<Figure> Pictures = new List<Figure>();
        static void Main(string[] arg)
        {
            Pictures.Add(new Circle(10));
            Pictures.Add(new Rectangle(10, 20));
            Pictures.Add(new Trapezium(10, 20, 5));
            Pictures[0].setPosition(new Position(10, 20));
            Pictures[1].setPosition(new Position(20, 20));
            Pictures[2].setPosition(new Position(50, 50));
        }
    }
}
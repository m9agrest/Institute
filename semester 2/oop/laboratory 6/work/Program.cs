class Program
{
	static Random random = new Random();
	static void Main(string[] arg)
	{
		Directory.CreateDirectory("D://Laba6/");
		for (int i = 0; i < 100; i++)
		{
			Buyer buyer = GeneratorBuyer();
			buyer.Save($"D://Laba6/{i}.txt");
			if (buyer.Address.City.Equals("Муром"))
				Console.WriteLine($"User №{i}\n{buyer}");
		}
	}
	static BuyerName GeneratorName()
	{
		string[] name = { "Михаил", "Фёдор", "Денис", "Альберт" };
		string[] lastname = { "Ермилов", "Тютчев", "Привезенцев", "Эйнштейн" };
		string[] patranomic = { "Владимирович", "Иванович", "Геннадьевич", "Германович" };
		return new BuyerName(name[random.Next(0, 4)], lastname[random.Next(0, 4)], patranomic[random.Next(0, 4)]);
	}
	static BuyerCash GeneratorCash()
	{
		return new BuyerCash($"{random.Next(0,10000)}{random.Next(0, 10000)}{random.Next(0, 10000)}{random.Next(0, 10000)}");
	}
	static BuyerNumber GeneratorNumber(Data.ISO_3166_1 Country)
	{
		return new BuyerNumber(Country, $"{random.Next(0, 100000)}{random.Next(0, 100000)}");
	}
	static BuyerAddress GeneratorAddress(Data.ISO_3166_1 Country)
	{
		Dictionary<Data.ISO_3166_1, List<Data.ISO_3166_2>> a = new Dictionary<Data.ISO_3166_1, List<Data.ISO_3166_2>>()
		{
			{ Data.ISO_3166_1.RU, new List<Data.ISO_3166_2>(){Data.ISO_3166_2.RU_MOS, Data.ISO_3166_2.RU_VLA } },
			{ Data.ISO_3166_1.IT, new List<Data.ISO_3166_2>(){Data.ISO_3166_2.IT_82, Data.ISO_3166_2.IT_34 } },
			{ Data.ISO_3166_1.CA, new List<Data.ISO_3166_2>(){Data.ISO_3166_2.CA_BC, Data.ISO_3166_2.CA_AB } },
		};
		int b = random.Next(0, 2);
		int c = random.Next(0, 2);
		string[] d = {"Пушкинская","Лазаревская","Ленина","Рождественская","Московская", "Льва Толстого" };
		return new BuyerAddress( Country, a[Country][b], c, d[random.Next(0, 6)], random.Next(1, 100), random.Next(1, 20), (uint)random.Next(100000, int.MaxValue));
	}
	static Buyer GeneratorBuyer()
	{
		int[] c = {380,124,643 };
		Data.ISO_3166_1 C = (Data.ISO_3166_1)c[random.Next(0, 3)];

		return new Buyer(GeneratorName(),GeneratorAddress(C),GeneratorNumber(C), GeneratorCash());
	}
}

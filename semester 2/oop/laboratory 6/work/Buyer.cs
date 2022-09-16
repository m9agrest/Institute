using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Buyer
{
	public BuyerName Name;
	public BuyerAddress Address;
	public BuyerNumber Number;
	public BuyerCash Cash;

	//без параметров
	public Buyer() : this(new BuyerName(), new BuyerAddress(), new BuyerNumber(), new BuyerCash()) { }

	//1 параметр из 4
	public Buyer(BuyerName Name) : this(Name, new BuyerAddress(), new BuyerNumber(), new BuyerCash()) { }
	public Buyer(BuyerAddress Address) : this(new BuyerName(), Address, new BuyerNumber(), new BuyerCash()) { }
	public Buyer(BuyerNumber Number) : this(new BuyerName(), new BuyerAddress(), Number, new BuyerCash()) { }
	public Buyer(BuyerCash Cash) : this(new BuyerName(), new BuyerAddress(), new BuyerNumber(), Cash) { }

	//2 параметра из 4
	public Buyer(BuyerName Name, BuyerAddress Address) : this(Name, Address, new BuyerNumber(), new BuyerCash()) { }
	public Buyer(BuyerName Name, BuyerNumber Number) : this(Name, new BuyerAddress(), Number, new BuyerCash()) { }
	public Buyer(BuyerName Name, BuyerCash Cash) : this(Name, new BuyerAddress(), new BuyerNumber(), Cash) { }
	public Buyer(BuyerAddress Address, BuyerNumber Number) : this(new BuyerName(), Address, Number, new BuyerCash()) { }
	public Buyer(BuyerAddress Address, BuyerCash Cash) : this(new BuyerName(), Address, new BuyerNumber(), Cash) { }
	public Buyer(BuyerNumber Number, BuyerCash Cash) : this(new BuyerName(), new BuyerAddress(), Number, Cash) { }

	//3 параметра из 4
	public Buyer(BuyerName Name, BuyerAddress Address, BuyerNumber Number) : this(Name, Address, Number, new BuyerCash()) { }
	public Buyer(BuyerName Name, BuyerAddress Address, BuyerCash Cash) : this(Name, Address, new BuyerNumber(), Cash) { }
	public Buyer(BuyerName Name, BuyerNumber Number, BuyerCash Cash) : this(Name, new BuyerAddress(), Number, Cash) { }
	public Buyer(BuyerAddress Address, BuyerNumber Number, BuyerCash Cash) : this(new BuyerName(), Address, Number, Cash) { }
	
	//все параметры (основной конструктор)
	public Buyer(BuyerName Name, BuyerAddress Address, BuyerNumber Number, BuyerCash Cash)
	{
		this.Name = Name;
		this.Address = Address;
		this.Number = Number;
		this.Cash = Cash;
	}

	public Buyer(string path)
	{
		Buyer a = Load(path);
		this.Name = a.Name;
		this.Address = a.Address;
		this.Number = a.Number;
		this.Cash = a.Cash;
	}


	public void Save(string path)
	{
		string number = Number.ToData();
		string cash = Cash.ToData();
		string address = Address.ToData();
		string name = Name.ToData();
		string text = $"{name}\n{address}\n{number}\n{cash}";
		try
		{
			using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
			{
				sw.WriteLine(text);
			}
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}


	static public Buyer Load(string path)
	{
		List<string> a = new List<string>();
		try
		{
			using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
			{
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					a.Add(line);
				}
			}
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
		return new Buyer(BuyerName.GetData(a[0]), BuyerAddress.GetData(a[1]), BuyerNumber.GetData(a[2]), BuyerCash.GetData(a[3]));
	}

	public override string ToString()
	{
		return $"{Name}\n{Address}\n{Number}\n{Cash}";
	}
}


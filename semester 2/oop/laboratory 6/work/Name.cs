using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BuyerName
{
	public string Name;
	public string LastName;
	public string Patronymic;
	public BuyerName(string Name, string LastName, string Patronymic)
	{
		this.Name = Name;
		this.LastName = LastName;
		this.Patronymic = Patronymic;
	}
	public BuyerName(string Name, string LastName) : this(Name, LastName, "") { }
	public BuyerName(string Name) : this(Name, "", "") { }
	public BuyerName() : this("NoName", "", "") { }

	public override string ToString()
	{
		string re = "";
		if (!LastName.Equals("")) re += $"Фамилия: {LastName}; ";
		if (!Name.Equals("")) re += $"Имя: {Name}; ";
		if (!Patronymic.Equals("")) re += $"Отчество: {Patronymic}; ";
		return re.Trim();
	}
	public string ToData()
	{
		return $"{Name}:{LastName}:{Patronymic}";
	}
	static public BuyerName GetData(string data)
	{
		string[] a = data.Split(":");
		return new BuyerName(a[0], a[1], a[2]);
	}

}
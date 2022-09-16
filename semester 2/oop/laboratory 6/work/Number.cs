using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BuyerNumber
{
	private long _number = 0;
	private Data.ISO_3166_1 _code = 0;
	private const long MaxNumber = 10000000000;

	public BuyerNumber() { }
	public BuyerNumber(Data.ISO_3166_1 Country, long Number)
	{
		_code = Country;
		_number = Number % MaxNumber;
	}
	public BuyerNumber(Data.ISO_3166_1 Country, string Number) : this (Country, long.Parse(Number)) { }


	public override string ToString()
	{
		int code = _code != 0 ? Data.NumberCode[_code] : 0;
		long a = _number;
		int b = (int)(a / (MaxNumber / 1000));
		a %= MaxNumber / 1000;
		int c = (int)(a / 10000);
		a %= 10000;
		int d = (int)(a / 100);
		a %= 100;


		return $"+{code} {_(b,3)} {_(c,3)}-{_(d,2)}-{_((int)a,2)}";
	}
	private string _(int num, int n)
	{
		if(n == 3)
		{
			if (num > 99) return $"{num}";
			if (num > 9) return $"0{num}";
			return $"00{num}";
		}
		else if(n == 2)
		{
			if (num > 9) return $"{num}";
			return $"0{num}";
		}
		return $"{num}";
	}


	public string ToData()
	{
		return $"{(int)_code}:{_number}";
	}
	public static BuyerNumber GetData(string data)
	{
		string[] a = data.Split(":");
		Data.ISO_3166_1 code = (Data.ISO_3166_1)int.Parse(a[0]);
		return new BuyerNumber(code, a[1]);
	}
}

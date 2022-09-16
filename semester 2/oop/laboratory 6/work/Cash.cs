using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Примечание:
 * если использовать хранение сразу в string, то места будет занято в несколько раз больше
 * long = 8 байт
 * char = 2 байта
 * string = length * char, в нашем случае от 16 до 19 (зависит есть ли пробелы)
 * string = 2*16 : 2*19 = 32 байт : 38 байт
 * память экономится в 4 : 4.75 раз
 */
class BuyerCash
{
	long _number = 0;
	const long _Max = 10000000000000000;

	public BuyerCash() { }
	public BuyerCash(long Number) { _number = Number % _Max; }
	public BuyerCash(string Number) : this(long.Parse(Number.Replace(" ", ""))) { }

	public override string ToString()
	{
		int a = (int)(_number / (_Max / 10000));
		int b = (int)((_number / (_Max / 100000000)) % 10000);
		int c = (int)((_number / (_Max / 1000000000000)) % 10000);
		int d = (int)(_number % 10000);
		return $"{_(a)} {_(b)} {_(c)} {_(d)}";
	}
	private string _(int num)
	{
		if (num > 999) return $"{num}";
		else if(num > 99) return $"0{num}";
		else if (num > 9) return $"00{num}";
		return $"000{num}";
	}
	public string ToData()
	{
		return $"{_number}";
	}
	static public BuyerCash GetData(string data)
	{
		return new BuyerCash(data);
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BuyerAddress
{
	Data.ISO_3166_1 _country = 0;
	Data.ISO_3166_2 _district = 0;
	int _city = -1;
	
	public Data.ISO_3166_1 CountryCode
    {
		get { return _country; }
		set 
		{ 
			if( _country != value)
            {
				_district = 0;
				_city = -1;
			}
			_country = value; 
		}
	}
	public Data.ISO_3166_2 DistrictCode
	{
		get { return _district; }
		set
		{
			
			if (_district != value && Data.District[_country].ContainsKey(value))
			{
				_city = -1;
				_district = value;
			}
			else if(!Data.District[_country].ContainsKey(value))
            {
				_country = 0;
				_city = -1;
				_district = 0;
			}
			
		}
	}
	public int CityCode
    {
		get { return _city; }
		set { _city = value; }
    }

	public string Street = "";
	public int Home = 0;
	public int Apartment = 0;
	public uint MailIndex = 0;

	public string Country { get { return Data.Country.ContainsKey(_country) ? Data.Country[_country] : "None"; } }
	public string District {  get {  return Data.District.ContainsKey(_country) ?  (Data.District[_country].ContainsKey(_district) ? Data.District[_country][_district] : "None") : "None"; } }
	public string City { get { 
			return Data.City.ContainsKey(_country) ? 
				(Data.City[_country].ContainsKey(_district) ? 
				(_city != 0 && Data.City[_country][_district].Count > _city ? Data.City[_country][_district][_city] : "None")
				//Data.District[_country][_district] 
				: "None") 
				: "None"; } }

	public BuyerAddress() { }
	public BuyerAddress(Data.ISO_3166_1 Country, Data.ISO_3166_2 District, int City, string Street, int Home, int Apartment, uint MailIndex)
    {
		CountryCode = Country;
		DistrictCode = District;
		CityCode = City;
		this.Street = Street;
		this.Home = Home;
		this.Apartment = Apartment;
		this.MailIndex = MailIndex;
    }

	public string ToData()
    {
		return $"{(int)_country}:{(int)_district}:{_city}:{Street}:{Home}:{Apartment}:{MailIndex}";
    }
	static public BuyerAddress GetData(string data)
    {
		string[] a = data.Split(":");
		return new BuyerAddress(
			(Data.ISO_3166_1)int.Parse(a[0]),
			(Data.ISO_3166_2)int.Parse(a[1]),
			int.Parse(a[2]),
			a[3],
			int.Parse(a[4]),
			int.Parse(a[5]),
			uint.Parse(a[6])
			);
    }

    public override string ToString()
    {
        return $"Страна: {Country}; Область: {District}; Город: {City}; Улица: {Street}; Дом: {Home}; Квартира: {Apartment}; Почтовый индекс: {MailIndex};";
	}
}


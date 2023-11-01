
public class Item 
{
	public enum Type
	{
		Clothes,
		Cosmetics,
		Hygiene,
		Tableware,
		Chemistry,
		Another
	}
	private String name;
	private String manufacturer;
	private double price = 0;
	private Type type;

	public String getName()
	{
		return name;
	}
	public String getManufacturer()
	{
		return manufacturer;
	}
	public double getPrice()
	{
		return price;
	}
	public boolean setPrice(double price)
	{
		if(price < 0)
		{
			return false;
		}
		this.price = price;
		return true;
	}
	public Type getType()
	{
		return type;
	}
	@Override
	public boolean equals(Object obj) 
	{
		if(obj instanceof Item)
		{
			Item I = (Item)obj;
			return 
					I.name.equals(name) && 
					I.manufacturer.equals(manufacturer) && 
					I.type == type && 
					I.price == price;
		}
		return false;
	}
	@Override
	public String toString()
	{
		return name + " " + type.toString();
	}
	@Override
	public int hashCode() 
	{
		return name.hashCode() * manufacturer.hashCode();
	}
	public Item(String name, String manufacturer, Type type, double price)
	{
		this.name = name;
		this.manufacturer = manufacturer;
		this.type = type;
		setPrice(price);
	}
	public Item(String name, String manufacturer, double price)
	{
		this(name, manufacturer, Type.Another, price);
	}
	public Item(String name, String manufacturer, Type type)
	{
		this(name, manufacturer, type, 0);
	}
	public Item(String name, String manufacturer)
	{
		this(name, manufacturer, Type.Another, 0);
	}
}

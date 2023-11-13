import java.util.HashMap;
import java.util.Map;

public class Shop 
{
	private Map<Item, Integer> items = new HashMap<>();
	private String name;
	
	public int getCountItem()
	{
		int  i = 0;
		for(Map.Entry<Item, Integer> entry: items.entrySet())
		{
			i += entry.getValue();
		}
		return i;
	}
	public int getCountItem(Item item)
	{
		if(items.containsKey(item)) 
		{
			return items.get(item);
		}
		return 0;
	}
	public boolean setCountItem(Item item, int count)
	{
		if(items.containsKey(item) && count >= 0)
		{
			if(count == 0)
			{
				items.remove(item);
			}
			else
			{
				items.put(item, count);
			}
			return true;
		}
		return false;
	}
	public int getSizeItems()
	{
		return items.size();
	}
}

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
	public boolean addItem(Item item, int count) {
		if(items.containsKey(item) || count < 0) return false;
		items.put(item, count);
		return true;
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
	public Item getItem(int index) {
		if(items.size() > index && index >= 0) {
			int i = 0;
			for(Map.Entry<Item, Integer> item: items.entrySet()) {
				if(i == index) return item.getKey();
				i++;
			}
		}
		return null;
	}
	public int getCountTypeItems()
	{
		return items.size();
	}
	public String getName() {
		return name;
	}
	public Shop(String name) {
		this.name = name;
	}
}

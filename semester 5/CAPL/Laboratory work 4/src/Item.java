import java.util.Date;

public class Item {
	private String name = "";
	private String surname = "";
	private String patronymic = "";
	private double Height = 0;
	private double Width = 0;
	private Date birth = null;
	private long phone = 0;
	private Address address = null;
	private long card = 0;
	private long bank = 0;
	
	
	
	public String getPatronymic() {
		return patronymic;
	}
	public void setPatronymic(String patronymic) {
		this.patronymic = patronymic;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getSurname() {
		return surname;
	}
	public void setSurname(String surname) {
		this.surname = surname;
	}
	public double getHeight() {
		return Height;
	}
	public void setHeight(double height) {
		if(height > 0) {
			Height = height;
		}
	}
	public double getWidth() {
		return Width;
	}
	public void setWidth(double width) {
		if(width > 0) {
			Width = width;
		}
	}
	public long getPhone() {
		return phone;
	}
	public void setPhone(long phone) {
		if(phone > 0) {
			this.phone = phone;
		}
	}
	public Date getBirth() {
		return birth;
	}
	public void setBirth(Date birth) {
		this.birth = birth;
	}
	public Address getAddress() {
		return address;
	}
	public void setAddress(Address address) {
		this.address = address;
	}
	public long getCard() {
		return card;
	}
	public void setCard(long card) {
		if(card > 0) {
			this.card = card;
		}
	}
	public long getBank() {
		return bank;
	}
	public void setBank(long bank) {
		if(bank > 0) {
			this.bank = bank;
		}
	}
	

	@SuppressWarnings("deprecation")
	public static Item parse(String str)
	{
		String[] arr = str.split(";");
		Item i = new Item();
		int j = 0;
		if(arr.length > j) {
			i.setName(arr[j]);
			j++;
		}
		if(arr.length > j) {
			i.setSurname(arr[j]);
			j++;
		}
		if(arr.length > j) {
			i.setPatronymic(arr[j]);
			j++;
		}
		if(arr.length > j) {
			try {
				double a = Double.parseDouble(arr[j]);
				i.setHeight(a);
			} catch (Exception e) { }
			j++;
		}
		if(arr.length > j) {
			try {
				double a = Double.parseDouble(arr[j]);
				i.setWidth(a);
			} catch (Exception e) { }
			j += 3;
		}
		if(arr.length > j) {
			try {
				int d = Integer.parseInt(arr[j - 2]);
				int m = Integer.parseInt(arr[j - 1]);
				int y = Integer.parseInt(arr[j]);
				i.setBirth(new Date(y, m, d));
			} catch (Exception e) { }
			j++;
		}
		if(arr.length > j) {
			try {
				long a = Long.parseLong(arr[j]);
				i.setPhone(a);
			} catch (Exception e) { }
			j += 8;
		}
		if(arr.length > j) {
			Address a = new Address();
			a.setCountry(arr[j - 7]);
			a.setArea(arr[j - 6]);
			a.setDistrict(arr[j - 5]);
			a.setCity(arr[j - 4]);
			a.setStreet(arr[j - 3]);
			a.setHome(arr[j - 2]);
			try {
				int b = Integer.parseInt(arr[j - 1]);
				a.setFlat(b);
				int c = Integer.parseInt(arr[j]);
				a.setPostalCode(c);
			} catch (Exception e) { }
			i.setAddress(a);
			j++;
		}
		if(arr.length > j) {
			try {
				long a = Long.parseLong(arr[j]);
				i.setCard(a);
			} catch (Exception e) { }
			j++;
		}
		if(arr.length > j) {
			try {
				long a = Long.parseLong(arr[j]);
				i.setBank(a);
			} catch (Exception e) { }
		}
		return i;
	}
}

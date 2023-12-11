public class Address {
	private String country = "";
	private String area = "";
	private String district = "";
	private String city = "";
	private String street = "";
	private String home = "";
	private int flat = 0;
	private int postalCode = 0;
	public String getCountry() {
		return country;
	}
	public void setCountry(String country) {
		this.country = country;
	}
	public String getArea() {
		return area;
	}
	public void setArea(String area) {
		this.area = area;
	}
	public String getDistrict() {
		return district;
	}
	public void setDistrict(String district) {
		this.district = district;
	}
	public String getCity() {
		return city;
	}
	public void setCity(String city) {
		this.city = city;
	}
	public String getHome() {
		return home;
	}
	public void setHome(String home) {
		this.home = home;
	}
	public int getPostalCode() {
		return postalCode;
	}
	public void setPostalCode(int postalCode) {
		if(postalCode > 0) {
			this.postalCode = postalCode;
		}
	}
	public int getFlat() {
		return flat;
	}
	public void setFlat(int flat) {
		if(flat > 0) {
			this.flat = flat;
		}
	}
	public String getStreet() {
		return street;
	}
	public void setStreet(String street) {
		this.street = street;
	}
	
	
	@Override
	public String toString() {
		String str = "";
		if(country != null)
		{
			str += country;
			
		}
		str += ";";
		if(area != null)
		{
			str += area;
			
		}
		str += ";";
		if(district != null)
		{
			str += district;
		}
		str += ";";
		if(city != null)
		{
			str += city;
		}
		str += ";";
		if(street != null)
		{
			str += street;
		}
		str += ";";
		if(home != null)
		{
			str += home;
		}
		str += ";";
		str += flat + ";";
		str += postalCode + ";";
		return str;
	}
}

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;

public class Client {
	private String name;
	private String surname;
	private String phone;
	private List<Car> cars = new ArrayList<>();
	public String getName() { return name; }
	public void setName(String name) { this.name = name; }
	public String getSurname() { return surname; }
	public void setSurname(String surname) { this.surname = surname; }
	public String getPhone() { return phone; }
	public void setPhone(String phone) { this.phone = phone; }
	static Comparator<Car> comparatorCar = Comparator.comparing(Car::getBrand).
			thenComparing(Car::getModel);
	
	
	public Client(String surname, String name, String phone) {
		this.name = name;
		this.surname = surname;
		this.phone = phone;
	}
	
	public void removeCar(Car car) { cars.remove(car); }
	public void removeCar(int index) { cars.remove(index); }
	public Car getCar(int index) { return cars.get(index); } 
	public void addCar(Car car) { cars.add(car); }
	public int countCar() { return cars.size(); }
	
	
	
	public String getInfo() {
		StringBuilder sBuilder = new StringBuilder();
		sBuilder.append(surname);
		sBuilder.append(" ");
		sBuilder.append(name);
		sBuilder.append(";\nУ него есть следующие машины");
		cars.sort(comparatorCar);
		for(Car car: cars) {
			sBuilder.append("\n");
			sBuilder.append(car.getInfo());
			sBuilder.append(";");
		}
		return sBuilder.toString();
	}
}

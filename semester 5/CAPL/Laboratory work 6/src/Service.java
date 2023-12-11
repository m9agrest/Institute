import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;

public class Service {
	private String name;
	private List<Client> clients = new ArrayList<>();
	private List<Car> cars = new ArrayList<>();
	static Comparator<Client> comparatorClient = Comparator.comparing(Client::getSurname).
			thenComparing(Client::getName).
			thenComparing(Client::countCar);
	static Comparator<Car> comparatorCar = Comparator.comparing(Car::getBrand).
			thenComparing(Car::getModel);
	
	
	public void removeCar(Car car) { cars.remove(car); }
	public void removeCar(int index) { cars.remove(index); }
	public Car getCar(int index) { return cars.get(index); } 
	public void addCar(Car car) { cars.add(car); }
	public int countCar() { return cars.size(); }

	public void removeClient(Client client) { clients.remove(client); }
	public void removeClient(int index) { clients.remove(index); }
	public Client getClient(int index) { return clients.get(index); } 
	public void addClient(Client client) { clients.add(client); }
	public int countClient() { return clients.size(); }
	
	public String getName() { return name; }
	public void setName(String name) { this.name = name; }
	

	public String getInfo() {
		StringBuilder sBuilder = new StringBuilder();
		sBuilder.append("Автосервис ");
		sBuilder.append(name);
		sBuilder.append(";\nВ автосервисе есть следующие машины:");
		cars.sort(comparatorCar);
		for(Car car: cars) {
			sBuilder.append("\n");
			sBuilder.append(car.getInfo());
			sBuilder.append(";");
		}
		return sBuilder.toString();
	}
	public String getAllInfo() {
		StringBuilder sBuilder = new StringBuilder();
		sBuilder.append(getInfo());
		sBuilder.append("\nВ автосервисе, есть следующие клиенты:");
		clients.sort(comparatorClient);
		for(Client client: clients) {
			sBuilder.append("\n");
			sBuilder.append(client.getInfo());
		}
		return sBuilder.toString();
	}
	
	public Service(String name) {
		this.name = name;
	}
}

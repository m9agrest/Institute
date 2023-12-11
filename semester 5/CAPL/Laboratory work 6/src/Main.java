
public class Main {

	public static void main(String[] args) {
		Car car1 = new Car("Lada","Granta");
		Car car2 = new Car("Audi","R8");
		Car car3 = new Car("BMW","X6");
		Car car4 = new Car("Audi","A8");
		Car car5 = new Car("Lada","Vesta");
		
		Client client1 = new Client("Петров", "Петр", "88005553535");
		client1.addCar(car5);
		client1.addCar(car1);

		Client client2 = new Client("Васичкин", "Вася", "88005553535");
		client2.addCar(car2);
		client2.addCar(car4);
		
		Service service = new Service("CarX");
		service.addClient(client1);
		service.addClient(client2);
		service.addCar(car1);
		service.addCar(car2);
		service.addCar(car3);
		service.addCar(car4);
		service.addCar(car5);
		System.out.println(service.getAllInfo());
	}

}

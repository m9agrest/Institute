import java.util.Scanner;

public class Main
{
	public static void main(String[] args)
	{
		Scanner scanner = new Scanner(System.in);

		System.out.print("Введите x: ");
		double x = scanner.nextDouble();
		System.out.print("Введите y: ");
		double y = scanner.nextDouble();

		double a = (Math.pow(1, y) + Math.sin(Math.pow(y, 2))) / 2;
		System.out.println("a = " + a);

		double b = Math.sqrt(a * (2 / 4)) + (4 * x) / y;
		System.out.println("b = " + b);
	}
}
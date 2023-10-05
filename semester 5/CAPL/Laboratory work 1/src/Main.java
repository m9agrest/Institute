import java.util.Scanner;

public class Main
{
	static Scanner scanner = new Scanner(System.in);
	public static void main(String[] args)
	{
		double x = get("Введите x: ");
		double y = get("Введите y: ");

		System.out.println("Результаты значений по заданию:");
		double a = (Math.pow(1, y) + Math.sin(Math.pow(y, 2))) / 2;
		System.out.println("a = " + a);
		if(y != 0 && a >= 0)
		{
			double b = Math.sqrt(a * (2 / 4)) + (4 * x) / y;
			System.out.println("b = " + b);
		}
		else if(y == 0)
		{
			System.out.println("Y равен нулю, деление невозможно!");
		}
		else
		{
			System.out.println("X отрицательный, извленчения корня невозможно!");
		}
	}
	static double get(String text)
	{
		System.out.print(text);
		double a = 0;
		while(true)
		{
			try
			{
				a = scanner.nextDouble();
				break;
			}
			catch (Exception e)
			{
				System.out.println("Ошибка ввода, попробуйте снова!");
				scanner.nextLine();
			}
		}
		scanner.nextLine();
		return a;
	}

}
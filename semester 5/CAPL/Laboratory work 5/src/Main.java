import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Random;

public class Main
{
	public static void main(String[] args)
	{
		try
		{
			task6();
		}catch(Exception e) {}
	}
	
	

	static void task4()
	{
		List<Integer> list1 = new ArrayList<Integer>();
		List<Integer> list2 = new LinkedList<Integer>();
		Random rand = new Random(1);
		for(int i = 0; i < 1000000; i++)
		{
			int r = rand.nextInt();
			list1.add(r);
			list2.add(r);
		}
		task4(list1);
		task4(list2);
	}
	static void task4(List<Integer> list)
	{
		long start = System.currentTimeMillis();
		Random rand = new Random(20);
		for(int i = 0; i < 100000; i++)
		{
			list.get(rand.nextInt(list.size()));
		}
		long end = System.currentTimeMillis();
		double time = (end - start) / 1000d;
		System.out.println(time + "sec.");
	}
	

	static void task5() throws IOException
	{
		List<Student> students = new ArrayList<Student>();
		
		String[] arr1 = Files.readString(Paths.get("student.txt")).split("\n");
		for(int i = 0; i < arr1.length; i++) {
			String[] arr2 = arr1[i].split(":");
			students.add(task5(arr2[0], arr2[1]));
		}
		
		Student.printStudents(students);
		
		

		List<Student> students2 = new ArrayList<Student>();
		for(Student student: students)
		{
			if(student.getAverageEvaluations() >= 3)
			{
				student.setCourse(student.getCourse() + 1);
				students2.add(student);
			}
		}
		
		System.out.println("\n");
		Student.printStudents(students2);
		
	}
	static Student task5(String name, String group)
	{
		Random random = new Random(name.hashCode() + group.hashCode());
		Student student = new Student(name, group,  random.nextInt(4) + 1);
		student.getEvaluations().put(Student.Course.mathematics, random.nextInt(5) + 1);
		student.getEvaluations().put(Student.Course.physics, random.nextInt(5) + 1);
		student.getEvaluations().put(Student.Course.physical, random.nextInt(5) + 1);
		student.getEvaluations().put(Student.Course.history, random.nextInt(5) + 1);
		student.getEvaluations().put(Student.Course.biology, random.nextInt(5) + 1);
		student.getEvaluations().put(Student.Course.chemistry, random.nextInt(5) + 1);
		student.getEvaluations().put(Student.Course.programming, random.nextInt(5) + 1);
		student.getEvaluations().put(Student.Course.philosophy, random.nextInt(5) + 1);
		student.getEvaluations().put(Student.Course.cultural, random.nextInt(5) + 1);
		return student;
	}



	static void task6() throws IOException
	{
		List<Item> items = new ArrayList<Item>();
		
		String[] arr1 = Files.readString(Paths.get("item.txt")).split("\n");
		for(int i = 0; i < arr1.length; i++) {
			items.add(Item.parse(arr1[i]));
		}
		
		System.out.println(Item.printSorted(items));
	}
	
}

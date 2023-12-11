import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.HashMap;
import java.util.List;
import java.util.Map;


public class Student {
	public Student(String name, String group)
	{
		this.group = group;
		this.name = name;
	}
	public Student(String name, String group, int course)
	{
		this(name, group);
		this.course = course;
	}
	private String name;
	private String group;
	private int course = 1;
	private Map<Course, Integer> evaluations = new HashMap<Course, Integer>();
	public enum Course
	{
		mathematics,
		physics,
		physical,
		history,
		biology,
		chemistry,
		programming,
		philosophy,
		cultural,
	}
	public String getName() { return name; }
	public void setName(String name) { this.name = name; }
	public String getGroup() { return group; }
	public void setGroup(String group) { this.group = group; }
	public int getCourse() { return course; }
	public void setCourse(int course) { this.course = course; }
	public Map<Course, Integer> getEvaluations() { return evaluations; }
	
	public double getAverageEvaluations()
	{
		double a = 0;
		for(Map.Entry<Course, Integer> b: evaluations.entrySet())
		{
			a += b.getValue();
		}
		a /= evaluations.size();
		return a;
	}


	static public List<Student> getStudents(List<Student> students, int course)
	{
		List<Student> students2 = new ArrayList<Student>();
		for(Student student: students)
		{
			if(student.getCourse() == course)
			{
				students2.add(student);
			}
		}
		return students2;
	}
	static public void printStudents(List<Student> students)
	{
        Comparator<Student> comparator = Comparator.comparing(Student::getCourse);
        comparator.thenComparing(Student::getGroup);
        comparator.thenComparing(Student::getName);
        Collections.sort(students, comparator);
        
        
		for(Student student: students)
		{
			System.out.println(student);
		}
	}
	
	@Override
	public String toString() {
		
		return getCourse() + " " + getGroup() + " " + getName();
	}
}

import java.util.Arrays;
import java.util.Random;

public class Main
{
	static Random random = new Random();
	public static void main(String[] args)
	{
		int[] array = randomArray(10000, -1000, 1000);
		System.out.println("Случайный массив");
		sortAll(array);
		
		System.out.println("Отсортированный массив");
		Arrays.sort(array);
		sortAll(array);
		
		System.out.println("Массив 10%");
		randomArray(array, array.length / 10, -1000, 1000);
		sortAll(array);
		testII();
	}
	
	static void testI()
	{
		int[] array = randomArray(10, -5, 5);
		int[] arr = array.clone();
		arrayPrintln(arr);
		
		
		arr = array.clone();
		sortBubble(arr);
		arrayPrintln(arr);
		

		arr = array.clone();
		sortInserts(arr);
		arrayPrintln(arr);
		

		arr = array.clone();
		sortChoice(arr);
		arrayPrintln(arr);
		

		arr = array.clone();
		sortMerge(arr);
		arrayPrintln(arr);
		

		arr = array.clone();
		sortQuick(arr);
		arrayPrintln(arr);
	}
	
	static void testII()
	{
		int[] array = randomArray(10, -5, 5);
		System.out.print("Массив ");
		arrayPrintln(array);
		System.out.print("Массив без повторений ");
		arrayPrintln(removeDuplicates(array));
		System.out.print("Первые 3 элемента массива ");
		arrayPrintln(getFirst(array, 3));
		System.out.print("Последние 3 элемента массива ");
		arrayPrintln(getLast(array, 3));
		System.out.print("Кол-во повторений ");
		System.out.println(countIdentic(array));
	}
	
	public static void sortAll(int[] array)
	{
		long start;
		long end;
		double time;
		
		
		start = System.currentTimeMillis();
		sortBubble(array.clone());
		end = System.currentTimeMillis();
		time = (end - start) / 1000d;
		System.out.println("sortBubble = " + time + "sec.");
		

		start = System.currentTimeMillis();
		sortInserts(array.clone());
		end = System.currentTimeMillis();
		time = (end - start) / 1000d;
		System.out.println("sortInserts = " + time + "sec.");
		

		start = System.currentTimeMillis();
		sortChoice(array.clone());
		end = System.currentTimeMillis();
		time = (end - start) / 1000d;
		System.out.println("sortChoice = " + time + "sec.");
		

		start = System.currentTimeMillis();
		sortMerge(array.clone());
		end = System.currentTimeMillis();
		time = (end - start) / 1000d;
		System.out.println("sortMerge = " + time + "sec.");
		

		start = System.currentTimeMillis();
		sortQuick(array.clone());
		end = System.currentTimeMillis();
		time = (end - start) / 1000d;
		System.out.println("sortQuick = " + time + "sec.");
		

		start = System.currentTimeMillis();
		Arrays.sort(array.clone());
		end = System.currentTimeMillis();
		time = (end - start) / 1000d;
		System.out.println("Arrays.sort = " + time + "sec.");
	}
	
	
	
	public static void randomArray(int[] array, int randCount, int min, int max)
	{
		if(randCount <= array.length)
		{
			if(min > max)
			{
				int a = max;
				max = min;
				min = a;
			}
			max -= min - 1;
			for(int i = 0; i < randCount; i++)
			{
				array[i] = random.nextInt(max) + min;
			}
		}
	}
	public static int[] randomArray(int length, int min, int max)
	{
		if(min > max)
		{
			int a = max;
			max = min;
			min = a;
		}
		max -= min - 1;
		int[] array = new int[length];
		for(int i = 0; i < length; i++)
		{
			array[i] = random.nextInt(max) + min;
		}
		return array;
	}
	public static void arrayPrintln(int[] array)
	{
		for(int i = 0; i < array.length; i++)
		{
			System.out.print(array[i] + " ");
		}
		System.out.println();
	}
	
	public static void sortBubble(int[] array)
	{
		boolean sorted = false;
		int temp;
		while(!sorted)
		{
			sorted = true;
			for (int i = 0; i < array.length - 1; i++)
			{
				if (array[i] > array[i+1])
				{
					temp = array[i];
					array[i] = array[i+1];
					array[i+1] = temp;
					sorted = false;
				}
			}
		}
	}
	public static void sortInserts(int[] array)
	{
		for (int i = 1; i < array.length; i++)
		{
			int current = array[i];
			int j = i - 1;
			while(j >= 0 && current < array[j])
			{
				array[j+1] = array[j];
				j--;
			}
			array[j+1] = current;
		}
	}
	public static void sortChoice(int[] array)
	{
		for (int i = 0; i < array.length; i++)
		{
			int min = array[i];
			int minId = i;
			for (int j = i+1; j < array.length; j++) 
			{
				if (array[j] < min) 
				{
					min = array[j];
					minId = j;
				}
			}
			// замена
			int temp = array[i];
			array[i] = min;
			array[minId] = temp;
		}
	}
	public static void sortMerge(int[] array)
	{
		sortMerge(array, 0, array.length - 1);
	}
	public static void sortQuick(int[] array)
	{
		sortQuick(array, 0, array.length - 1);
	}

	public static int[] removeDuplicates(int[] array)
	{
		if (array == null || array.length == 0) 
		{
			return array;
		}
		array = array.clone();
		Arrays.sort(array);
		int[] uniqueValues = new int[array.length];
		int uniqueIndex = 0;

		for (int i = 0; i < array.length; i++) 
		{
			if (i == 0 || array[i] != array[i - 1]) 
			{
				uniqueValues[uniqueIndex] = array[i];
				uniqueIndex++;
			}
		}
		int[] arr = new int[uniqueIndex];
		for(int i = 0; i < uniqueIndex; i++)
		{
			arr[i] = uniqueValues[i];
		}
		return arr;
	}
	public static int[] getFirst(int[] array, int n)
	{
		int[] result = new int[n];
	    System.arraycopy(array, 0, result, 0, n);
	    return result;
	}
	public static int[] getLast(int[] array, int n)
	{
	    int[] result = new int[n];
	    System.arraycopy(array, array.length - n, result, 0, n);
	    return result;
	}
	public static int countIdentic(int[] array)
	{
        return array.length - removeDuplicates(array).length;
	}
	
	
	
	static void sortMerge(int[] array, int left, int right)
	{
		if (right <= left) return;
		int mid = (left+right)/2;
		sortMerge(array, left, mid);
		sortMerge(array, mid+1, right);
		merge(array, left, mid, right);

	}
	static void merge(int[] array, int left, int mid, int right)
	{
		int lengthLeft = mid - left + 1;
		int lengthRight = right - mid;
		int leftArray[] = new int [lengthLeft];
		int rightArray[] = new int [lengthRight];
		// копируем отсортированные массивы во временные
		for (int i = 0; i < lengthLeft; i++)
			leftArray[i] = array[left+i];
		for (int i = 0; i < lengthRight; i++)
			rightArray[i] = array[mid+i+1];
		// итераторы содержат текущий индекс временного подмассива
		int leftIndex = 0;
		int rightIndex = 0;
		// копируем из leftArray и rightArray обратно в массив
		for (int i = left; i < right + 1; i++) 
		{
			// если остаются нескопированные элементы в R и L, копируем минимальный
			if (leftIndex < lengthLeft && rightIndex < lengthRight)
			{
				if (leftArray[leftIndex] < rightArray[rightIndex])
				{
					array[i] = leftArray[leftIndex];
					leftIndex++;
				}
				else 
				{
					array[i] = rightArray[rightIndex];
					rightIndex++;
				}
			}
			// если все элементы были скопированы из rightArray, скопировать остальные из leftArray
			else if (leftIndex < lengthLeft) 
			{
				array[i] = leftArray[leftIndex];
				leftIndex++;
			}
			// если все элементы были скопированы из leftArray, то скопировать остальные из rightArray
			else if (rightIndex < lengthRight) 
			{
				array[i] = rightArray[rightIndex];
				rightIndex++;
			}
		}
	}
	static int partition(int[] array, int begin, int end) {
		int pivot = end;
		int counter = begin;
		for (int i = begin; i < end; i++) 
		{
			if (array[i] < array[pivot]) 
			{
				int temp = array[counter];
				array[counter] = array[i];
				array[i] = temp;
				counter++;
			}
		}
		int temp = array[pivot];
		array[pivot] = array[counter];
		array[counter] = temp;
		return counter;
	}
	static void sortQuick(int[] array, int begin, int end)
	{
		if (end <= begin) return;
		int pivot = partition(array, begin, end);
		sortQuick(array, begin, pivot-1);
		sortQuick(array, pivot+1, end);
	}

}

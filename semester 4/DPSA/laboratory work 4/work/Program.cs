Random r = new Random(100);
int[] arr = new int[100];
for(int i = 0; i < arr.Length; i++)
    arr[i] = r.Next(100000);

//Console.WriteLine("Search 34\ni = " + test.search(arr, 56254) + "\n\nArray:");
//test.print(arr);
test.a(130);
class test
{
    static public int search(int[] arr, int number, int i)
    {
        if (i >= 0 && i < arr.Length)
        {
            if (arr[i] != number)
            {
                i++;
                return search(arr, number, i);
            }
            return i;
        }
        else
        {
            return -1;
        }
    }
    static public int search(int[] arr, int number) => search(arr, number, 0);
    
    static public void a(int n)
    {
        if (n < 2)
            Console.Write(n);
        else
        {
            a(n / 2);
            Console.Write(n % 2);
        }
    }
    static public void print(int[] arr, int i)
    {
        if(i < arr.Length && i >= 0)
        {
            Console.Write(arr[i]);
            i++;
            if (i < arr.Length)
            {
                Console.Write(" ");
                print(arr, i);
            }
        }
    }
    static public void print(int[] arr) => print(arr, 0);
}

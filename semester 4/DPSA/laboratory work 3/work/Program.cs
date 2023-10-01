using System.Diagnostics;

int seed = 20;
int min = -1000000;
int max = min * -1;

/*
Search(10);
Search(100);
Search(1000);
Search(10000);
Search(100000);
Search(1000000);
Search(10000000);
Search(100000000);
Search(1000000000);
*/
void Search(int l)
{
    int count = 0;
    int search = 0;
    Console.WriteLine("Array Length = " + l);
    Stopwatch stopwatch = new Stopwatch();
    int[] arr = Rand(l, ref search);

    stopwatch.Start();
    Search1(arr, search, ref count);
    stopwatch.Stop();
    ConsoleWrite(count, stopwatch);

    int[] arr2 = Sort(arr);
    stopwatch.Restart();
    Search2(arr2, search, ref count);
    stopwatch.Stop();
    ConsoleWrite(count, stopwatch);

    BST arr3 = new BST(arr);
    stopwatch.Restart();
    Search3(arr3, search, ref count);
    stopwatch.Stop();
    ConsoleWrite(count, stopwatch);
}

rec(0);
void rec(int i)
{
    Console.WriteLine(i);
    if (i < 10)
    {
        //i++;
        //++i;
        rec(++i);
    }
    Console.WriteLine(i);
}










int Search1(int[] arr, int digit, ref int count)
{
    count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        count++;
        if (arr[i] == digit)
            return i;
    }
    return -1;
}
int Search2(int[] arr, int digit, ref int count)
{
    count = 0;
    int L = arr.Length / 2;
    int l = L;
    while(L > 0)
    {
        L /= 2;
        count++;
        if (arr[l] > digit)
            l -= L;
        else if (arr[l] < digit)
            l += L;
        else
            return l;
    }
    return -1;
}
int Search3(BST a, int digit, ref int count)
{
    count = 0;
    while (a != null)
    {
        count++;
        if (digit > a.Digit)
            a = a.Right;
        else if (digit < a.Digit)
            a = a.Left;
        else
            return a.Index;
    }
    return -1;
}
int[] Rand(int length, ref int search)
{
    Random random = new Random(seed);
    int I = random.Next(0, length);
    int[] arr = new int[length];
    for(int i = 0; i < length; i++)
    {
        arr[i] = random.Next(min, max + 1);
        if(I == i)
            search = arr[i];
    }
    return arr;
}
int[] Sort(int[] arr)
{
    int maxV = arr.Max();
    int minV = arr.Min();
    int[] B = new int[maxV - minV + 1];
    for (int i = 0; i < arr.Length; i++)
    {
        B[arr[i] - minV]++;
    }
    int q = 0;
    int[] newArr = new int[arr.Length];
    for (int i = 0; i < (maxV - minV + 1); ++i)
    {
        for (int j = 0; j < B[i]; ++j)
        {
            newArr[q++] = minV + i;
        }
    }
    return newArr;
}
void ConsoleWrite(int count, Stopwatch stopwatch)
{
    Console.WriteLine(
        $"{stopwatch.Elapsed.Seconds:00}" + "." +
        $"{stopwatch.Elapsed.Microseconds:000000}" + "sec;" +
        " Count = " + count
        ) ;
}
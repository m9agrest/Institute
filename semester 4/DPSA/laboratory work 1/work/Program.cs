using System;
using System.Collections;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

Random rnd = new Random(111);
Start();




void Start()
{
    for(int j = 2; j < 3; j++)
    {
        switch (j)
        {
            case 0:
                Console.WriteLine("GnomeSort");
                break;
            case 1:
                Console.WriteLine("BubleSort");
                break;
            case 2:
                Console.WriteLine("CountingSort");
                break;
        }
        for (int i = 10000000; i <= 1000000000; i *= 10)
        {
            Console.WriteLine($"\ni = {i}");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("         |       Время       |     Сравнений     |    Перестановок   |");
            Console.WriteLine("----------------------------------------------------------------------");
            long timeMin = 0;
            long timeMax = 0;
            double timeAverage = 0;
            long comparisonsMin = 0;
            long comparisonsMax = 0;
            double comparisonsAverage = 0;
            long permutationsMin = 0;
            long permutationsMax = 0;
            double permutationsAverage = 0;
            for (int I = 0; I < 1; I++)
            {
                Stopwatch stopwatch = new Stopwatch();
                int[] array = Generation(i, -1000000, 1000000);
                int[] arrayCopy = Copy(array);
                stopwatch.Start();
                switch (j)
                {
                    case 0:
                        GnomeSort(array);
                        break;
                    case 1:
                        BubleSort(array);
                        break;
                    case 2:
                        CountingSort(array);
                        break;
                }
                stopwatch.Stop();
                long comparisons = 0;
                long permutations = 0;
                switch (j)
                {
                    case 0:
                        _GnomeSort(arrayCopy, ref comparisons, ref permutations);
                        break;
                    case 1:
                        _BubleSort(arrayCopy, ref comparisons, ref permutations);
                        break;
                    case 2:
                        _CountingSort(arrayCopy, ref comparisons, ref permutations);
                        break;
                }
                if(I==0)
                {
                    info("Значение", stopwatch.ElapsedMilliseconds, comparisons, permutations);
                    comparisonsMin = comparisons;
                    permutationsMin = permutations;
                    timeMin = stopwatch.ElapsedMilliseconds;
                }
                if(timeMin > stopwatch.ElapsedMilliseconds)
                    timeMin= stopwatch.ElapsedMilliseconds;
                if(timeMax < stopwatch.ElapsedMilliseconds)
                    timeMax= stopwatch.ElapsedMilliseconds;
                timeAverage += stopwatch.ElapsedMilliseconds / 5.0;

                if (comparisonsMin > comparisons)
                    comparisonsMin = comparisons;
                if (comparisonsMax < comparisons)
                    comparisonsMax = comparisons;
                comparisonsAverage += comparisons / 5.0;

                if (permutationsMin > permutations)
                    permutationsMin = permutations;
                if (permutationsMax < permutations)
                    permutationsMax = permutations;
                permutationsAverage += permutations / 5.0;
            }
            info("Минимум", timeMin, comparisonsMin, permutationsMin);
            info("Максимум", timeMax, comparisonsMax, permutationsMax);
            info("Среднее", (long)timeAverage, (long)comparisonsAverage, (long)permutationsAverage);
        }
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
    }
}
void info(string text, long Milliseconds, long comparisons, long permutations)
{
    Console.WriteLine(System.String.Format("{0,9}|{1,19}|{2,19}|{3,19}|", text, Milliseconds / 1000.0, comparisons, permutations));
    Console.WriteLine("----------------------------------------------------------------------");
}
int[] Generation(int Length, int min, int max)
{
    int[] array = new int[Length];
    for(int i = 0; i < Length; i++)
        array[i] = rnd.Next(min, max);
    return array;
}
int[] Copy(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
        arrayCopy[i] = array[i];
    return arrayCopy;
}
void Swap(ref int A, ref int B)
{
    int C = A;
    A = B;
    B = C;
}
void _GnomeSort(int[] array, ref long comparisons, ref long permutations)
{
    int i = 1;
    int j = 2;
    while (i < array.Length)
    {
        comparisons++;
        if (i > 0 && array[i] > array[i - 1])
        {
            i = j;
            j++;
        }
        else
        {
            permutations++;
            Swap(ref array[i], ref array[i - 1]);
            i--;
            if (i == 0)
            {
                i = j;
                j++;
            }
        }
    }
}
void _BubleSort(int[] array, ref long comparisons, ref long permutations)
{
    for (int k = 0; k < array.Length; k++)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            comparisons++;
            if (array[i] > array[i + 1])
            {
                permutations++;
                Swap(ref array[i + 1], ref array[i]);
            }
        }
    }
}
void _CountingSort(int[] array, ref long comparisons, ref long permutations)
{
    int maxV = array.Max();
    int minV = array.Min();
    int[] B = new int[maxV - minV + 1];
    for(int i = 0; i < array.Length; i++)
    {
        B[array[i] - minV]++;
    }
    int q = 0;
    for (int i = 0; i < (maxV - minV + 1); ++i)
    {
        for (int j = 0; j < B[i]; ++j)
        {
            permutations++;
            array[q++] = minV + i;
        }
    }
}
void GnomeSort(int[] array)
{
    int i = 1;
    int j = 2;
    while (i < array.Length)
    {
        if (i > 0 && array[i] > array[i - 1])
        {
            i = j;
            j++;
        }
        else
        {
            Swap(ref array[i], ref array[i - 1]);
            i--;
            if (i == 0)
            {
                i = j;
                j++;
            }
        }
    }
}
void BubleSort(int[] array)
{
    for (int k = 0; k < array.Length; k++)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                Swap(ref array[i + 1], ref array[i]);
            }
        }
    }
}
void CountingSort(int[] array)
{
    int maxV = array.Max();
    int minV = array.Min();
    int[] B = new int[maxV - minV + 1];
    for (int i = 0; i < array.Length; i++)
    {
        B[array[i] - minV]++;
    }
    int q = 0;
    for (int i = 0; i < (maxV - minV + 1); ++i)
    {
        for (int j = 0; j < B[i]; ++j)
        {
            array[q++] = minV + i;
        }
    }
}
Thread t1 = new Thread(func1);
t1.Priority = ThreadPriority.Lowest;
Thread t2 = new Thread(func2);
t2.Priority = ThreadPriority.BelowNormal;
Thread t3 = new Thread(func3);
t3.Priority = ThreadPriority.Highest;

t1.Start();
t2.Start();
t3.Start();

void func1() => func(0, 9);
void func2() => func(10, 19);
void func3() => func(100, 120);
void func(int a, int b)
{
    for(int i = a; i <= b; i++)
        Console.Write(i + " ");
}
using Nito.Collections;
using System.Collections;
using System.Collections.Generic;

class program
{
    static void Main(string[] arg)
    {
        Console.WriteLine("Работа с Stack");
        StackTask1();
        StackTask2(10);
        StackTask3(3);
        Console.WriteLine("\n\nРабота с Queue");
        QueueTask1(10);
        QueueTask2(10);
        QueueTask3(10);
        Console.WriteLine("\n\nРабота с Deque");
        DequeTask1(10);
    }
    



    static int Get(Stack<int> stack, int i)
    {
        if(i < stack.Count)
        {
            Stack<int> N = new Stack<int>();
            int r = 0;
            for (int I = 0; I <= i; I++)
            {
                r = stack.Pop();
                N.Push(r);
            }
            for (int I = 0; I <= i; I++)
            {
                int b = N.Pop();
                stack.Push(b);
            }
            return r;
        }
        throw new Exception();
    }
    static int Get(Queue<int> stack, int i)
    {
        if (i < stack.Count)
        {
            int r = 0;
            for (int I = 0; I < stack.Count; I++)
            {
                int b = stack.Dequeue();
                if (i == I)
                    r = b;
                stack.Enqueue(b);
            }
            return r;
        }
        throw new Exception();
    }
    static int Get(Deque<int> stack, int i)
    {
        if(i < stack.Count)
        {
            int r = 0;
            for(int I = 0; I < stack.Count; I++)
            {
                int b = stack.RemoveFromFront();
                if (i == I)
                    r = b;
                stack.AddToBack(b);
            }
            return r;
        }

        throw new Exception();
    }


    static void StackTask1()
    {
        Console.WriteLine("Задание 1");
        Console.WriteLine("Задание 1.1");
        Stack<int> stack = new Stack<int>();
        for(int i = 0; i < 8; i++)
        {
            stack.Push(Rand());
        }
        Console.WriteLine(String(stack));

        //stack.Push(stack.ElementAt(2) + stack.ElementAt(3));
        stack.Push(Get(stack, 2) + Get(stack, 3));
        Console.WriteLine(String(stack));

        Console.WriteLine("Задание 1.2");
        stack = new Stack<int>();
        for (int i = 0; i < 7; i++)
        {
            stack.Push(Rand());
        }
        Console.WriteLine(String(stack));
        //stack.Push(stack.ElementAt(3) + stack.ElementAt(4) + stack.ElementAt(5));
        stack.Push(Get(stack, 3) + Get(stack, 4) + Get(stack, 5));
        Console.WriteLine(String(stack));
    }
    static void StackTask2(int count)
    {
        Console.WriteLine("Задание 2");
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < count; i++)
        {
            stack.Push(Rand());
        }
        Console.WriteLine(String(stack));

        Stack<int> _stack = new Stack<int>();
        for(int i = 1; i < count; i += 2)
        {
            _stack.Push(Get(stack, count - i));
        }
        stack = _stack;
        Console.WriteLine("Преобразование по заданию:");
        Console.WriteLine(String(stack));
    }
    static void StackTask3(int count)
    {
        Console.WriteLine("Задание 3");
        Stack<forTask3> stack = new Stack<forTask3>();
        for (int i = 0; i < count; i++)
        {
            stack.Push(new forTask3(Rand(), Rand()));
        }
        Console.WriteLine(String(stack));
        forTask3 a = stack.Pop();
        stack.Pop();
        stack.Push(a);
        Console.WriteLine("Преобразование по заданию:");
        Console.WriteLine(String(stack));
    }

    static void QueueTask1(int count)
    {
        Console.WriteLine("Задание 1");
        Queue<int> queue = new Queue<int>();
        for(int i = 0; i < count; i++)
        {
            queue.Enqueue(Rand());
        }
        
        Console.WriteLine(String(queue));
        int max = Get(queue, 0);
        for(int i = 1; i < count; i++)
        {
            int a = Get(queue, i);
            if (a > max)
            {
                max = a;
            }
        }
        Queue<int> _queue = new Queue<int>();
        for (int i = 0; i < count; i++)
        {
            int a = Get(queue, i);
            if (i != 0)
            {
                if(Get(queue, i - 1) == max)
                {
                    a = 0;
                }
            }
            if (i < count - 1)
            {
                if (Get(queue, i + 1) == max)
                {
                    a = 0;
                }
            }
            _queue.Enqueue(a);
        }
        queue = _queue;
        Console.WriteLine("Преобразование по заданию:");
        Console.WriteLine(String(queue));
    }
    static void QueueTask2(int count)
    {
        Console.WriteLine("Задание 2");
        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < count; i++)
        {
            queue.Enqueue(Rand(-100, 100));
        }
        Console.WriteLine(String(queue));

        Queue<int> _queue = new Queue<int>();
        for (int i = 0; i < count; i++)
        {
            if (Get(queue, i) > 0)
                _queue.Enqueue(Get(queue, i) * -1);
            else
                _queue.Enqueue(Get(queue, i));

        }
        queue = _queue;

        Console.WriteLine("Преобразование по заданию:");
        Console.WriteLine(String(queue));
    }
    static void QueueTask3(int count)
    {
        Console.WriteLine("Задание 3");
        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < count; i++)
        {
            queue.Enqueue(Rand(1, 100));
        }
        Console.WriteLine(String(queue));

        Queue<int> _queue = new Queue<int>();
        int a = 1;
        for (int i = 0; i < count; i++)
        {
            a *= Get(queue, i);
        }
        _queue.Enqueue(a);
        for (int i = 0; i < count; i++)
        {
            _queue.Enqueue(Get(queue, i));
        }
        queue = _queue;

        Console.WriteLine("Преобразование по заданию:");
        Console.WriteLine(String(queue));
    }

    static void DequeTask1(int count)
    {
        Console.WriteLine("Задание 1");
        Deque<int> deque = new Deque<int>();
        for(int i = 0; i < count; i++)
        {
            deque.AddToBack(Rand());
        }
        int max = Get(deque, 0);
        for(int i = 1; i < count; i++)
        {
            if (Get(deque, i) > max)
                max = Get(deque, i);
        }
        Console.WriteLine(String(deque));

        Deque<int> _deque = new Deque<int>();
        for (int i = 0; i < count; i++)
        {
            int a = Get(deque, i);
            if (i != 0)
            {
                if (Get(deque, i - 1) == max)
                    a = 0;
            }
            if(i < count - 1)
            {
                if (Get(deque, i + 1) == max)
                    a = 0;
            }
            _deque.AddToBack(a);
        }
        deque = _deque;
        Console.WriteLine("Преобразование по заданию:");
        Console.WriteLine(String(deque));
    }


    static string String(Stack<int> stack)
    {
        string r = "";
        for(int  i = 0; i < stack.Count; i++)
        {
            r += stack.ElementAt(i) + " ";
        }
        return r;
    }
    static string String(Queue<int> queue)
    {
        string r = "";
        for (int i = 0; i < queue.Count; i++)
        {
            r += queue.ElementAt(i) + " ";
        }
        return r;
    }
    static string String(Stack<forTask3> stack)
    {
        string r = "";
        for (int i = 0; i < stack.Count; i++)
        {
            r += stack.ElementAt(i) + " ";
        }
        return r;
    }
    static string String(Deque<int> deque)
    {
        string r = "";
        for (int i = 0; i < deque.Count; i++)
        {
            r += deque.ElementAt(i) + " ";
        }
        return r;
    }
    static Random rnd = new Random();
    static int Rand() => rnd.Next(0, 100);
    static int Rand(int min, int max) => rnd.Next(min, max);
    struct forTask3
    {
        public int x;
        public int y;
        public forTask3(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString() => $"(x:{x} y:{y})";
    }
}
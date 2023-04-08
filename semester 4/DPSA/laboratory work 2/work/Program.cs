using Nito.Collections;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

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
    static void StackTask1()
    {
        Console.WriteLine("Задание 1");
        Console.WriteLine("Задание 1.1");
        Stack<int> stack = new Stack<int>();
        Stack<int> _stack = new Stack<int>();
        for (int i = 0; i < 8; i++) stack.Push(Rand());
        Console.WriteLine(String(stack));
                for (int i = 0; i < 5; i++) _stack.Push(stack.Pop());
                int a = stack.Peek() + _stack.Peek();
                for (int i = 0; i < 5; i++) stack.Push(_stack.Pop());
                stack.Push(a);
        Console.WriteLine(String(stack));
        Console.WriteLine("Задание 1.2");
        stack = new Stack<int>();
        _stack = new Stack<int>();
        for (int i = 0; i < 7; i++) stack.Push(Rand());
        Console.WriteLine(String(stack));
                for (int i = 0; i < 4; i++)  _stack.Push(stack.Pop());
                int b = _stack.Peek() + stack.Peek();
                stack.Push(_stack.Pop());
                b += _stack.Peek();
                for (int i = 0; i < 3; i++) stack.Push(_stack.Pop());
                stack.Push(b);
        Console.WriteLine(String(stack));
    }
    static void StackTask2(int count)
    {
        Console.WriteLine("Задание 2");
        Stack<int> stack = new Stack<int>();
        Stack<int> _stack = new Stack<int>();
        for (int i = 0; i < count; i++) stack.Push(Rand());
        Console.WriteLine(String(stack));
                for (int i = 1; i < count; i++)
                    if (i % 2 == 0)
                        _stack.Push(stack.Pop());
                    else
                        stack.Pop();
                count = _stack.Count;
                for(int i = 0; i < count; i++) stack.Push(_stack.Pop());
        Console.WriteLine("Преобразование по заданию:");
        Console.WriteLine(String(stack));
    }
    static void StackTask3(int count)
    {
        Console.WriteLine("Задание 3");
        Stack<forTask3> stack = new Stack<forTask3>();
        for (int i = 0; i < count; i++) stack.Push(new forTask3(Rand(), Rand()));
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
        for(int i = 0; i < count; i++) queue.Enqueue(Rand());
        Console.WriteLine(String(queue));
                int max = queue.Peek();
                for (int i = 0; i < queue.Count; i++)
                {
                    if (queue.Peek() > max) max = queue.Peek();
                    queue.Enqueue(queue.Dequeue());
                }
                for (int i = 0; i < count; i++)
                    if (queue.Peek() == max)
                    {
                        queue.Enqueue(0);
                        queue.Enqueue(queue.Dequeue());
                        queue.Enqueue(0);
                    }
                    else  queue.Enqueue(queue.Dequeue());
        Console.WriteLine("Преобразование по заданию:");
        Console.WriteLine(String(queue));
    }
    static void QueueTask2(int count)
    {
        Console.WriteLine("Задание 2");
        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < count; i++) queue.Enqueue(Rand(-100, 100));
        Console.WriteLine(String(queue));
                for (int i = 0; i < queue.Count; i++) queue.Enqueue(-1 * Math.Abs(queue.Dequeue()));
        Console.WriteLine("Преобразование по заданию:");
        Console.WriteLine(String(queue));
    }
    static void QueueTask3(int count)
    {
        Console.WriteLine("Задание 3");
        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < count; i++) queue.Enqueue(Rand(1, 100));
        Console.WriteLine(String(queue));
                int a = 1;
                for (int i = 0; i < queue.Count; i++)
                {
                    a *= queue.Peek();
                    queue.Enqueue(queue.Dequeue());
                }
                queue.Enqueue(a);
                for (int i = 0; i < queue.Count - 1; i++) queue.Enqueue(queue.Dequeue());
        Console.WriteLine("Преобразование по заданию:");
        Console.WriteLine(String(queue));
    }

    static void DequeTask1(int count)
    {
        Console.WriteLine("Задание 1");
        Deque<int> deque = new Deque<int>();
        for(int i = 0; i < count; i++) deque.AddToBack(Rand());
        Console.WriteLine(String(deque));
                int max = deque.RemoveFromBack();
                deque.AddToBack(max);
                for (int i = 0; i < deque.Count; i++)
                {
                    int a = deque.RemoveFromBack();
                    if (a > max) max = a;
                    deque.AddToFront(a);
                }
                for (int i = 0; i < count; i++)
                {
                    int a = deque.RemoveFromBack();
                    if (a == max)
                    {
                        deque.AddToFront(0);
                        deque.AddToFront(a);
                        deque.AddToFront(0);
                    }
                    else deque.AddToFront(a);
                }
        Console.WriteLine("Преобразование по заданию:");
        Console.WriteLine(String(deque));
    }
    static string String(Stack<int> stack)
    {
        string r = "";
        foreach(int i in stack) r += i + " ";
        return r;
    }
    static string String(Queue<int> queue)
    {
        string r = "";
        foreach(int i in queue) r += i + " ";
        return r;
    }
    static string String(Stack<forTask3> stack)
    {
        string r = "";
        foreach(forTask3 i in stack) r += i + " ";
        return r;
    }
    static string String(Deque<int> deque)
    {
        string r = "";
        foreach(int i in deque) r += i + " ";
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
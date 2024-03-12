using System.Collections;

public class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("-----------------------STACK------------------------------");
        Stack<int> stack = new Stack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Push(50);

        //Console.WriteLine(stack.Count());
        //Console.WriteLine(stack.Peek());
        //Console.WriteLine(stack.Pop());
        //Console.WriteLine(stack.Count());
        //Console.WriteLine(stack.Pop());
        //Console.WriteLine(stack.Count());
        //Console.WriteLine(stack.Peek());

        while(stack.Count > 0)
        {
            int cnt = stack.Count();
            int x = stack.Pop();
            Console.WriteLine(cnt);
            Console.WriteLine(x);
        }

        Console.WriteLine(stack.Count());


        Console.WriteLine("--------------------------QUEUE-----------------------");

        Queue <int> que = new Queue<int>();
        que.Enqueue(10);
        que.Enqueue(20);
        que.Enqueue(30);
        que.Enqueue(50);
        que.Enqueue(100);

        Console.WriteLine(que.Count()); 
        //Console.WriteLine(que.Peek());  
        //Console.WriteLine(que.Dequeue());

        //Console.WriteLine(que.Count());
        //Console.WriteLine(que.Peek());

        while(que.Count > 0)
        {
            int cnt = que.Count();
            int removed_Val = que.Dequeue();

            Console.WriteLine(cnt);
            Console.WriteLine(removed_Val);
        }

        Console.WriteLine(que.Count());







    }
}
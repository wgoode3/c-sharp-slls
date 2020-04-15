using System;
using lists.Models;


namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            SLL list1 = new SLL();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);
            SLNode someNode = list1.Head.Next;
            SLNode tail = list1.Head.Next.Next.Next.Next;
            tail.Next = someNode;
            // list1.Print();
            Console.WriteLine(list1.HasLoop());
        }
    }
}

using System;

namespace lists.Models 
{
    public class SLL
    {
        public SLNode Head {get;set;}

        public void Add(int val)
        {
            if(Head == null)
            {
                Head = new SLNode(val);
            } else {
                SLNode Runner = Head;
                while(Runner.Next != null)
                {
                    Runner = Runner.Next;
                }
                Runner.Next = new SLNode(val);
            }
        }

        public void Print()
        {
            SLNode Runner = Head;
            while(Runner != null)
            {
                Console.Write($"{Runner.Value} -> ");
                Runner = Runner.Next;
            }
            Console.WriteLine();
        }

        public void Reverse()
        {
            SLNode prev = null;
            SLNode curr = Head;
            SLNode next = curr.Next;
            while(next != null)
            {
                curr.Next = prev;
                prev = curr;
                curr = next;
                next = next.Next;
            }
            curr.Next = prev;
            Head = curr;
        }

        public bool HasLoop()
        {
            SLNode walker = Head;
            SLNode runner = Head.Next;
            while(walker != null && runner != null && runner.Next != null)
            {
                if(walker == runner)
                {
                    return true;
                }
                walker = walker.Next;
                runner = runner.Next.Next;
            }
            return false;
        }

    }
}
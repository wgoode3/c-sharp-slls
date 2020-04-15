namespace lists.Models 
{
    public class SLNode
    {
        public int Value {get;set;}
        public SLNode Next {get;set;}

        public SLNode(int val)
        {
            Value = val;
        }

    }
}
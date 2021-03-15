namespace LinkedList1
{
    public class Node
    {
        public int data { get; set; }
        public Node link { get; set; }

        public Node(int x)
        {
            data = x;
            link = null;
        }
    }
}
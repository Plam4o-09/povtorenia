namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            LinkedList<int> list = new LinkedList<int>(nums);

            LinkedListNode<int> node = list.First;
            while (node != null) 
            {
                Console.WriteLine(node.Value);
                node = node.Next;
                list.Remove(node);
            }
        }
    }
}

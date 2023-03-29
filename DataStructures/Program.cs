namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList link = new LinkedList();
            link.Add(70);
            link.Add(30);
            link.Add(56);
            
            //link.AddInReverseOrder(70);
            //link.AddInReverseOrder(30);
            //link.AddInReverseOrder(56);
            link.InsertAtParticularPosition(2, 10);
            link.Display();
            Console.WriteLine("**************************");
            link.RemoveFirstNode();
            link.Display();
        }
    }
}
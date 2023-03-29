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
            int position = link.Search(30);
            position++;
            link.InsertAtParticularPosition(position, 40);
            link.Display();
            Console.WriteLine("**************************");
            int position1 = link.Search(40);
            link.DeleteNodeAtParticularPosition(position);
            link.Display();
            //link.RemoveFirstNode();
            //link.Display();
            //Console.WriteLine("**************************");
            //link.RemoveLastNode();
            //link.Display();
            //Console.WriteLine("Present at {0} position",link.Search(30));
        }
    }
}
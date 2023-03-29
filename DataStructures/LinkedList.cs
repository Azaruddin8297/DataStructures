using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = this.head;
                if(temp.next != null)
                {
                   temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Inserted into Linked List", node.data);
        }
    }
}

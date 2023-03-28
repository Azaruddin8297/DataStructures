﻿using System;
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
                temp = temp.next;
            }
            Console.WriteLine("{0} Inserted into Linked List", node.data);
        }
        internal void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }
        }
        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            while(temp != null)
            {
                Console.WriteLine(temp.data+" ");
                temp = temp.next;
            }
        }
    }
}
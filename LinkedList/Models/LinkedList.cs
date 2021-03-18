using AlgorithmsDataStructuresWeb.LinkedList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresWeb.HashMaps.Models
{
    public class LinkedList
    {
        public Node head { get; set; }

        public void append(int data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            Node current=head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new Node(data);


        }

    }
}

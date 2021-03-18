using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresWeb.LinkedList.Models
{
    public class Node
    {
        public  Node next
        {
            get => next;
            set=>value=next;
        }
    
        public int data { get; set; }

        public Node(int data) => this.data = data;
    }
}

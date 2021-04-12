using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresWeb.LinkedLists.Models
{
    public class Node
    {
        public  Node next
        {
           get;set;
        }
    
        public int data { get; set; }

        public Node(int data) => this.data = data;
    }
}

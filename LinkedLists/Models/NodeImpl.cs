using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresWeb.LinkedLists.Models
{
    public class NodeImpl<T>
    {
        public  NodeImpl<T> next
        {
           get;set;
        }
    
        public T data { get; set; }

        public NodeImpl(T data) => this.data = data;
    }
}

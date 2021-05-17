using AlgorithmsDataStructuresWeb.LinkedLists.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresWeb.HashMap.models
{
    public class HashMapImpl<T,K>
    {
        public LinkedListImpl<Entry<T,K>> Linked { get; set; }
        public int size { get; set; } = 0;

        public HashMapImpl()
        {

        }

        public int getIndex(Key<T> key)
        {
            return key.GetHashCode() % size;

        }
    }
}

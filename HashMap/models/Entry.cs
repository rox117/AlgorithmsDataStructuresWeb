using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresWeb.HashMap.models
{
    public class Entry<T,K>
    {
        private Key<T> _key {get;set;}
        private Value<K> _value { get; set; }

        public Entry(Key<T> key,Value<K> value)
        {
            _key = key;
            _value = value;
        }

        public Entry()
        {

        }
    }
}

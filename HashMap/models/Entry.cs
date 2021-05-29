using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresWeb.HashMap.models
{
    public class Entry<T,K>
    {
        public Key<T> _key {get;set;}
        public Value<K> _value { get; set; }

        public Entry(Key<T> key,Value<K> value)
        {
            _key = key;
            _value = value;
        }

        public Entry()
        {

        }

        public override bool Equals(object obj)
        {
            return obj is Entry<T, K> entry &&
                   EqualityComparer<Key<T>>.Default.Equals(_key, entry._key);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_key);
        }
    }
}

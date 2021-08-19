using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresWeb.HashMap.models
{
    public class Key<T>
    {
        private T _val { get; set; }
        public Key(T val) {
            _val = val;
        }

        public override bool Equals(object obj)
        {
            return obj is Key<T> key &&
                   EqualityComparer<T>.Default.Equals(_val, key._val);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_val);
        }
    }
}

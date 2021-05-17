using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresWeb.HashMap.models
{
    public class Value<T>
    {
        private T _value { get; set; }

        public Value(T value)
        {
            _value = value;
        }
    }
}

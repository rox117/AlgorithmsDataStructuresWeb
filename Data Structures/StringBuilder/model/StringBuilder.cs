using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlgorithmsDataStructuresWeb.DynamicArray;

namespace AlgorithmsDataStructuresWeb.Data_Structures.StringBuilder.model
{
    public class StringBuilder
    {
        private DynamicArrayClass<char> dynamic { get; set; } = new DynamicArrayClass<char>();

        public void append(String str)
        {
            char [] chrarray= str.ToCharArray();
            for (int i = 0; i < chrarray.Length; i++)
            {
                dynamic.add(chrarray[i]);

            }
        }

        public String toString()
        {
            return new string(dynamic.elements);
        }
    }
}

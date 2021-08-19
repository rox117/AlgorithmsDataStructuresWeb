using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresWeb.DynamicArray
{
    public class DynamicArrayClass <T>
    {
        public T[] elements { get; set; }= new T [16];

        private int currentIndex { get; set; }

        private int size { get; set; }


       public void grow()
        {
            if (currentIndex == size)
            {
                T[] temp = new T[size * 2];
                for (int i = 0; i < size; i++)
                {
                    temp[i] = elements[i];

                }
                size = size * 2;
                elements = temp;
            }
        }

        public bool add(T item)
        {
            if (currentIndex==size)
            {
                grow();

            }

            elements[currentIndex] = item;
            currentIndex++;
            return true;
        }



        
    }
}

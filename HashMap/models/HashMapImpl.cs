using AlgorithmsDataStructuresWeb.LinkedLists.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresWeb.HashMap.models
{
    public class HashMapImpl<T,K>
    {
        public LinkedListImpl<Entry<T, K>>[] BucketArray { get; set; } = new LinkedListImpl<Entry<T, K>>[2];


        public int _size { get; set; } = 0;

        public HashMapImpl()
        {

        }
        public void put(Key<T> key,Value<K> value) {
            int index = key == null ? 0 : getIndex(key);
            if (_size >= BucketArray.Length)
            {
                resize();
            }
            if (BucketArray[index] == null)
            {
                BucketArray[index] = new LinkedListImpl<Entry<T, K>>();
                BucketArray[index].append(new Entry<T, K>(key,value));
                _size++;
                return;
            }
            else
            {
                foreach(Entry<T,K> entry in BucketArray[index])
                {
                    if (entry._key.Equals(key))
                    {
                        entry._value = value;
                        return;
                    }
                }
                BucketArray[index].append(new Entry<T, K>(key, value));
                return;
            }

        }

        public Value<K> get (Key<T> key)
        {
            int index = key == null ? 0 : getIndex(key);
            if (BucketArray[index] == null)
            {
                return null;
            }

            foreach (Entry<T, K> entry in BucketArray[index]) {
                if (entry._key.Equals(key))
                {
                    return entry._value;
                }
            }
            return null;

        }

        public void remove(Key<T> key)
        {
            int index = key == null ? 0 : getIndex(key);
            if (BucketArray[index] == null)
            {
                return;
            }

            Entry<T, K> toremove = null;


            foreach (Entry<T, K> entry in BucketArray[index])
            {
                if (entry._key.Equals(key))
                {
                    toremove=entry;
                }
            }

            if (toremove == null) return;
            BucketArray[index].delete(toremove);
            _size--;

        }

        public bool containsKey(Key<T> key)
        {
            int index = key == null ? 0 : getIndex(key);
            if (BucketArray[index] == null)
            {
                return false;
            }

            foreach (Entry<T, K> entry in BucketArray[index])
            {
                if (entry._key.Equals(key))
                {
                    return true;
                }
            }

            return false;

        }
        public void resize()
        {
            LinkedListImpl<Entry<T, K>> [] entries = BucketArray;
            BucketArray = new LinkedListImpl<Entry<T, K>>[_size * 2];
            for(int i = 0; i < entries.Length; i++)
            {
                if (entries[i] == null) continue;
                foreach(Entry<T,K> entry in entries[i])
                {
                    put(entry._key, entry._value);

                }
            }

        }


        public int getIndex(Key<T> key)
        {
            return key.GetHashCode() & (_size-1);

        }
    }
}

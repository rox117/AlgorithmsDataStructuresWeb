using AlgorithmsDataStructuresWeb.LinkedLists.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresWeb.LinkedLists.Models
{
    public class LinkedListImpl<T> where T:new()
    {
        public NodeImpl<T> _head { get; set; }

        public int size { get; set; } = 0;
        
        public LinkedListImpl(NodeImpl<T> head)
        {
            _head = head;
        }       

        public void append(T data)
        {
            if (_head == null)
            {
                _head = new NodeImpl<T>(data);
                return;
            }
            NodeImpl<T> current=_head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new NodeImpl<T>(data);
            size++;


        }

        public LinkedListImpl()
        {
            foreach (T dicVal in valueIterator())
            {
                this.append(dicVal);
            }
        }

        public static IEnumerable<T> valueIterator()
        {
            yield return new T();
            yield return new T();
            yield return new T();
            yield return new T();
            yield return new T();
        }

        public void prepend(T data)
        {
            NodeImpl<T> current = new NodeImpl<T>(data);
            current.next = _head;
            _head = current;
            size++;
        }

        public void delete(T key)
        {
            if (_head == null) return;
            if (_head.data.Equals( key))
                _head = _head.next;
            NodeImpl<T> current = _head;

            while (current.next != null)
            {
                if (current.next.data.Equals( key))
                    current.next=current.next.next;
            }
            size--;
        }

        public void printList()
        {
            if (_head == null)
            {
                Console.WriteLine("empty list");
            }
            NodeImpl<T> current = _head;
            while (current != null)
            {
                System.Diagnostics.Debug.WriteLine(current.data);
                current = current.next;
            }

            System.Diagnostics.Debug.WriteLine("_______________________________________");

        }

        public  NodeImpl<T> reverseIterative()
        {
            if (_head == null)
            {
                return null;
            }
            NodeImpl<T> current, prev = null, next;
            current = _head;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;

            }
            _head = prev;
            return _head;

        }

          public  NodeImpl<T> reverseRecursive(NodeImpl<T> head)
        {
            if (head == null|| head.next==null)
            {
                return head;
            }
            NodeImpl<T> reversedHead= reverseRecursive(head.next);
            head.next.next = head;
            head.next = null;
            return reversedHead;
           
        }


    }
}

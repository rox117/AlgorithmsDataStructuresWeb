using AlgorithmsDataStructuresWeb.LinkedLists.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresWeb.LinkedLists.Models
{
    public class LinkedList
    {
        public LinkedList(Node head)
        {
            _head = head;
        }
        public LinkedList() {
            for (int i = 0; i < 10;i++)
            {
                this.append(i);
            }
        }

        
        public Node _head { get; set; }

        public void append(int data)
        {
            if (_head == null)
            {
                _head = new Node(data);
                return;
            }
            Node current=_head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new Node(data);


        }

        public void prepend(int data)
        {
            Node current = new Node(data);
            current.next = _head;
            _head = current;
        }

        public void delete(int key)
        {
            if (_head == null) return;
            if (_head.data == key)
                _head = _head.next;
            Node current = _head;

            while (current.next != null)
            {
                if (current.next.data == key)
                    current.next=current.next.next;
            }
        }

        public void printList()
        {
            if (_head == null)
            {
                Console.WriteLine("empty list");
            }
            Node current = _head;
            while (current != null)
            {
                System.Diagnostics.Debug.WriteLine(current.data);
                current = current.next;
            }

            System.Diagnostics.Debug.WriteLine("_______________________________________");

        }

        public  Node reverseIterative()
        {
            if (_head == null)
            {
                return null;
            }
            Node current, prev = null, next;
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

          public  Node reverseRecursive(Node head)
        {
            if (head == null|| head.next==null)
            {
                return head;
            }
            Node reversedHead= reverseRecursive(head.next);
            head.next.next = head;
            head.next = null;
            return reversedHead;
           
        }


    }
}

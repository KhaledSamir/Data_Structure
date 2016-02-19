using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataS_Training.My_ADT
{
    public class MyLinkedList
    {
        Node header;

        public MyLinkedList()
        {
            header = null;
        }

        public void AddFirst(int value)
        {
            if(header == null)
            {
                header = new Node(value, null);
            }

            else
            {
                Node NewNode = new Node(value, header);
                header = NewNode;
            }
        }

        public void Add(int value)
        {
            if (header == null)
                AddFirst(value);
            else
            {
                Node newNode = new Node(value, null);
                Node current = header;
                while (current.next != null)
                    current = current.next;
                current.next = newNode;
            }
        }

        public int Dequeue()
        {
            int value = header.value;
            header = header.next;
            return value;
        }


        public void Travese()
        {
            Node current = header;
            while (current != null)
            {
                Console.Write(current.value + "\t");
                current = current.next;
            }
        }

        public void RemoveDuplicates()
        {
            Hashtable ht = new Hashtable();
            Node current = header;
            Node previous = null;

            while(current != null)
            {
                if (!ht.Contains(current.value))
                {
                    ht.Add(current.value, true);
                    previous = current;
                }

                else
                {
                    previous.next = current.next;
                }

                current = current.next;
            }
        }

        private class Node
        {
            public int value;
            public Node next;

            public Node(int val , Node next)
            {
                this.value = val;
                this.next = next;
            }
        }
    }
}

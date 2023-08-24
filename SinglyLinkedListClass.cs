using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1TaskGenericClasses
{
    public class SinglyLinkedListClass<T>
    {
    
        public class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        public Node head;
        public int size;

        public int Size => size;

        public SinglyLinkedListClass()
        {
            head = null;
            size = 0;
        }

        public int Add(T item)
        {
            if (head == null)
            {
                head = new Node(item);
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node(item);
            }
            size++;
            return size;
        }

        public bool Remove(T item)
        {
            if (head == null)
                return false;

            if (EqualityComparer<T>.Default.Equals(head.Data, item))
            {
                head = head.Next;
                size--;
                return true;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Next.Data, item))
                {
                    current.Next = current.Next.Next;
                    size--;
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public bool Check(T item)
        {
            Node current = head;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Data, item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public int Index(T item)
        {
            Node current = head;
            int index = 0;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Data, item))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;
        }
    }

}

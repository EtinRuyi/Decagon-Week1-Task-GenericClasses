using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1TaskGenericClasses
{
    
    public class QueueClass<T>
    {
        private SinglyLinkedListClass<T> storage;

        public QueueClass()
        {
            storage = new SinglyLinkedListClass<T>();
        }

        public bool IsEmpty()
        {
            return storage.Size == 0;
        }

        public void Enqueue(T item)
        {
            storage.Add(item);
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            T firstItem = storage.head.Data;
            storage.Remove(firstItem);
            return firstItem;
        }

        public int Size()
        {
            return storage.Size;
        }
    }

}

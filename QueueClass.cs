using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1TaskGenericClasses
{
    public class QueueClass<T>
    {
        private SinglyLinkedListClass<T> items;

        public QueueClass()
        {
            items = new SinglyLinkedListClass<T>();
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }

        public void Enqueue(T item)
        {
            items.AddLast(item);
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            T firstItem = items.First.Value;
            items.RemoveFirst();
            return firstItem;
        }

        public int Size()
        {
            return items.Count;
        }
    }

}

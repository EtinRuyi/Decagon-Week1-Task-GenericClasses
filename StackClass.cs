using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1TaskGenericClasses
{
    public class StackClass<T>
    {
        private SinglyLinkedListClass<T> storage;

        public StackClass()
        {
            storage = new SinglyLinkedListClass<T>();
        }

        public bool IsEmptyStack()
        {
            return storage.Size == 0;
        }

        public void Push(T item)
        {
            storage.Add(item);
        }

        public T Pop()
        {
            if (IsEmptyStack())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            T lastItem = storage.head.Data;
            storage.Remove(lastItem);
            return lastItem;
        }

        public T Peek()
        {
            if (IsEmptyStack())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return storage.head.Data;
        }

        public int Size()
        {
            return storage.Size;
        }
    }

}

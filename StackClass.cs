using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1TaskGenericClasses
{
    public class StackClass<T>
    {
        private List<T> items;

        public StackClass()
        {
            items = new List<T>();
        }

        public bool IsEmptyStack()
        {
            return items.Count == 0;
        }

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (IsEmptyStack())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            int lastIndex = items.Count - 1;
            T lastItem = items[lastIndex];
            items.RemoveAt(lastIndex);
            return lastItem;
        }

        public T Peek()
        {
            if (IsEmptyStack())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return items[items.Count - 1];
        }

        public int Size()
        {
            return items.Count;
        }
    }

}

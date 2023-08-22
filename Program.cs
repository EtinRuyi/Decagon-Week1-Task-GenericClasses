using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1TaskGenericClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LinkedList
            SinglyLinkedListClass<int> linkedList = new SinglyLinkedListClass<int>();
            Console.WriteLine("LINKED LIST CLASS");
            Console.WriteLine("New item added, the size of the class is: \n" + linkedList.Add(10));
            Console.WriteLine("Second item added, the current size if the the class is: \n" + linkedList.Add(20));
            Console.WriteLine("Last item added, the new class size is: \n" + linkedList.Add(30));

            bool removed = linkedList.Remove(20);
            Console.WriteLine($"Is the item found and removed from the class? \n {removed}"); 
            bool notFound = linkedList.Remove(40);
            Console.WriteLine($"Is this item found and removed from the class? \n {notFound}");

            bool contains30 = linkedList.Check(30);
            Console.WriteLine($"Is this item found in the class? \n {contains30}");
            bool contains50 = linkedList.Check(50);
            Console.WriteLine($"Is this item found in the class? \n {contains50}");

            int index30 = linkedList.Index(30);
            Console.WriteLine($"Index of an item found on the class: \n {index30}");
            int index50 = linkedList.Index(50);
            Console.WriteLine($"Index of an item not found on the class: \n {index50}");
            
            
            //Stack
            Console.WriteLine();
            StackClass<int> stack = new StackClass<int>();
            Console.WriteLine("STACK CLASS");
            stack.Push(70);
            stack.Push(40);
            stack.Push(85);

            bool isEmptyStack = stack.IsEmptyStack();
            Console.WriteLine("Is Stack empty? " + isEmptyStack);

            int poppedItem = stack.Pop();
            Console.WriteLine("Popped item: " + poppedItem);

            int peekedItem = stack.Peek();
            Console.WriteLine("Peeked item: " + peekedItem);

            int stackSize = stack.Size();
            Console.WriteLine("Class size: " + stackSize);
            

            //Queue
            Console.WriteLine();
            QueueClass<int> queue = new QueueClass<int>();
            Console.WriteLine("QUEUE CLASS");
            queue.Enqueue(76);
            queue.Enqueue(53);

            bool isEmpty = queue.IsEmpty();
            Console.WriteLine("Is Queue empty? " + isEmpty);

            int dequeuedItem = queue.Dequeue();
            Console.WriteLine("Dequeued item: " + dequeuedItem);

            int queueSize = queue.Size();
            Console.WriteLine("Queue size: " + queueSize);
            





            Console.ReadLine();
        }
    }
}

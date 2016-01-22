using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {                                      
            /* An ArrayList is a class that enables you to dynamically add or remove elements to the array.
            You can notice that it's diferent from the simple array, which doesn't allow you to change the dimension
            once it's  initialized! */
            ArrayList myList = new ArrayList(); /*Hey! I don't need to instantiate ArrayList class with the dimension 
            parameter!*/
            myList.Add(1);
            myList.Add("Luis Felipe");
            myList.Add(DateTime.Now);
            /* If you want to use Sort method in a array containing Custom objects, you will get an exception 
            "Failed to Compare Two Elements in the Array". The Sort method does not know what it is supposed to 
            sort on, so you will need to implement the IComparable interface in the Custom Object class. */

            /* A Hashtable enables you to store a key\value pair of any type of object. The data is stored according
               to the hash code ofthe key and can be accessed by the key rather than the index of the element.*/
            Hashtable myHashtable = new Hashtable();
            myHashtable.Add(1, "one");
            myHashtable.Add("two", 3);
            myHashtable.Add(3, "three");
            Console.WriteLine(myHashtable[1].ToString()); //Returns "one"
            Console.WriteLine(myHashtable["two"].ToString()); //Returns 3
            Console.WriteLine(myHashtable[3].ToString()); //Returns "three"

            /* A Queue is a first-in-first-out collection. Queues can be useful when you need to store data in a 
            specific order for sequential processing. Unlike the ArrayList,you can’t reference an element by index or 
            key; */
            Queue myQueue = new Queue();
            /*The Enqueue method adds the element to the Queue*/
            myQueue.Enqueue("First"); 
            myQueue.Enqueue("Second");
            myQueue.Enqueue("Third");

            int count_queue = myQueue.Count;
            for (int i = 0; i < count_queue; i++)
            {
                /*The Dequeue method removes the first object of the queue and returns it*/
                Console.WriteLine(myQueue.Dequeue());  
            }
            /*A SortedList is a collection that contains key\value pairs but it is different from a Hashtable because
            it can be referenced by the key or the index and because it is sorted.*/
            SortedList mySortedList = new SortedList();
            /* Let's add elements in a unsorted sequence. You will notice that SortedList will sort them automatically!*/
            mySortedList.Add(3, "three");
            mySortedList.Add(2, "second");
            mySortedList.Add(1, "first");

            foreach (DictionaryEntry item in mySortedList)
            {
                Console.WriteLine(item.Value);
            }

            /*A Stack collection is a last-in-first-out collection. It's similar to a Queue except that the last element
              added is the first element retrieved. */
            Stack myStack = new Stack();
            /* The Push method adds the element to the Stack*/
            myStack.Push("First");
            myStack.Push("Second");
            myStack.Push("Third");

            int count_stack = myStack.Count;
            for (int i = 0;  i < count_stack; i++)
            {
                /*The Pop method removes the last element added and returns the removed element*/
                Console.WriteLine(myStack.Pop()); 
            }
        }
    }
}

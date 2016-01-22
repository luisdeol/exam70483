using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The System.Collections.Generic namespace contains classes that are used when you know the type of data to
            be stored in the collection and you want all elements in the collection to be of the same type.*/
            /*A Dictionary type enables you to store a set of elements and associate a key for each element. The
                key, instead of an index, is used to retrieve the element from the dictionary.*/
            Dictionary<int, MyRecord> myDict = new Dictionary<int, MyRecord>();
            myDict.Add(5, new MyRecord()
            {
                ID = 5,
                FirstName = "Bob",
                LastName = "Smith"
            });
            myDict.Add(2, new MyRecord()
            {
                ID = 2,
                FirstName = "Jane",
                LastName = "Doe"
            });
            myDict.Add(10, new MyRecord()
            {
                ID = 10,
                FirstName = "Bill",
                LastName = "Jones"
            });
            Console.WriteLine(myDict[5].FirstName); //It will print "Bob" in the console

            /*A List class is a strongly typed collection of objects, all elements of the List must be
            of the same known and available type. Elements are referenced by index.*/
            List<int> myList = new List<int>(); //That's a int List, if I try to inser a string, you will get an error.
            myList.Add(1);
            //myList.Add("Ola"); Wrong! 

            /*
                Exam Tips and Tricks!
                1.Generic collections are used when you have the same type for all elements.
                2. Lists and ArrayLists are referenced by index and do not have a key.
                3. Dictionaries, SortedLists, and Hashtables have a key\value pair.
                4. Queues and Stacks are used when you have a specific order of processing.
            */
            
        }
        public class MyRecord
        {

            /*I recommend you the C# Code snippet "prop" + tab + tab that will generate automatically the code
            public int MyProperty { get; set; } Making the class properties implementation way faster!*/
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}

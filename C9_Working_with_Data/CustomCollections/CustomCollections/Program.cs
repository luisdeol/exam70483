using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections
{
    class Program
    {
        /*To create your own custom collection, you can inherit from the CollectionBase class.
        The Base class doesn't contain the Add, Insert, Sort, or Search methods, so you will need to implement 
        whichever methods you want to use afterwards. */
        public class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        public class PersonCollection : CollectionBase //CollectionBase is a class of the System.Collections namespace!
        {
            public void Add(Person person)
            {
                List.Add(person);
            }
            public void Insert(int index, Person person)
            {
                List.Insert(index, person);
            }
            public void Remove(Person person)
            {
                List.Remove(person);
            }
            public Person this[int index]
            {
                get
                {
                    return (Person)List[index]; 
                }
                set
                {
                    List[index] = value;
                }
            }
        }
        static void Main(string[] args)
        {
            /*Now that you have a strongly typed PersonCollection class, you can use it in your code! 
            Let's create an instance of PersonsCollection and add two Person objects. */
            PersonCollection persons = new PersonCollection();
            persons.Add(new Person()
            {
                Id = 1,
                FirstName = "Luis Felipe",
                LastName = "Oliveira"
            });
            persons.Add(new Person()
            {
                Id = 2,
                FirstName = "Fulaninho",
                LastName = "da Silva"
            });
            /*Now we can iterave over persons collection using a foreach statement*/
            foreach (Person person in persons){
                Console.WriteLine(string.Format("Id {0}, First Name {1}, Last Name {2}", person.Id.ToString(), person.FirstName, person.LastName));
            }
        }

    }
}

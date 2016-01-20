using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace XML_Serialization
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetId(1);
            person.FirstName = "Luis Felipe";
            person.LastName = "Oliveira";
            //Creating the file and Serializing
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            StreamWriter sr = new StreamWriter("Person.xml");
            xmlSerializer.Serialize(sr, person);
        }
        [Serializable]
        public class Person
        {
            private int _id;
            public string FirstName;
            public string LastName;

            public void SetId(int id)
            {
                _id = id;
            }
        }
    }
}

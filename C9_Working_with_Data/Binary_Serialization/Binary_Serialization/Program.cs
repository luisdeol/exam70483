using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetId(1);
            person.FirstName = "Luis Felipe";
            person.LastName = "Oliveira";

            IFormatter formatter = new BinaryFormatter();
            //Creating the File and Serializing
            Stream sr = new FileStream("Person.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(sr, person);
            sr.Close();
        }
        //For a class to be serialized, you must add the [Serializable] attribute to the top
        [Serializable]
        class Person {
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

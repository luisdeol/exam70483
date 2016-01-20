using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;

namespace JSON_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetId(1);
            person.FirstName = "Joe";
            person.LastName = "Smith";

            Stream stream = new FileStream("Person.json", FileMode.Create);
            //Use the DataContractJsonSerializer to serialize an object to JSON. It's in the System.Runtime.Serialization.Json namespace
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person));
            ser.WriteObject(stream, person);
            stream.Close();
            //To read the JSON back to the object you need to use the ReadObject method of the DataContractJsonSerializer
        }
        [DataContract]
        public class Person
        {
            //You must explicitly put an attribute before each property or field that you want to be serialized
            [DataMember]
            private int _id;
            [DataMember]
            public string FirstName;
            [DataMember]
            public string LastName;

            public void SetId(int id)
            {
                this._id = id;
            }
        }
    }
}

using System;

namespace readcreate_customattr
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Struct)]
    public class MyCustomAttribute : Attribute
    {
        public enum MyCustomAttributeEnum
        {
                Red, 
                White, 
                Blue
        }

        public bool RandomBool { get; set; }
        public string RandomString { get; set; }
        public MyCustomAttributeEnum CustomAttributeEnumItem { get; set; }
    }
}

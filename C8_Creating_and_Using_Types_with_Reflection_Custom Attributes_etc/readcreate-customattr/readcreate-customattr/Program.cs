using System;
using System.Reflection;

namespace readcreate_customattr
{
    class Program
    {
        static void Main(string[] args)
        {
            var classType = typeof(TestClass);
            var attribute = (MyCustomAttribute) classType.GetCustomAttribute(typeof(MyCustomAttribute), false);

            Console.WriteLine($"MyCustomAttributeEnum: {attribute.CustomAttributeEnumItem}");
            Console.WriteLine($"RandomBool: {attribute.RandomBool}");
            Console.WriteLine($"RandomString: {attribute.RandomString}");
        }
    }

    [MyCustom(CustomAttributeEnumItem = MyCustomAttribute.MyCustomAttributeEnum.White, RandomBool = true, RandomString = "hehe")]
    class TestClass
    {

    }
}

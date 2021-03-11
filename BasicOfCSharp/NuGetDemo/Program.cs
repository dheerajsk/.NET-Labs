using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace NuGetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string data = "{\"name\":\"Tom S.\", \"age\":\"14\"}";
            Console.WriteLine(data);
            JArray array = new JArray();
            JValue text = new JValue("Manual text");
            JValue date = new JValue(new DateTime(2000, 5, 23));
            array.Add(text);
            array.Add(date);
            Console.WriteLine(array.ToString());

            Employee e = new Employee();
            e.ID = 1;
            e.Name = "Xyz";
            e.Dept = "IT";

            Console.WriteLine(JsonConvert.SerializeObject(e));
        }
    }
}

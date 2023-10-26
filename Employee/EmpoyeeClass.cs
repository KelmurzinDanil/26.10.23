using System;
using System.Collections.Generic;

namespace Employee
{

    public class EmployeeClass
    {
        public static Dictionary<string, string> coordinate = new Dictionary<string, string>();
        public EmployeeClass(string id, string name)
        {
            coordinate.Add(id, name);
        }
        public static void Print()
        {
            foreach (var pair in coordinate)
            {
                Console.WriteLine($"Должность - {pair.Key}, Имя - {pair.Value}");
            }
        }
    }
}

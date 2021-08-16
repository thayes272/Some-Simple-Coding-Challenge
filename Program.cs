using System;
using System.Collections.Generic;

namespace ShitConsoleThing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students are in your class: ");
            
            var arrayInput = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[arrayInput];
            
            Console.WriteLine("Please input the names of the students: ");
            
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("--------------------");
            Array.Sort(names);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}

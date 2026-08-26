using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    public class Variables
    {
        public void Run()
        {
            // Variable declaration and initialization
            int age = 25; // Integer variable
            string name = "John"; // String variable
            bool isStudent = true; // Boolean variable
            // Output the values of the variables
            const double pi = 3.14159;
            Console.WriteLine($"Name: {name}, Age: {age}, Is Student: {isStudent}");
            Console.WriteLine($"Pi: {pi}");
        }
    }
}

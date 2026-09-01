namespace Hello
{
    internal class StaticUsage
    {
        // Static class example
        /* A static field or property is shared across all instances of a class. 
         * There is only ever one copy in memory. If one object changes a static variable, 
         * that change is instantly visible to all other objects. */
        public static class Calculator
        {
            public static int Add(int a, int b) => a + b;
        }

        public string Name { get; set; } = "Manu";          // Unique to each user
        public static int TotalUsers { get; set; } = 0; // Shared by all users

        public static void Run()
        {
            // Using the static method from the Calculator class
            //When static methods are called, they are called on the class itself, not on an instance of the class.
            int result = Calculator.Add(5, 3);
            Console.WriteLine($"The sum is: {result}");
        }

        public StaticUsage(string name)
        {
            Name = name;
            TotalUsers++; // Increments the shared global counter
        }

        private string _domain = "gmail.com";

        public static bool IsValid(string email)
        {
            // return email.EndsWith(_domain); // ❌ COMPILE ERROR: Cannot access non-static field
            return email.Contains("@");        //  Valid
        }
    }
}

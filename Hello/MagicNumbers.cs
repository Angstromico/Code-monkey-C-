namespace Hello
{
    internal class MagicNumbers
    {
        public static void Run()
        {
            int number = 42; // This is a magic number
            Console.WriteLine($"The answer to life, the universe, and everything is: {number}");

            // Bad practice: using numbers without explanation
            int age = 20; // This is another magic number
            if (age >= 18)
            {
                Console.WriteLine("Adult");
            }

            //Good practice: using named constants instead of magic numbers
            const int ADULT_AGE = 18;

            if (age >= ADULT_AGE)
            {
                Console.WriteLine("Adult");
            }
        }
    }
}

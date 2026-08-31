namespace Hello
{
    internal class Loops
    {
        public static void Run()
        {
            // For loop
            Console.WriteLine("For loop:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            // While loop
            Console.WriteLine("While loop:");
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine(j);
                j++;
            }
            // Do-while loop
            Console.WriteLine("Do-while loop:");
            int k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k < 5);
            // Foreach loop
            Console.WriteLine("Foreach loop:");
            string[] fruits = { "Apple", "Banana", "Cherry" };
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}

namespace Hello
{
    internal class Greet
    {
        public static void Greetings(string name = "Guest")
        {
            GreetingsFunc(name);
        }

        private static void GreetingsFunc(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}

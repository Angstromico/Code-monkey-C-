namespace Hello
{
    internal class FlowExample
    {
        public static void Run()
        {
            Console.WriteLine("Start");

            DoSomething();

            Console.WriteLine("End");
        }

        private static void DoSomething()
        {
            Console.WriteLine("Inside");
        }
    }
}
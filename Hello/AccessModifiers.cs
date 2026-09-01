namespace Hello
{
    // A class in the top level of a namespace is internal by default, so it is not accessible from outside the assembly. And only can be either
    //public or internal. But a class inside another class can be public, private, protected, internal, or protected internal.
    public class AccessModifiers
    {
        static int number = 0;
        public static int publicNumber = 1;

        public static void Run()
        {
            // The variables are private by default, so they are not accessible from outside the class.
            number++;
            publicNumber = number;

            Console.WriteLine($"Private number: {number}, Public number: {publicNumber}");
        }
    }
}

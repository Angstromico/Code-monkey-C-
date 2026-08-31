
namespace Hello
{
    internal class Classes
    {
        public static void Run()
        {
            Person person1 = new Person("Alice", 30);
            Person person2 = new Person("Bob", 25);
            Console.WriteLine($"Person 1: {person1.Name}, Age: {person1.Age}");
            Console.WriteLine($"Person 2: {person2.Name}, Age: {person2.Age}");
        }
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

namespace Hello
{
    internal class Classes
    {
        public static void Run()
        {
            Person person1 = new Person("Alice", 30);
            person1.Age = 31; // Update age
            Person person2 = new Person("Bob", 25);
            Console.WriteLine($"Person 1: {person1.Name}, Age: {person1.Age}");
            Console.WriteLine($"Person 2: {person2.Name}, Age: {person2.Age}");

            Car car1 = new Car("blue");
            Console.WriteLine($"Car 1 color: {car1.color}");
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

class Car
{
    public string color = "red";

    public Car() { }

    public Car(string color)
    {
        this.color = color;
    }

    static void Main(string[] args)
    {
        Car myObj = new Car();
        Console.WriteLine(myObj.color);
    }
}

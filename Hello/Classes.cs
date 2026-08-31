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

            Player Manu = new Player("Manu", 100);
            Manu.TakeDamage(5);
            Console.WriteLine($"Player 1: {Manu.name}, Health: {Manu.health}");
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

class Player
{
    public string name;
    public int health;
    public Player(string name, int health)
    {
        this.name = name;
        this.health = health;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health < 0)
        {
            health = 0;
        }
    }
}

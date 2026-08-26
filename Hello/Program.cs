using Hello;

Console.WriteLine("Hello, World!");

// C# most of the time run the code in line sequence, but there are some exceptions. For example, when you use async/await, the code may not run in a strict sequential order.

Console.WriteLine("Start");

DoSomething();

Console.WriteLine("End");

void DoSomething()
{
    Console.WriteLine("Inside");
}

// The DoSomething method is written after the call, but execution jumps there and then comes back.

const double pi = 3.14159; // This is a constant value that cannot be changed.

Console.WriteLine(pi); // Output: 3.14159

// Run code from Variables.cs
Variables variables = new Variables();
variables.Run();

using Hello;

Function.Grettings();

// C# most of the time run the code in line sequence, but there are some exceptions. For example, when you use async/await, the code may not run in a strict sequential order.

Console.WriteLine("Start");

DoSomething();

Console.WriteLine("End");

void DoSomething()
{
    Console.WriteLine("Inside");
}

// The DoSomething method is written after the call, but execution jumps there and then comes back.

// Run code from Variables.cs
Variables variables = new Variables();
variables.Run();

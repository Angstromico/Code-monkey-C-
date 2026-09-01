using Hello;

Function.Run();

// C# most of the time run the code in line sequence, but there are some exceptions. For example, when you use async/await, the code may not run in a strict sequential order.

FlowExample.Run();

// The DoSomething method is written after the call, but execution jumps there and then comes back.

// Run code from Variables.cs
Variables variables = new Variables();
variables.Run();

Greet.Greetings();
Greet.Greetings("Manuel");

int sum1 = AddNumbers.Add(1,2);
int sum2 = AddNumbers.Add(3, 4, 5);

Console.WriteLine($"Sum 1: {sum1}, Sum 2: {sum2}");

Func<int, int, int> add = (a, b) => a + b;
int sum3 = add(6, 7);
Console.WriteLine($"Sum 3: {sum3}");

Func<int, bool> isBool = (x) => x > 0 ? true : false;

bool result1 = isBool(5);
bool result2 = isBool(-3);

Console.WriteLine($"Result 1: {result1}, Result 2: {result2}");

Arrs.Run();

Loops.Run();

Classes.Run();

StaticUsage.Run();

StaticUsage user = new StaticUsage("Alice");
StaticUsage user2 = new StaticUsage("Bob");

Console.WriteLine($"User 1: {user.Name}, User 2: {user2.Name}, Total Users: {StaticUsage.TotalUsers}");
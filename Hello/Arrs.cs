namespace Hello
{
    internal class Arrs
    {
        public static void Run()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Numbers: " + string.Join(", ", numbers));
            string[] fruits = { "Apple", "Banana", "Cherry" };
            Console.WriteLine("Fruits: " + string.Join(", ", fruits));
            // Multi-dimensional array
            int[,] matrix = { { 1, 2 }, { 3, 4 } };
            Console.WriteLine("Matrix: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[] numbersArr = new int[5];
            for (int i = 0; i < numbersArr.Length; i++)
            {
                numbersArr[i] = i + 1;
            }
            Console.WriteLine("Numbers Array: " + string.Join(", ", numbersArr));

            List<int> numbersList = new List<int> { 1, 2, 3, 4, 5 }; // List of integers
            numbersList.Add(6); // Adding an element to the list
            numbersList.Remove(2); // Removing an element from the list
            numbersList.Insert(1, 10); // Inserting an element at index 1
            numbersList.Sort(); // Sorting the list
            numbersList.Reverse(); // Reversing the list
            //numbersList.Clear(); // Clearing the list
            numbersList.AddRange(new int[] { 7, 8, 9 }); // Adding multiple elements to the list
            numbersList.RemoveAll(n => n > 5); // Removing all elements greater than 5
            numbersList.RemoveAt(2); // Removing the element at index 2
            Console.WriteLine("Numbers in the list:");
            int firstNumber = numbersList[0]; // Accessing the first element
            bool numberInList = numbersList.Contains(3); // Checking if the list contains the number 3
            Console.WriteLine($"First number: {firstNumber}");
            Console.WriteLine($"Number 3 in the list: {numberInList}");
            int indexOfList = numbersList.IndexOf(3);
            Console.WriteLine($"Index of number 3 in the list: {indexOfList}");
            foreach (var number in numbersList)
            {
                Console.WriteLine(number);
            }
            int sum = numbersList.Sum(); // Sum of the list elements
            Console.WriteLine($"Sum of numbers in the list: {sum}");
            int count = numbersList.Count();
            Console.WriteLine($"Count of numbers in the list: {count}");
            Dictionary<string, int> agesDictionary = new Dictionary<string, int>
            {
                { "Alice", 30 },
                { "Bob", 25 },
                { "Charlie", 35 }
            }; // Dictionary with string keys and integer values
            Console.WriteLine("Ages in the dictionary:");
            foreach (var kvp in agesDictionary)
            {
                Console.WriteLine($"Name: {kvp.Key}, Age: {kvp.Value}");
            }

            // Empty List with Capacity
            List<int> emptyListWithCapacity = new List<int>(10); // Creating an empty
            // list with a specified capacity of 10
            Console.WriteLine($"Capacity of empty list: {emptyListWithCapacity.Capacity}");
            Console.WriteLine($"Count of elements in empty list: {emptyListWithCapacity.Count}");

            List<int> numbersCap = new List<int>(2);

            Console.WriteLine($"Count: {numbersCap.Count}");
            Console.WriteLine($"Capacity: {numbersCap.Capacity}");

            numbersCap.Add(10);
            numbersCap.Add(20);

            Console.WriteLine($"Count: {numbersCap.Count}");
            Console.WriteLine($"Capacity: {numbersCap.Capacity}");

            numbersCap.Add(30); // Exceeds the initial capacity

            Console.WriteLine($"Count: {numbersCap.Count}");
            Console.WriteLine($"Capacity: {numbersCap.Capacity}");

            LimitedList<int> numbersLimit = new(3);

            numbersLimit.Add(1);
            numbersLimit.Add(2);
            numbersLimit.Add(3);
            //numbersLimit.Add(4); // Exception

            numbersLimit.Print(); // Output: 1, 2, 3
        }
    }
}

class LimitedList<T>
{
    private readonly int _maxSize;
    private readonly List<T> _items = new();

    public LimitedList(int maxSize)
    {
        _maxSize = maxSize;
    }

    public void Add(T item)
    {
        if (_items.Count >= _maxSize)
            throw new InvalidOperationException("Maximum size reached.");

        _items.Add(item);
    }

    public void Print()
    {
        Console.WriteLine(string.Join(", ", _items));
    }
}

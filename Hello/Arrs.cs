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
            Console.WriteLine("Numbers in the list:");
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
        }
    }
}

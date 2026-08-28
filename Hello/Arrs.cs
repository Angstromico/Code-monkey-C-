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
        }
    }
}

namespace ListDataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print "Hello, World!" to the console
            Console.WriteLine("Hello, World!");

            // Declare an integer array with 10 elements, all initialized to 0 by default
            int[] arr = new int[10];

            // Convert the integer array to a List<int>, append the value 2, and store it in arr1
            List<int> arr1 = arr.Append(2).ToList();

            // Declare and initialize a string array with three string values
            string[] arrString = { "Hello", "World", "Hi" };

            // Add the value 2 to the List<int> arr1
            arr1.Add(2);

            // Print the integer array arr to the console using the PrintArray method
            PrintArray(arr);

            // Print the string array arrString to the console using the PrintArray method
            PrintArray(arrString);

            // Filter arr1 to include only elements that are equal to 43, convert the result to an array, and print it
            PrintArray(arr1.Where(x => x == 43).ToArray());
        }


        // A generic method to print elements of an array to the console
        public static void PrintArray<T>(T[] arr)
        {
            // Iterate over each element in the array
            foreach (T i in arr)
            {
                // Print the element followed by a space
                Console.Write(i + " ");
            }
            // Print a new line after printing all elements
            Console.WriteLine();
        }
    }
}

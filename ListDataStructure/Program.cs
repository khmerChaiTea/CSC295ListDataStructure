namespace ListDataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print "Hello, World!" to the console
            Console.WriteLine("Hello, World!");

            // Declare and initialize an array of integers
            int[] arr = { 45, 64, 84, 19, 2, 7, 15, 91, 53 };

            // Use LINQ to append the value 2 to the array 'arr'
            // Append method returns an IEnumerable<int> which is a sequence of elements.
            IEnumerable<int> arr1 = arr.Append(2);

            // Declare and initialize an array of strings
            string[] arrString = { "Hello", "World", "Hi" };

            // Append the value 2 to arr1 (note: this result is not used or assigned to any variable)
            arr1.Append(2);
            // Print the integer array to the console using the PrintArray method
            PrintArray(arr);
            // Print the string array to the console using the PrintArray method
            PrintArray(arrString);
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

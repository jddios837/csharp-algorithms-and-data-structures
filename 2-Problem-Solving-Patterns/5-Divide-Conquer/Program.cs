namespace _5_Divide_Conquer;

class Program
{
    static void Main(string[] args)
    {
        // An array of integers to be searched.
        int[] listValues = new[] { 1, 4, 6, 7, 10 };

        // The value to be searched in the array.
        int num = 12;

        // Print the index of the searched value in the array.
        Console.WriteLine($"The index of {num} in the list is {search(listValues, num)}");
    }

    /// <summary>
    /// The search method performs a binary search on an array for a specific value.
    /// </summary>
    /// <param name="arr">The array to be searched.</param>
    /// <param name="val">The value to be searched in the array.</param>
    /// <returns>The index of the searched value in the array. If the value is not found, it returns -1.</returns>
    private static int search(int[] arr, int val)
    {
        int min = 0, max = arr.Length - 1;

        while (min <= max)
        {
            int middle = (min + max) / 2;

            if (arr[middle] < val)
                min = middle + 1;
            else if (arr[middle] > val)
                max = middle - 1;
            else
                return middle;
        }

        return -1;
    }
}
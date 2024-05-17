namespace _3_Multiple_Pointers_CountUniqueValues;

// Implement a function called CountUniqueValues,
// which accepts a sorted array, and counts the 
// unique values in the array. There can be negative
// numbers in the array, but it will always be sorted.

// INPUT Array of int values sorted
// OUTPUT only an integer

// EXAMPLES
// int test1 = CountUniqueValues([1,1,1,1,1,2]); // 2
// int test2 = CountUniqueValues([1,2,3,4,4,4,7,7,12,12,13]); // 7
// int test3 = CountUniqueValues([]); // 0
// int test4 = CountUniqueValues([-2,-1,-1,0,1]); // 4

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Count Unique Values START");
        
        int test1 = CountUniqueValues([1,1,1,1,1,2]); // 2
        int test2 = CountUniqueValues([1,2,3,4,4,4,7,7,12,12,13]); // 7
        int test3 = CountUniqueValues([]); // 0
        int test4 = CountUniqueValues([-2,-1,-1,0,1]); // 4
        
        Console.WriteLine("Count Unique Values END");
    }

    static int CountUniqueValues(int[] arrayOfNumbers)
    {
        if (arrayOfNumbers.Length == 0) return 0;

        int i = 0, j = 1;

        while (j < arrayOfNumbers.Length)
        {
            if (arrayOfNumbers[i] != arrayOfNumbers[j])
            {
                i++;
                arrayOfNumbers[i] = arrayOfNumbers[j];
            }

            j++;
        }
        
        return i + 1;
    }
}
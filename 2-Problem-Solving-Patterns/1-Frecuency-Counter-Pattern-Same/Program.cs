namespace _1_Frecuency_Counter_Pattern_Same;

// Write a function called "same", which accepts two arrays,
// The function should return true if every value in the array has
// it's corresponding value squared in the second array.
// The frequency of values must be the same.

// INPUTS arrayOne, arrayTwo
// OUTPUT boolean value

// Examples
// INPUT arrayOne = [1,2,3], arrayTwo = [4,1,9] OUTPUT TRUE
// INPUT arrayOne = [1,2,3], arrayTwo = [1,9] OUTPUT FALSE
// INPUT arrayOne = [1,2,1], arrayTwo = [4,4,1] OUTPUT FALSE


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Same Counter Pattern START");

        bool test1 = Same([1, 2, 3], [4, 1, 9]); // TRUE
        bool test2 = Same([1, 2, 3], [1, 9]); // FALSE
        bool test3 = Same([1, 2, 1], [4, 4, 1]); // FALSE
        bool test4 = Same([1, 2, 3, 2, 5], [9, 1, 4, 4, 11]); // FALSE
        
        Console.WriteLine("Same Counter Pattern END");
    }

    static bool Same(int[] arrayOne, int[] arrayTwo)
    {
        // if length of arrays are different return false
        if (arrayOne.Length != arrayTwo.Length) return false;
        
        // from first array get squared values in an object
        Dictionary<int, int> arrayOneFrecuency = new Dictionary<int, int>();
        Dictionary<int, int> arrayTwoFrecuency = new Dictionary<int, int>();
        
        foreach (int value in arrayOne)
        {
            int key = value * value;
            if (!arrayOneFrecuency.TryAdd(key, 1))
            {
                arrayOneFrecuency[key] += 1;
            }
        }
        // from second array get frecuency object
        foreach (int value in arrayTwo)
        {
            if (!arrayTwoFrecuency.TryAdd(value, 1))
            {
                arrayTwoFrecuency[value] += 1;
            }
        }
        // loop in first squared frecuency object
        foreach (var item in arrayTwoFrecuency)
        {
            // if key does not exist or value are different return false
            if (!arrayOneFrecuency.ContainsKey(item.Key) ||
                arrayOneFrecuency[item.Key] != item.Value) return false;
        }
        
        return true;
    }
}
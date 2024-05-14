namespace _2_problem_solving_approach;
// Write a function which takes in a string and returns counts 
// of each character in the string

// count the number of each char in a string
// INPUT (a string)
// OUTPUT (array of a dictionary with key = char and value = repetition number

// Name of Function Dictionary<char, int> CharStringCount(String)

// Examples 
// INPUT = "hello word!"
// OUTPUT = [
// {key = 'h', value = 1}
// {key = 'l', value = 2}
// {key = 'o', value = 2}
// {key = 'r', value = 1}
// {key = 'd', value = 1}
// {key = '!', value = 1}
// ]

// INPUT = ""
// OUTPUT = []
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("String Counter");

        var counter = CharStringCount("hello word!");

        Console.WriteLine("Finishing");
    }

    static Dictionary<char, int> CharStringCount(string stringToCount)
    {
        // declare initial dictionary
        Dictionary<char, int> counter = new Dictionary<char, int>();
        
        // check if string is empty and return empty dictionary
        if (String.IsNullOrEmpty(stringToCount))
            return counter;
        
        // loop in the stringToCount
        for (var i = 0; i < stringToCount.Length; i++)
        {
            // if char is character or number and not exist in the dictionary
            bool checkLetters = (stringToCount[i] >= 65 && stringToCount[i] <= 90) ||
                                (stringToCount[i] >= 97 && stringToCount[i] <= 122);
            if (stringToCount[i] > 0 && checkLetters)
            {
                // add it and counter = 1
                counter.Add(stringToCount[i], 0);
            }
            // if char the character exist in the dictionary 
            else
            {
                counter[stringToCount[i]]++;
            }
        }
        // return the dictionary
        return counter;
    }
}
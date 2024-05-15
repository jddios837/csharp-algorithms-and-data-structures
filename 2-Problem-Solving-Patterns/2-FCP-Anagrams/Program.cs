namespace _2_FCP_Anagrams;

class Program
{
    // Give two string, write a function to determine if the second
    // string is an anagram of the first. An anagram is a 
    // word, phrase, or name formed by rearranging the 
    // letters of another, such as cinema, formed from iceman
    
    // EXAMPLES
    // ValidAnagram("","") // TRUE
    // ValidAnagram("aaz","zza") // FALSE
    // ValidAnagram("anagram","nagaram") // TRUE
    // ValidAnagram("anagram","nagaram") // TRUE
    // ValidAnagram("rat","car") // FALSE
    // ValidAnagram("awesome","awesom") // FALSE
    // ValidAnagram("qwerty","qeywer") // TRUE
    // ValidAnagram("texttwisttime","timetwisttext") // TRUE
    
    static void Main(string[] args)
    {
        Console.WriteLine("Valid Anagram START");

        bool test1 = ValidAnagram("", ""); // TRUE
        bool test2 = ValidAnagram("aaz","zza"); // FALSE
        bool test3 = ValidAnagram("anagram","nagaram"); // TRUE
        bool test4 = ValidAnagram("anagram","nagaram"); // TRUE
        bool test5 = ValidAnagram("rat","car"); // FALSE
        bool test6 = ValidAnagram("awesome","awesom"); // FALSE
        bool test7 = ValidAnagram("qwerty","qeywrt"); // TRUE
        bool test8 = ValidAnagram("texttwisttime","timetwisttext"); // TRUE
        bool test9 = ValidAnagram("texttwisttime","TIMETWISTTEXT"); // TRUE
        
        Console.WriteLine("Valid Anagram END");
    }

    static bool ValidAnagram(string firstString, string secondString)
    {
        if (firstString.Length == 0 && secondString.Length == 0 || 
            firstString.Length != secondString.Length)
        {
            return false;
        }
        
        // build frequency dictionaries for strings
        Dictionary<char, int> firstStringDictionary = new Dictionary<char, int>();
        Dictionary<char, int> secondStringDictionary = new Dictionary<char, int>();

        foreach (var stringChar in firstString.ToLower())
        {
            if (!firstStringDictionary.TryAdd(stringChar, 1)) 
                firstStringDictionary[stringChar] += 1;
        }
        
        foreach (var stringChar in secondString.ToLower())
        {
            if (!secondStringDictionary.TryAdd(stringChar, 1)) 
                secondStringDictionary[stringChar] += 1;
        }

        foreach (var item in secondStringDictionary)
        {
            // check if key does not exist in the first dictionary
            // check if the count are not the same
            if (!firstStringDictionary.ContainsKey(item.Key) ||
                firstStringDictionary[item.Key] != item.Value)
                return false;
        }
        
        
        return true;
    }
}
namespace _6_FCP_SameFrecuency;

class Program
{
    static void Main(string[] args)
    {
        // Input two integers values
        // Output Boolean
        // Same length of values, if they are different return false
        // Examples
        // SameFrequency(182, 281) TRUE
        // SameFrequency(34, 14) FALSE
        // SameFrequency(3589578, 5879385) TRUE
        // SameFrequency(22, 222) FALSE
        
        // Examples
        bool result1 = SameFrequency(182, 281);
        Console.WriteLine($"The result of SameFrequency(182, 281) is {result1}");
        
        bool result2 = SameFrequency(34, 14);
        Console.WriteLine($"The result of SameFrequency(34, 14) is {result2}");

        bool result3 = SameFrequency(3589578, 5879385);
        Console.WriteLine($"The result of SameFrequency(3589578, 5879385) is {result3}");

        bool result4 = SameFrequency(22, 222);
        Console.WriteLine($"The result of SameFrequency(22, 222) is {result4}");
    }

    // 
    static bool SameFrequency(int val1, int val2)
    {
        string val1Str = val1.ToString();
        string val2Str = val2.ToString();
        
        if (val1Str.Length != val2Str.Length) return false;

        Dictionary<char, int> frequency1 = new Dictionary<char, int>();
        Dictionary<char, int> frequency2 = new Dictionary<char, int>();
        
        for(int i = 0; i < val1Str.Length; i++)
        {
            if (!frequency1.ContainsKey(val1Str[i]))
            {
                frequency1[val1Str[i]] = 1;
            }
            else
            {
                frequency1[val1Str[i]] += 1;
            }
        }
        
        for(int i = 0; i < val2Str.Length; i++)
        {
            if (!frequency2.ContainsKey(val2Str[i]))
            {
                frequency2[val2Str[i]] = 1;
            }
            else
            {
                frequency2[val2Str[i]] = frequency2[val2Str[i]]++;
            }
        }

        foreach (KeyValuePair<char,int> kv in frequency2)
        {
            if (!frequency1.ContainsKey(kv.Key) || frequency1[kv.Key] != kv.Value) return false;
        }

        return true;
    }
}
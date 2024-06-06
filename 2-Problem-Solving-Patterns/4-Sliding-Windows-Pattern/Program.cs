namespace _4_Sliding_Windows_Pattern;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] listIntegers = new[] { 2, 6, 9, 2, 1, 8, 5, 6, 3 };
        int result = maxSubarraySum(listIntegers, 3);
        Console.WriteLine($"Max sum in the array is {result}");
    }

    private static int maxSubarraySum(int[] arr, int num)
    {
        int maxSum = 0, tempSum = 0;

        if (arr.Length < num) return 0;

        for (int i = 0; i < num; i++)
            maxSum += arr[i];

        tempSum = maxSum;

        for (int i = num; i < arr.Length; i++)
        {
            tempSum = tempSum - arr[i - num] + arr[i];
            maxSum = Math.Max(maxSum, tempSum);
        }
        
        return maxSum;
    }
}
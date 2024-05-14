namespace _1_Pyramid_Array;

class Program
{
    static void Main(string[] args)
    {
        // pyramid(0) => [ ]
        // pyramid(1) => [ [1] ]
        // pyramid(2) => [ [1], [1, 1] ]
        // pyramid(3) => [ [1], [1, 1], [1, 1, 1] ]
        Console.WriteLine("Pyramid Test START");
        int[][] test1 = Pyramid(0);
        int[][] test2 = Pyramid(1);
        int[][] test3 = Pyramid(2);
        int[][] test4 = Pyramid(3);
        
        Console.WriteLine("Pyramid Test END");
    }
    
    public static int[][] Pyramid(int n) {
        // create a new array of array totalArray
        int[][] totalArray = new int[n][];
        // if array is empty
        if (n <= 0) {
            return totalArray;
        } else {
            // loop from i = 0 to n
            for(int i = 0; i < n; i++) {
                // create acumArray = []
                int[] acumArray = new int[i + 1];
                // loop from j = 0 to i
                for (int j = 0; j <= i; j++) {
                    acumArray[j] = 1;
                }
                totalArray[i] = acumArray;
            }
        }
    
        // return   
        return totalArray;
    }
}
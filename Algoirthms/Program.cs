
using Algoirthms;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] result = Problems.TwoSum(new int[] {5,7,3, 8, 1}, 11);
        Console.WriteLine("[" + result[0] + "," + result[1] + "]");
    }
}

using Algoirthms;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] result = Problems.TwoSum2(new int[] { 5, 7, 3, 8, 1 }, 11);
        Console.WriteLine("[" + result[0] + "," + result[1] + "]");

        //var t = Problems.BubbleSortList(new List<int>() { 5, 3, 1, 2, 4 });

        //for (int i = 0; i < t.Count; i++)
        //{
        //    Console.WriteLine(t[i]);    
        //}
    }
}
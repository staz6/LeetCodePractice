using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOfTwo sumOfTwo = new SumOfTwo();
            int[] sumOfTwoResult=sumOfTwo.sumOfTwoOptimal(new int[] {2,7,11,15},9);
            Console.WriteLine(string.Join(" ", sumOfTwoResult));
        }
    }
}

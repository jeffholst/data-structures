using System;
using two_sum_lib;

namespace two_sum_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] {2, 7, 11, 15};
            int[] answer = Solution.twoSum(input, 9);
        }
    }
}
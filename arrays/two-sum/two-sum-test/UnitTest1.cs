using System;
using Xunit;
using two_sum_lib;

namespace two_sum_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] input = new int[] {2, 7, 11, 15};
            int[] answer = Solution.twoSum(input, 9);

            Assert.Equal(answer.Length, 2);
            Assert.Equal(0, answer[0]);
            Assert.Equal(1, answer[1]);
        }

        [Fact]
        public void Test2()
        {
            int[] input = new int[] {4, 5, 3, 2, 1, 6, 7};
            int[] answer = Solution.twoSum(input, 12);

            Assert.Equal(answer.Length, 2);
            Assert.Equal(1, answer[0]);
            Assert.Equal(6, answer[1]);
        }
    }
}

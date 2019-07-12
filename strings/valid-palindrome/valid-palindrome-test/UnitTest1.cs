using System;
using Xunit;
using valid_palindrome_lib;

namespace valid_palindrome_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(true, Solution.isPalindrome("A man, a plan, a canal: Panama"));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(false, Solution.isPalindrome("race a car"));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(true, Solution.isPalindrome("racecar"));
        }
    }
}

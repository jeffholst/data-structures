using System;
using System.Collections.Generic;

namespace two_sum_lib
{
    public static class Solution
    {
        public static int[] twoSum(int[] nums, int target){

            int[] answer = new int[2] {0,0};
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            
            for (int loop = 0; loop < nums.Length; loop++)
            {
                if ( !dictionary.ContainsKey(target - nums[loop]) )
                {
                    dictionary.Add(nums[loop], loop);
                }
                else
                {
                    answer[0] = dictionary[target - nums[loop]];
                    answer[1] = loop;
                    break;
                }
            }

            return answer;
        }
    }
}

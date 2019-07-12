# Problem

Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

#### Example 1:
	Given nums = [2, 7, 11, 15], target = 9,
	Because nums[0] + nums[1] = 2 + 7 = 9,
	return [0,1].

#### Example 2:
	Given nums = [4, 5, 3, 2, 1, 6, 7], target = 12,
	Because nums[1] + nums[6] = 5 + 7 = 12,
	return [1,6].

#### Program Structure:
```C#
public class Solution {
	public int[] twoSum(int[] nums, int target)
	{
	}
}
```
#### Solution:
> We can solve this problem with O(N) time complexity using a HashMap.  

See [two-sum-lib/Solution.cs](https://github.com/jeffholst/data-structures/blob/master/arrays/two-sum/two-sum-lib/Solution.cs)
#### Time Complexity: O(N):
> The array is traversed only once. So the time complexity is directly proportional to the size of the array i.e. O(N).
####  Space Complexity: O(N):
> O(1) + O(N) = O(N). )(1) for the variables and O(N) for the hashmap. For hashmap, with the increase of the number of entries, the hashmap's space will increase lineraly. So space complexity of hasmap is O(N).

#### Difficulty: Easy

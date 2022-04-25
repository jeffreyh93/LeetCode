using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1._IntroToDS.ArrayAndString._1_IntroToArray
{
    public static class _1_FindPivotIndex
    {
        // Given an array of integers, nums, calculate the pivot index of the array
        // The pivot index is the index where the sum of all the numbers strictly to the left of the index is equal to the sum
        //      of all the numbers strictly to the index's right
        // If the index is on the left edge of the array, then the left sum is 0 because there are no elements left. This also
        //      applies to the right edge of the array
        // Return the leftmost pivot index. If no such index exists, return -1

        // Input: nums = [1,7,3,6,5,6], output: 3
        // Input: nums = [1,2,3], output: -1
        // Input: nums = [2,1,-1], output: 0

        // Space Complexity: O(1), no extra space needed. solution maintained with two ints
        // Time Complexity: O(n), one pass through the int array

        public static int PivotIndex(int[] nums) {
            int sum = 0;
            foreach (int n in nums) sum += n;

            int leftSum = 0;
            int rightSum = sum;

            for (int i = 0; i < nums.Length; i++) {
                if (i != 0) leftSum += nums[i - 1];
                rightSum -= nums[i];
                if (leftSum == rightSum) return i;
            }
            return -1;
        }
    }
}

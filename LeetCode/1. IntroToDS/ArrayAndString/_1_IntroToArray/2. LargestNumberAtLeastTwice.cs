using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1._IntroToDS.ArrayAndString._1_IntroToArray
{
    
    public static class _2_LargestNumberAtLeastTwice
    {
        /**
         * You are given an integer array nums where the largest number is unique
         * Determine whether the largest element in the array is at least twice as much as every other number in the array. If it is, return the index of the largest element, or return -1 otherwise
         * 
         * Input: nums = [3,6,1,0], output = 1
         * Input: nums = [1,2,3,4], output = -1
         * Input: nums = [1], output = 0
         * 
         * Space Complexity: O(1), no extra space allocated, just using two ints
         * Time Complexity: O(n), even though we are looping through twice O(2n), the 2 is ignored and we just consider this as O(n)
         */
        public static int NumberAtLeastTwice(int[] nums) {
            int maxIdx = -1;
            int maxVal = Int32.MinValue;

            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] > maxVal) {
                    maxVal = nums[i];
                    maxIdx = i;
                }
            }

            for (int i = 0; i < nums.Length; i++) {
                if (i != maxIdx && nums[i] * 2 > maxVal) {
                    return -1;
                }
            }
            return maxIdx;
        }
    }
}

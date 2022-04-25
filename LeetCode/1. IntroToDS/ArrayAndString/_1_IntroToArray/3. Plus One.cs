using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1._IntroToDS.ArrayAndString._1_IntroToArray
{
    public static class _3_PlusOne
    {
        /**
         * You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer
         * The digits are ordered from most significant in left-right order, does not contain any leading 0s
         * 
         * Increment the large integer by one and return the resulting array of digits
         * 
         * Input = [1,2,3], output = [1,2,4]
         * Input = [4,3,2,1], output = [4,3,2,2]
         * Input = [9], output = [1,0]
         * 
         * Space Complexity: O(1), no extra space is used for the solution aside from the return value
         * Time Complexity: O(n) at worst case, all indeces are entered
         */ 
        public static int[] PlusOne(int[] digits) {
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--) {
                if (digits[i] == 9) digits[i] = 0;
                else {
                    digits[i]++;
                    return digits;
                }
            }
            int[] ret = new int[n + 1];
            ret[0] = 1;
            return ret;
        }
    }
}

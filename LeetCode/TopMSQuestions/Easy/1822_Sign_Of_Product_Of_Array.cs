using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TopMSQuestions.Easy
{
    class _1822_Sign_Of_Product_Of_Array
    {
        /**
         * Algorithm:
         *      - have a variable that tracks the sign
         *      - everytime we come across a negative number, flip the variable
         *      - if we come across a 0, assign that
         */ 
        public int ArraySign(int[] nums) {
            int sign = 1;
            foreach (int n in nums) {
                if (n == 0) return 0;
                if (n < 0) sign *= -1;
            }
            return sign;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TopMSQuestions.Easy
{
    class _1304_Find_N_Unique_Integers_Sum_To_Zero
    {
        /**
         * Algorithm: Fill the array from both sides
         *      - ie. if n = 5, fill -2, -1, 0, 1, 2
         *      - meaning each index = -(n / 2 - i), n / 2 - i
         */ 
        public int[] SumZero(int n) {
            int[] ret = new int[n];
            for (int i = 0; i < n / 2; i++) {
                ret[i] = -(n / 2 - i);
                ret[n - i - 1] = n / 2 - i;
            }
            return ret;
        }
    }
}

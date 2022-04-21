using System;
using System.Collections;
using System.Collections.Generic;

using LeetCode._1._IntroToDS.ArrayAndString._1_IntroToArray;

namespace LeetCode
{
    class Program
    {
        private static string PrintArr(int[] arr) {
            string ret = "";
            foreach (int n in arr) {
                ret += n + ",";
            }
            return ret;
        }
        // driver for all of the sections
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Intro to Data Structures
            Console.WriteLine("1. Introduction to Data Structures");

            // Arrays and Strings
            Console.WriteLine("Arrays and Strings");

            // Introduction to Array
            Console.WriteLine("Introduction to Array");

            // 1. Find Pivot Index
            Console.WriteLine("1a. Find Pivot Index");
            {
                List<int[]> numsArr = new List<int[]>();
                numsArr.Add(new int[] { 1, 7, 3, 6, 5, 6 });
                numsArr.Add(new int[] { 1, 2, 3 });
                numsArr.Add(new int[] { 2, 1, -1 });

                foreach (int[] arr in numsArr)
                {
                    Console.WriteLine($"arr = {PrintArr(arr)} result = {FindPivotIndex.PivotIndex(arr)}");
                }
            }

            // Into to Algorithms

            // Detailed Explanation
        }
    }
}

﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_136_Single_Number
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void nums_is_5_singleNumber_should_be_5()
        {
            var nums = new int[] { 5 };

            AssertSingleNumber(nums, 5);
        }

        private static void AssertSingleNumber(int[] nums, int expected)
        {
            Assert.AreEqual(expected, new Solution().SingleNumber(nums));
        }

        [TestMethod]
        public void nums_is_454_singleNumber_should_be_5()
        {
            var nums = new int[] { 4, 5, 4 };
            AssertSingleNumber(nums, 5);
        }

        [TestMethod]
        public void nums_4_2_4_7_2_singileNumber_should_be_7()
        {
            var nums = new int[] { 4, 2, 4, 7, 2 };
            AssertSingleNumber(nums, 7);
        }
    }

    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result = result ^ nums[i];
            }

            return result;
        }
    }
}
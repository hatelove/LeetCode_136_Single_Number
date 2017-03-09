using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }

    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            var dictionary = new Dictionary<int, bool>();
            for (int i = 0; i < nums.Length; i++)
            {
                var n = nums[i];
                if (!dictionary.ContainsKey(n))
                {
                    dictionary.Add(n, false);
                }
                else
                {
                    dictionary[n] = !dictionary[n];
                }
            }

            return dictionary.Where(x => !x.Value).Single().Key;
        }
    }
}

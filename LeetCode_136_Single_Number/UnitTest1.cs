using System;
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
            var nums = new int[] {5};

            AssertSingleNumber(nums, 5);
        }

        private static void AssertSingleNumber(int[] nums, int expected)
        {
            Assert.AreEqual(expected, new Solution().SingleNumber(nums));
        }
    }

    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            return nums[0];
        }
    }
}

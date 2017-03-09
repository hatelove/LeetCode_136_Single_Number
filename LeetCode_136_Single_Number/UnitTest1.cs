using System;
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

            Assert.AreEqual(5, new Solution().SingleNumber(nums));
        }
    }

    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            throw new NotImplementedException();
        }
    }
}

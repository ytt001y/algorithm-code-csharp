using Algorithm.LeetCode;
using NUnit.Framework;
using System;

namespace Test.LeetCode
{
    [TestFixture]
    internal class _0001_两数之和_Test
    {
        [Test]
        public void AddNumTest()
        {
            TestAddNum(Solution.TwoSum1);
            TestAddNum(Solution.TwoSum2);
        }

        private void TestAddNum(Func<int[], int,int[]> func)
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            
            var result = func(nums,9);
            Assert.AreEqual(new int[] { 0, 1 }, result);
            
            result = func(nums, 26);
            Assert.AreEqual(new int[] { 2, 3 }, result);

            result = func(nums, 18);
            Assert.AreEqual(new int[] { 1, 2 }, result);
        }
    }
}

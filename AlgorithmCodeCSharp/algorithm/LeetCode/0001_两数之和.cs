namespace Algorithm.LeetCode
{
    /**
     * 题目：两数之和
     * 
     * 给定一个整数数组 nums 和一个整数目标值 target，请你在该数组中找出 和为目标值 的那 两个 整数，并返回它们的数组下标。
     * 你可以假设每种输入只会对应一个答案。但是，数组中同一个元素在答案里不能重复出现。
     * 你可以按任意顺序返回答案。
     * 
     * 链接：https://leetcode-cn.com/problems/two-sum/
     */


    public partial class Solution
    {
        /**
         * 解法一：
         * 
         * 双重循环，相加比较。
         * 时间复杂度O(N^2)，空间复杂度O(1)。
         */
        public static int[] TwoSum1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null!;
        }

        /** 
         * 解法二：
         * 
         * Dictionary（或Hashtable）存储已遍历完成数据，单循环比较。
         * 时间复杂度O(N)，空间复杂度O(N)。
         */
        public static int[] TwoSum2(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dictionary.ContainsKey(target - nums[i]))
                {
                    return new int[] { dictionary[target - nums[i]], i };
                }
                dictionary.Add(nums[i], i);
            }
            return null!;
        }
    }
}

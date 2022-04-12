namespace Algorithm.LeetCode
{
    /**
     * 题目：27.移除元素
     * 
     * 给你一个数组 nums 和一个值 val，你需要 原地 移除所有数值等于 val 的元素，并返回移除后数组的新长度。
     * 不要使用额外的数组空间，你必须仅使用 O(1) 额外空间并 原地 修改输入数组。
     * 元素的顺序可以改变。你不需要考虑数组中超出新长度后面的元素。
     * 
     * 链接：https://leetcode-cn.com/problems/remove-element/
     */

    public partial class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int valid = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[valid] = nums[i];
                    valid++;
                }
            }
            return valid;
        }
    }
}

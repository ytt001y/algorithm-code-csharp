namespace Algorithm.LeetCode
{
    /**
     * 题目：78.子集
     * 
     * 给你一个整数数组 nums ，数组中的元素 互不相同 。返回该数组所有可能的子集（幂集）。
     * 解集 不能 包含重复的子集。你可以按 任意顺序 返回解集。
     * 
     * 链接：https://leetcode-cn.com/problems/subsets/
     */

    public partial class Solution
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>
            {
                new List<int>()
            };

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < result.Count; j++)
                {
                    if (!result[j].Contains(nums[i]))
                    {
                        var list = new List<int>();
                        list.AddRange(result[j]);
                        list.Add(nums[i]);
                        result.Add(list);
                    }
                }
            }
            return result;
        }
    }

}

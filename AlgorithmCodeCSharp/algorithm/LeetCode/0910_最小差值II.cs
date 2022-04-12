namespace Algorithm.LeetCode
{
    /**
     * 题目：910.最小差值II
     * 
     * 给你一个整数数组 A，对于每个整数 A[i]，可以选择 x = -K 或是 x = K （K 总是非负整数），并将 x 加到 A[i] 中。
     * 在此过程之后，得到数组 B。
     * 返回 B 的最大值和 B 的最小值之间可能存在的最小差值。
     * 
     * 链接：https://leetcode-cn.com/problems/smallest-range-ii/
     */
    public partial class Solution
    {
        public int SmallestRangeII(int[] A, int K)
        {
            Array.Sort(A);
            var ans = A.Last() - A.First();
            for (int i = 0; i < A.Length - 1; i++)
            {
                var low = Math.Min(A.First() + K, A[i + 1] - K);
                var high = Math.Max(A.Last() - K, A[i] + K);
                ans = Math.Min(ans, high - low);
            }
            return ans;
        }
    }
}

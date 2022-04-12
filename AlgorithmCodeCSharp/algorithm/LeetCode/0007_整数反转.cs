namespace Algorithm.LeetCode
{
    /**
     * 题目：整数反转
     * 
     * 给你一个 32 位的有符号整数 x ，返回将 x 中的数字部分反转后的结果。
     * 如果反转后整数超过 32 位的有符号整数的范围 [−231,  231 − 1] ，就返回 0。
     * 假设环境不允许存储 64 位整数（有符号或无符号）。
     * 
     * 链接：https://leetcode-cn.com/problems/reverse-integer/
     */

    public partial class Solution
    {
        public int Reverse(int x)
        {
            long result = 0;
            while (x != 0)
            {
                result = result * 10 + x % 10;
                x /= 10;
            }
            if (result > 2147483641 || result < -2147483642)
            {
                result = 0;
            }
            return (int)result;
        }
    }
}

/**
 * 题目：1486.数组异或操作
 * 
 * 给你两个整数，n 和 start 。
 * 数组 nums 定义为：nums[i] = start + 2*i（下标从 0 开始）且 n == nums.length 。
 * 请返回 nums 中所有元素按位异或（XOR）后得到的结果。
 * 
 * 链接：https://leetcode-cn.com/problems/xor-operation-in-an-array/
 */

public class Solution
{
    public int XorOperation(int n, int start)
    {
        var result = start;
        for (int i = 1; i < n; i++)
        {
            result = result ^ (start + 2 * i);
        }
        return result;
    }
}
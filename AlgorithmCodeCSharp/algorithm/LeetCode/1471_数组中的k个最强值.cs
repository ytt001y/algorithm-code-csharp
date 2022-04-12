﻿namespace Algorithm.LeetCode
{
    /**
     * 题目：1471. 数组中的 k 个最强值
     * 
     * 给你一个整数数组 arr 和一个整数 k 。
     * 设 m 为数组的中位数，只要满足下述两个前提之一，就可以判定 arr[i] 的值比 arr[j] 的值更强：
     * |arr[i] - m| > |arr[j] - m|
     * |arr[i] - m| == |arr[j] - m|，且 arr[i] > arr[j]
     * 请返回由数组中最强的 k 个值组成的列表。答案可以以 任意顺序 返回。
     * 中位数 是一个有序整数列表中处于中间位置的值。形式上，如果列表的长度为 n ，那么中位数就是该有序列表（下标从 0 开始）中位于 ((n - 1) / 2) 的元素。
     * 例如 arr = [6, -3, 7, 2, 11]，n = 5：数组排序后得到 arr = [-3, 2, 6, 7, 11] ，数组的中间位置为 m = ((5 - 1) / 2) = 2 ，中位数 arr[m] 的值为 6 。
     * 例如 arr = [-7, 22, 17, 3]，n = 4：数组排序后得到 arr = [-7, 3, 17, 22] ，数组的中间位置为 m = ((4 - 1) / 2) = 1 ，中位数 arr[m] 的值为 3 。
     * 
     * 链接：https://leetcode-cn.com/problems/the-k-strongest-values-in-an-array/
     */

    /**
     * 解法一：
     * 
     * 排序+双指针。
     */
    public partial class Solution
    {
        public int[] GetStrongest(int[] arr, int k)
        {
            var list = arr.OrderBy(t => t).ToArray();
            var middleValue = list[(arr.Length - 1) / 2];

            var headIndex = 0;
            var tailIndex = list.Length - 1;

            int[] result = new int[k];

            for (int i = 0; i < k; i++)
            {
                if (Math.Abs(list[headIndex] - middleValue) > Math.Abs(list[tailIndex] - middleValue))
                {
                    result[i] = list[headIndex];
                    headIndex++;
                }
                else
                {
                    result[i] = list[tailIndex];
                    tailIndex--;
                }
            }

            return result;
        }
    }
}

﻿/**
 * 题目：数据流中的第 K 大元素
 * 
 * 设计一个找到数据流中第 k 大元素的类（class）。注意是排序后的第 k 大元素，不是第 k 个不同的元素。
 * 请实现 KthLargest 类：
 * KthLargest(int k, int[] nums) 使用整数 k 和整数流 nums 初始化对象。
 * int add(int val) 将 val 插入数据流 nums 后，返回当前数据流中第 k 大的元素。
 * 
 * 链接：https://leetcode-cn.com/problems/kth-largest-element-in-a-stream/
 */

public class KthLargest
{
    private readonly int index;
    private readonly List<int> list;
    public KthLargest(int k, int[] nums)
    {
        index = k;
        list = nums.OrderBy(t => t).ToList() ?? new List<int>();
    }

    public int Add(int val)
    {
        if (list.Count == 0 || list.Last() < val)
        {
            list.Add(val);
        }
        else
        {
            if (list.Count < index || list[list.Count - index] < val)
            {
                for (int i = 0; i <= list.Count - 1; i++)
                {
                    if (val <= list[i])
                    {
                        list.Insert(i, val);
                        break;
                    }
                }
            }
        }
        return list[list.Count - index];
    }
}
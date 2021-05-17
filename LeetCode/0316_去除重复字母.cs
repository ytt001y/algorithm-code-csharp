/**
 * 题目：316. 去除重复字母
 *      1081.不同字符的最小子序列
 * 
 * 给你一个字符串 s ，请你去除字符串中重复的字母，使得每个字母只出现一次。需保证 返回结果的字典序最小（要求不能打乱其他字符的相对位置）。
 * （返回 s 字典序最小的子序列，该子序列包含 s 的所有不同字符，且只包含一次。）
 * 
 * 链接：https://leetcode-cn.com/problems/remove-duplicate-letters/
 *      https://leetcode-cn.com/problems/smallest-subsequence-of-distinct-characters/
 */

public class Solution
{
    public string RemoveDuplicateLetters(string s)
    {
        var result = "";
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!stack.Contains(s[i]))
            {
                while (stack.Count() > 0 && stack.Peek() >= s[i])
                {
                    if (s.LastIndexOf(stack.Peek()) > i)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        break;
                    }
                }
                stack.Push(s[i]);
            }
        }
        while (stack.Count() > 0)
        {
            result = stack.Pop() + result;
        }
        return result;
    }
}

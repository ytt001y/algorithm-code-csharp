/**
 * 题目：917.仅仅反转字母
 * 
 * 给定一个字符串 S，返回 “反转后的” 字符串，其中不是字母的字符都保留在原地，而所有字母的位置发生反转。
 * 
 * 链接：https://leetcode-cn.com/problems/reverse-only-letters/
 */

public class Solution
{
    public string ReverseOnlyLetters(string S)
    {
        var headString = "";
        var tailString = "";
        int head = 0, tail = S.Length - 1;
        while (head <= tail)
        {
            if (head == tail)
            {
                headString += S[head];
                break;
            }
            if (IsValidChar(S[head]) && IsValidChar(S[tail]))
            {
                headString += S[tail];
                tailString = S[head] + tailString;
                head++;
                tail--;
                continue;
            }

            if (!IsValidChar(S[head]))
            {
                headString += S[head];
                head++;
            }
            if (!IsValidChar(S[tail]))
            {
                tailString = S[tail] + tailString;
                tail--;
            }
        }
        return headString + tailString;
    }
    public bool IsValidChar(char s)
    {
        return (s >= 'a' && s <= 'z') || (s >= 'A' && s <= 'Z');
    }
}
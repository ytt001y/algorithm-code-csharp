/**
 * 题目：1415. 长度为 n 的开心字符串中字典序第 k 小的字符串
 * 
 * 一个 「开心字符串」定义为：
 * 仅包含小写字母 ['a', 'b', 'c'].
 * 对所有在 1 到 s.length - 1 之间的 i ，满足 s[i] != s[i + 1] （字符串的下标从 1 开始）。
 * 比方说，字符串 "abc"，"ac"，"b" 和 "abcbabcbcb" 都是开心字符串，但是 "aa"，"baa" 和 "ababbc" 都不是开心字符串。
 * 给你两个整数 n 和 k ，你需要将长度为 n 的所有开心字符串按字典序排序。
 * 请你返回排序后的第 k 个开心字符串，如果长度为 n 的开心字符串少于 k 个，那么请你返回 空字符串 。
 * 
 * 链接：https://leetcode-cn.com/problems/the-k-th-lexicographical-string-of-all-happy-strings-of-length-n/
 */

public class Solution
{
    public string GetHappyString(int n, int k)
    {
        string result = "";
        int length = 3 * (int)Math.Pow(2, n - 1);
        if (k <= length)
        {
            int index = k;
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    var itemLenght = length / 3;
                    var a = itemLenght;
                    var b = itemLenght * 2;
                    if (index <= a)
                    {
                        result += "a";
                    }
                    else if (index > a && index <= b)
                    {
                        result += "b";
                        index -= itemLenght;
                    }
                    else
                    {
                        result += "c";
                        index -= 2 * itemLenght;
                    }
                    length = itemLenght;
                }
                else
                {
                    var itemLength = length / 2;
                    switch (result.Last())
                    {
                        case 'a':
                            result += (index <= itemLength) ? 'b' : 'c';
                            break;
                        case 'b':
                            result += (index <= itemLength) ? 'a' : 'c';
                            break;
                        case 'c':
                            result += (index <= itemLength) ? 'a' : 'b';
                            break;
                    }
                    if (index > itemLength)
                    {
                        index -= itemLength;
                    }
                    length = itemLength;
                }
            }
        }
        return result;
    }
}
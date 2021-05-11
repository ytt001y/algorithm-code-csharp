/**
 * ��Ŀ��917.������ת��ĸ
 * 
 * ����һ���ַ��� S������ ����ת��ġ� �ַ��������в�����ĸ���ַ���������ԭ�أ���������ĸ��λ�÷�����ת��
 * 
 * ���ӣ�https://leetcode-cn.com/problems/reverse-only-letters/
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
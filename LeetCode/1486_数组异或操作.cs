/**
 * ��Ŀ��1486.����������
 * 
 * ��������������n �� start ��
 * ���� nums ����Ϊ��nums[i] = start + 2*i���±�� 0 ��ʼ���� n == nums.length ��
 * �뷵�� nums ������Ԫ�ذ�λ���XOR����õ��Ľ����
 * 
 * ���ӣ�https://leetcode-cn.com/problems/xor-operation-in-an-array/
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
/**
 * 题目：1310.子数组异或查询
 * 
 * 有一个正整数数组 arr，现给你一个对应的查询数组 queries，其中 queries[i] = [Li, Ri]。
 * 对于每个查询 i，请你计算从 Li 到 Ri 的 XOR 值（即 arr[Li] xor arr[Li+1] xor ... xor arr[Ri]）作为本次查询的结果。
 * 并返回一个包含给定查询 queries 所有结果的数组。
 * 
 * 链接：https://leetcode-cn.com/problems/xor-queries-of-a-subarray/
 */
class Program
{
    public int[] XorQueries(int[] arr, int[][] queries)
    {
        var result = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (queries[i][0] == queries[j][0] && queries[j][1] == queries[i][1])
                {
                    result[i] = result[j];
                    goto _Continue;
                }
            }
            int index = queries[i][0];
            int item = arr[index];
            while (index++ < queries[i][1])
            {
                item ^= arr[index];
            }
            result[i] = item;
        _Continue:;
        }
        return result;
    }
}

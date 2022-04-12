namespace Algorithm.LeetCode
{
    /**
     * 题目：495.提莫攻击
     * 
     * 在《英雄联盟》的世界中，有一个叫 “提莫” 的英雄，他的攻击可以让敌方英雄艾希（编者注：寒冰射手）进入中毒状态。现在，给出提莫对艾希的攻击时间序列和提莫攻击的中毒持续时间，你需要输出艾希的中毒状态总时长。
     * 你可以认为提莫在给定的时间点进行攻击，并立即使艾希处于中毒状态。
     * 
     * 链接：https://leetcode-cn.com/problems/teemo-attacking/
     */

    public partial class Solution
    {
        public int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            if (timeSeries == null || timeSeries.Count() == 0)
            {
                return 0;
            }
            var time = timeSeries.Last() - timeSeries.First() + duration;
            for (int i = timeSeries.Length - 1; i > 0; i--)
            {
                var interval = timeSeries[i] - timeSeries[i - 1];
                if (interval > duration)
                {
                    time -= (interval - duration);
                }
            }
            return time;
        }
    }
}

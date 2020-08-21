using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.LeetCode.QuestionBank
{
    //两数之和
    public partial class Solution
    {
        public int[] TwoSum01(int[] nums, int target)
        {
            int count = nums.Length;
            for (int i = 0; i < count; i++)
            {
                int last = target - nums[i];
                for (int j = i + 1; j < count; j++)
                {
                    if (last == nums[j])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            throw new Exception("不存在满足条件的两个数");
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int count = nums.Length;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < count; i++)
            {
                int last = target - nums[i];
                if (dic.ContainsKey(last))
                {
                    return new int[] { dic[last], i };
                }
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);
                }
            }
            throw new Exception("不存在满足条件的两个数");
        }
    }
}

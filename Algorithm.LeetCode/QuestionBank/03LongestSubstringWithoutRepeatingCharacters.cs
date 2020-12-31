using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.LeetCode.QuestionBank
{
    //无重复字符的最长子串
    public partial class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                throw new ArgumentNullException($"类型为{ typeof(string).Name }的参数为空");
            }
            int n = s.Length;
            //哈希集合，记录每个字符是否出现过
            HashSet<char> dic = new HashSet<char>();
            //右指针,初始值为-1,相当于我们在字符串的左边界的左边，还没看是移动
            int rk = -1,
                ans = 0;
            for (int i = 0; i < n; ++i)
            {
                if (i != 0)
                {
                    //左指针向右移动一格，移除一个字符
                    dic.Remove(s[i - 1]);
                }
                while (rk + 1 < n && !dic.Contains(s[rk + 1]))
                {
                    //不断地移动右指针
                    dic.Add(s[rk + 1]);
                    ++rk;
                }
                //第i个到rk个字符是一个极长的无重复字符子串
                ans = Math.Max(ans, rk - i + 1);
            }
            return ans;
        }
    }
}

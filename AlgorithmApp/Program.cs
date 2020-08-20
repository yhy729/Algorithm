using System;
using Algorithm.LeetCode.QuestionBank;

namespace Algorithm.App
{
    /// <summary>
    /// 本项目主要用于记录基础算法的研究与学习
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************客户端程序调用开始****************************");
            try
            {
                var solution = new Solution();
                {
                    int[] nums = new int[] { 2, 7, 8, 11, 23 };
                    int target = 15;
                    var result01 = solution.TwoSum01(nums, target);
                    var result = solution.TwoSum(nums, target);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"程序出错:{ex.Message}");
            }
            Console.WriteLine("***************************客户端程序调用完成****************************");
            Console.ReadKey();
        }
    }
}

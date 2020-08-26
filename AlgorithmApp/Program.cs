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
                    //01两数之和
                    int[] nums = new int[] { 2, 7, 8, 11, 23 };
                    int target = 15;
                    var result01 = solution.TwoSum01(nums, target);
                    var result = solution.TwoSum(nums, target);
                }
                {
                    //02两数相加
                    ListNode l1 = new ListNode(2);
                    l1.next = new ListNode(4);
                    l1.next.next = new ListNode(3);
                    ListNode l2 = new ListNode(5);
                    l2.next = new ListNode(6);
                    l2.next.next = new ListNode(4);
                    var result = solution.AddTwoNumbers(l1, l2);
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

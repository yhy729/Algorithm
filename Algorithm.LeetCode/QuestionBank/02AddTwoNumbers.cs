using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.LeetCode.QuestionBank
{
    //两数相加[2,4,3],[5,6,4]
    public partial class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dumyHead = new ListNode(0);
            ListNode p = l1,
                     q = l2,
                     curr = dumyHead;
            int carry = 0;
            List<int> arr = new List<int>();
            while (p != null || q != null)
            {
                int x = p != null ? p.val : 0;
                int y = q?.val ?? 0;
                int sum = carry + x + y;
                carry = sum / 10;
                //curr.next = new ListNode(sum % 10);
                arr.Add(sum % 10);
                if (p != null)
                    p = p.next;
                if (q != null)
                    q = q.next;
            }
            if (carry > 0)
            {
                //curr.next = new ListNode(carry);
                arr.Add(carry);
            }
            return dumyHead;
        }
    }

    public class ListNode
    {
        public int val;

        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }

}

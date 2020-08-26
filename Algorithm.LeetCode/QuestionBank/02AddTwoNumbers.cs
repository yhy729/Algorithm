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
            while (p != null || q != null)
            {
                int x = p != null ? p.val : 0;
                int y = q?.val ?? 0;
                int sum = carry + x + y;
                int currentVal = sum % 10;
                carry = sum / 10;

                curr.next = new ListNode(currentVal);
                curr = curr.next;

                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }
            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }
            return dumyHead.next;
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

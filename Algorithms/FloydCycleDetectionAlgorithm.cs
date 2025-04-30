namespace Algorithms;

class FloydCycleDetectionAlgorithm
{
    public static bool HasCycle(ListNode? head)
    {
        ListNode? fast = head;
        ListNode? slow = head;

        while (fast != null && fast.Next != null)
        {
            slow = slow?.Next;
            fast = fast.Next.Next;

            if (slow == fast)
                return true;
        }
        return false;
    }
}

namespace Algorithms;

public class ListNode
{
    public int Value;
    public ListNode? Next;

    public ListNode(int value) => this.Value = value;

}

public static class SinglyLinkedListReversal
{
    public static ListNode? ReverseList(ListNode? head)
    {
        ListNode? prev = null;
        ListNode? curr = head;
        ListNode? next = null;

        while (curr != null)
        {
            next = curr.Next;
            curr.Next = prev;
            prev = curr;
            curr = next;
        }
        return prev;
    }

    public static void PrintList(ListNode? head)
    {
        ListNode? current = head;
        while (current != null)
        {
            Console.Write(current.Value + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}

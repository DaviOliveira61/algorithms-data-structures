using DataStructures;
using Algorithms;

Console.Clear();

// RemoveDuplicatedCharsString removeDuplicatedCharsString = new();
// removeDuplicatedCharsString.Run();

// Check if it is an anagram
//IsAnagrams isAnagrams = new();
//isAnagrams.Run();

// Fibonacci number
//Console.WriteLine(Fibonacci.Calculate(30));

// Fibonacci sequence starting from 0 and using a recursive method
//Fibonacci.CallRecursively(30);

// Binary search
/* Binary Search is a widely used searching algorithm that efficiently finds the position of a target value 
   within a sorted array. 
   It works by repeatedly dividing the search interval in half. */

/*int[] sortedArray = { 1, 2, 3, 6, 9, 10, 23, 105 };
int result = BinarySearch.Search(sortedArray, 203);

if (result != -1)
    Console.WriteLine("Target found at index: " + result);
else
    Console.WriteLine("Target not found!"); */

ListNode head = new(1);
head.Next = new(2);
head.Next.Next = new(3);
head.Next.Next.Next = new(4);
head.Next.Next.Next.Next = new(5);

Console.WriteLine("Original List:");
SinglyLinkedListReversal.PrintList(head);

Console.WriteLine("Reversed List:");
head = SinglyLinkedListReversal.ReverseList(head);
SinglyLinkedListReversal.PrintList(head);
Console.ReadKey();

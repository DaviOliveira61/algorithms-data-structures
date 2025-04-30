using DataStructures;
using Algorithms;

Console.Clear();
// DATA STRUCTURES 
// RemoveDuplicatedCharsString removeDuplicatedCharsString = new();
// removeDuplicatedCharsString.Run();

// Check if it is an anagram
//IsAnagrams isAnagrams = new();
//isAnagrams.Run();

// ALGORITHMS
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

/* SinglyLinkedListReversal
ListNode head = new(1);
head.Next = new(2);
head.Next.Next = new(3);
head.Next.Next.Next = new(4);
head.Next.Next.Next.Next = new(5);

Console.WriteLine("Original List:");
SinglyLinkedListReversal.PrintList(head);

Console.WriteLine("Reversed List:");
head = SinglyLinkedListReversal.ReverseList(head);
SinglyLinkedListReversal.PrintList(head); */

/*
* Floyd's Cycle Detection Algorithm, also known as the "tortoise and hare" algorithm, 
* is a popular algorithm used to detect cycles in a linked list or any cyclic sequence. 
* It's particularly efficient in terms of both time and space complexity.
*/
/*
var a = new ListNode(1);
var b = new ListNode(2);
var c = new ListNode(3);
var d = new ListNode(4);

a.Next = b;
b.Next = c;
c.Next = d;
//d.Next = b;

Console.WriteLine(FloydCycleDetectionAlgorithm.HasCycle(a)); */

Console.ReadKey();

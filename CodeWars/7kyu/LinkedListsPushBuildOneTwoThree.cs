/*
https://www.codewars.com/kata/55be95786abade3c71000079/csharp

7 kyu
Linked Lists - Push & BuildOneTwoThree

Linked Lists - Push & BuildOneTwoThree

Write push() and buildOneTwoThree() functions to easily update and initialize linked lists. 
Try to use the push() function within your buildOneTwoThree() function.

Here's an example of push() usage:

Node chained = null;
chained = Node.Push(chained, 3);
chained = Node.Push(chained, 2);
chained = Node.Push(chained, 1);
Node.Push(chained, 8) => 8 -> 1 -> 2 -> 3 -> null
The push function accepts head and data parameters, where head is either a node object or null/None/nil. 
Your push implementation should be able to create a new linked list/node when head is null/None/nil.

The buildOneTwoThree function should create and return a linked list with three nodes: 1 -> 2 -> 3 -> null

Related Kata in order of expected completion (increasing difficulty):
 Linked Lists - Push & BuildOneTwoThree
 Linked Lists - Length & Count
 Linked Lists - Get Nth Node
Linked Lists - Insert Nth Node
Linked Lists - Sorted Insert
Linked Lists - Insert Sort
Linked Lists - Append
Linked Lists - Remove Duplicates
Linked Lists - Move Node
Linked Lists - Move Node In-place
Linked Lists - Alternating Split
Linked Lists - Front Back Split
Linked Lists - Shuffle Merge
Linked Lists - Sorted Merge
Linked Lists - Merge Sort
Linked Lists - Sorted Intersect
Linked Lists - Iterative Reverse
Linked Lists - Recursive Reverse

Inspired by Stanford Professor Nick Parlante's excellent Linked List teachings.

I'm aware that there are better ways to create linked lists (class methods, reference pointers, etc.), but not all languages have the same features. 
I'd like to keep the basic API consistent between language translations for this kata.
*/

namespace CodeWars
{
    public class LinkedListsPushBuildOneTwoThree
    {
        //Replace LinkedListsPushBuildOneTwoThree to Node
        public int Data;
        public LinkedListsPushBuildOneTwoThree Next;

        public LinkedListsPushBuildOneTwoThree(int data, LinkedListsPushBuildOneTwoThree next = null)
        {
            Data = data;
            Next = next;
        }

        public static LinkedListsPushBuildOneTwoThree Push(LinkedListsPushBuildOneTwoThree head, int data)
        {
            return new LinkedListsPushBuildOneTwoThree(data, head);
        }

        public static LinkedListsPushBuildOneTwoThree BuildOneTwoThree()
        {
            return new LinkedListsPushBuildOneTwoThree(1,
                new LinkedListsPushBuildOneTwoThree(2, new LinkedListsPushBuildOneTwoThree(3)));
        }

        // public int Data;
        // public Node Next;
        //
        // public Node(int data, Node next = null)
        // {
        //     Data = data;
        //     Next = next;
        // }
        //
        // public static Node Push(Node head, int data) => new Node(data, head);
        // public static Node BuildOneTwoThree() => new Node(1, new Node(2, new Node(3)));
    }
}
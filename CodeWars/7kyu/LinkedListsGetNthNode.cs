/*
https://www.codewars.com/kata/55befc42bfe4d13ab1000007/csharp

7 kyu
Linked Lists - Get Nth Node

Linked Lists - Get Nth

Implement a GetNth() function that takes a linked list and an integer index and returns the node stored at the Nth index position. 
GetNth() uses the C numbering convention that the first node is index 0, 
the second is index 1, ... and so on. So for the list 42 -> 13 -> 666, GetNth() with index 1 should return Node(13);

Node.GetNth(1 -> 2 -> 3 -> null, 0).Data == 1
Node.GetNth(1 -> 2 -> 3 -> null, 1).Data == 2
The index should be in the range [0..length-1]. If it is not, GetNth() should throw/raise an exception (ArgumentException in C#, InvalidArgumentException in PHP). 
You should also raise an exception (ArgumentException in C#, InvalidArgumentException in PHP) if the list is empty/null/None.

Prerequisite Kata (may be in beta):

Linked Lists - Push & BuildOneTwoThree
Linked Lists - Length & Count
The push() and buildOneTwoThree() (BuildOneTwoThree in C#, build_one_two_three() in PHP) functions do not need to be redefined.

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

http://cslibrary.stanford.edu/103/LinkedListBasics.pdf
http://cslibrary.stanford.edu/105/LinkedListProblems.pdf
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class LinkedListsGetNthNode : Object
    {
        // Constructor for IEnumerable<int>s
        // Makes it easier to construct large lists
        public static LinkedListsGetNthNode Build(IEnumerable<int> values)
        {
            if (values == null || !values.Any())
            {
                throw new ArgumentException("Node(IEnumerable<int>)'s first argument must not be empty.");
            }

            LinkedListsGetNthNode node = null;

            foreach (int value in Enumerable.Reverse(values))
            {
                LinkedListsGetNthNode temp = node;
                node = new LinkedListsGetNthNode(value);
                node.Next = temp;
            }

            return node;
        }

        public static LinkedListsGetNthNode BuildOneTwoThree()
        {
            LinkedListsGetNthNode head = null;
            head = LinkedListsGetNthNode.Push(head, 3);
            head = LinkedListsGetNthNode.Push(head, 2);
            head = LinkedListsGetNthNode.Push(head, 1);
            return head;
        }

        public override bool Equals(Object obj)
        {
            // Check for null values and compare run-time types.
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return this.ToString() == obj.ToString();
        }

        public static LinkedListsGetNthNode Push(LinkedListsGetNthNode head, int data)
        {
            LinkedListsGetNthNode node = new LinkedListsGetNthNode(data);
            node.Next = head;
            return node;
        }

        // Override which allows user to "print" node and view data values
        // Example:
        // new Node(3, new Node(2, new Node(1, null))) -> "3 -> 2 -> 1 -> null"
        public override string ToString()
        {
            List<int> result = new List<int>();
            LinkedListsGetNthNode curr = this;

            while (curr != null)
            {
                result.Add(curr.Data);
                curr = curr.Next;
            }

            return String.Join(" -> ", result) + " -> null";
        }


        public int Data;
        public LinkedListsGetNthNode Next;

        public LinkedListsGetNthNode(int data)
        {
            Data = data;
            Next = null;
        }

        //LinkedListsGetNthNode -> Node, rename LinkedListsGetNthNode to Node in kata
        public static LinkedListsGetNthNode GetNth(LinkedListsGetNthNode node, int index)
        {
            return node == null ? throw new ArgumentException() : index == 0 ? node : GetNth(node.Next, index - 1);
        }
    }
}
﻿using WeCamp_DataStructureAndAlgorithm.Models;
using WeCamp_DataStructureAndAlgorithm.Problems;

namespace WeCamp_DataStructureAndAlgorithm
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string s = "A man, a plan, a canal: Panama";
			Console.WriteLine($"String {s} is a valid palindrome {ValidPalindrome.IsPalindrome(s)}");
			/*
			int[] nums = {1,2,2,1};
			Console.Write($"The next greater Element is ");
			foreach (int i in NextGreaterElementsII.Solution(nums))
			{
				Console.Write(i + ", ");
			}
			
			int[] nums = { 3, 2, 3 };
			Console.WriteLine($"The majority element is {MajorityElement.Solution(nums)}");

			
			int[] nums = { 2, 7, 11, 15 };
			int target = 9;
			Console.Write($"Indices of the two numbers such that they add up to {target} is ");
			foreach( int i in TwoSum.Solution(nums, target) )
			{
				Console.Write( i  + ", ");
			}

			
			string s = "leEeetcode";
			Console.WriteLine($"The great string of {s} is {MakeTheStringGreat.MakeGood(s)}");
			
			
			string s = "loveleetcode";
			Console.WriteLine($"The index of the first unique character is {FirstUniqueCharacterInAString.FirstUniqChar(s)}");
			
			string s = "abcd", t = "abcde";
			Console.WriteLine($"Find the different: {FindTheDifference.Solution(s, t)}");
			
			string s = "ABFCACDB";
			Console.WriteLine($"Minimum String Length After Removing Substrings: {MinimumStringLengthAfterRemovingSubstrings.Solution(s)}");
			
			string s = "anagram", t = "nagaram";
			Console.WriteLine($"Valid Anagram: {ValidAnagram.Solution(s, t)}");
			
			int[] nums = { 1, 2, 3, };
			Console.WriteLine($"Monotonic Array: {MonotonicArray.Solution(nums)}");
			
			ListNode head = new ListNode(4);
			head.next = new ListNode(2);
			head.next.next = new ListNode(8);

			// Binary Tree Node creation (root = [1,4,4,null,2,2,null,1,null,6,8,null,null,null,null,1,3])
			TreeNode root = new TreeNode(1);

			// Left subtree of root
			root.left = new TreeNode(4);
			root.left.right = new TreeNode(2);
			root.left.right.left = new TreeNode(1);

			// Right subtree of root
			root.right = new TreeNode(4);
			root.right.left = new TreeNode(2);
			root.right.left.left = new TreeNode(6);
			root.right.left.right = new TreeNode(8);
			root.right.left.left.left = new TreeNode(1);
			root.right.left.right.right = new TreeNode(3);

			Console.WriteLine(LinkedListInBinaryTree.IsSubPath(head, root));
			*/
		}
	}
}

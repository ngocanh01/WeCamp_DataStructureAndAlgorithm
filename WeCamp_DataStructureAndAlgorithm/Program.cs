using WeCamp_DataStructureAndAlgorithm.Models;
using WeCamp_DataStructureAndAlgorithm.Problems;

namespace WeCamp_DataStructureAndAlgorithm
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
			Console.WriteLine($"Group anagram: ");
			foreach (var str in GroupAnagrams.Solution(strs))
			{
				foreach(var i in str)
				{
					Console.Write(i + ", ");
				}				
				Console.WriteLine();
			}
			/*
			int[] tickets = [2, 3, 2];
			int k = 2;
			Console.WriteLine($" Time Needed to Buy Tickets is {TimeNeededToBuyTickets.TimeRequiredToBuy(tickets, k)}");
			/*
			// >>>>>>
			// <<<<<<
			// ><><>
			// v<^>
			// >^<v
			// <v<<>
			// >><<v<
			string input = ">>>>>>";
			Console.Write($"Result 1 is ");
			foreach (bool i in CheckValid.Solution(input))
			{
				Console.Write(i + ", ");
			}
			Console.WriteLine();
			string input2 = "<<<<<<";			
			Console.Write($"Result 2 is ");
			foreach (bool i in CheckValid.Solution(input2))
			{
				Console.Write(i + ", ");
			}
			Console.WriteLine();
			string input3 = "><><>";
			Console.Write($"Result 3 is ");
			foreach (bool i in CheckValid.Solution(input3))
			{
				Console.Write(i + ", ");
			}
			Console.WriteLine();
			string input4 = "v<^>";
			Console.Write($"Result 4 is ");
			foreach (bool i in CheckValid.Solution(input4))
			{
				Console.Write(i + ", ");
			}
			Console.WriteLine();
			string input5 = ">^<v";
			Console.Write($"Result 5 is ");
			foreach (bool i in CheckValid.Solution(input5))
			{
				Console.Write(i + ", ");
			}
			Console.WriteLine();
			string input6 = "<v<<>";
			Console.Write($"Result 6 is ");
			foreach (bool i in CheckValid.Solution(input6))
			{
				Console.Write(i + ", ");
			}
			Console.WriteLine();
			string input7 = ">><<v<";
			Console.Write($"Result 7 is ");
			foreach (bool i in CheckValid.Solution(input7))
			{
				Console.Write(i + ", ");
			}
			/*
			string s = "A man, a plan, a canal: Panama";
			Console.WriteLine($"String {s} is a valid palindrome {ValidPalindrome.IsPalindrome(s)}");
			
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

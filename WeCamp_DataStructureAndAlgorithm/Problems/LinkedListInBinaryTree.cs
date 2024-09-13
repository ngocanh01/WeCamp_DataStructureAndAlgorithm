using WeCamp_DataStructureAndAlgorithm.Models;

namespace WeCamp_DataStructureAndAlgorithm.Problems
{
    public static class LinkedListInBinaryTree
	{
		public static bool IsSubPath(ListNode head, TreeNode root)
		{
			if (root == null) return false; 
			return Dfs(root, head) || IsSubPath(head, root.left) || IsSubPath(head, root.right);
		}

		public static bool Dfs(TreeNode root, ListNode head)
		{
			if (head == null) return true; 
			if (root == null) return false; 
			if (root.val != head.val) return false; 

			return Dfs(root.left, head.next) || Dfs(root.right, head.next);
		}
	}
}

namespace WeCamp_DataStructureAndAlgorithm.Problems
{
	public static class MinimumStringLengthAfterRemovingSubstrings
	{
		public static int Solution(string s)
		{
			var stack = new Stack<char>();

			foreach (char c in s)
			{
				if (c == 'B' && stack.Count > 0 && stack.Peek() == 'A')
				{
					stack.Pop();
				}
				else if (c == 'D' && stack.Count > 0 && stack.Peek() == 'C')
				{
					stack.Pop();
				}
				else
				{
					stack.Push(c);
				}
			}

			return stack.Count;
		}
	}
}

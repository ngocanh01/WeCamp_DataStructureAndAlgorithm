namespace WeCamp_DataStructureAndAlgorithm.Problems
{
	public static class MakeTheStringGreat
	{
		public static string MakeGood(string s)
		{
			var stack = new Stack<char>();
			foreach (char c in s)
			{
				if (stack.Count > 0 && AreOppositeCases(stack.Peek(), c)) stack.Pop();				
				else stack.Push(c);				
			}
			char[] result = stack.ToArray();
			Array.Reverse(result);
			return new string(result);
		}
		private static bool AreOppositeCases(char a, char b)
		{
			return Math.Abs(a - b) == 32;
		}
	}
}

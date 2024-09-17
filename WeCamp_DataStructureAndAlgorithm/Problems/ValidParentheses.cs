namespace WeCamp_DataStructureAndAlgorithm.Problems
{
	public static class ValidParentheses
	{
		public static bool IsValid(string s)
		{
			List<int> myList = new List<int>();
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == '(')
				{
					myList.Add(1);
					continue;
				}
				if (s[i] == '[')
				{
					myList.Add(2);
					continue;
				}
				if (s[i] == '{')
				{
					myList.Add(3);
					continue;
				}
				if (myList.Count == 0)
				{
					return false;
				}
				if (s[i] == ')' && myList[myList.Count - 1] == 1)
				{
					myList.RemoveAt(myList.Count - 1);
					continue;
				}
				if (s[i] == ']' && myList[myList.Count - 1] == 2)
				{
					myList.RemoveAt(myList.Count - 1);
					continue;
				}
				if (s[i] == '}' && myList[myList.Count - 1] == 3)
				{
					myList.RemoveAt(myList.Count - 1);
					continue;
				}
				return false;
			}
			return myList.Count == 0;
		}
	}
}

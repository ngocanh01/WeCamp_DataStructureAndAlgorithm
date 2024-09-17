namespace WeCamp_DataStructureAndAlgorithm.Problems
{
	public static class ValidPalindrome
	{
		public static bool IsPalindrome(string s)
		{
			string t = s.ToLower();
			t = string.Concat(t.Where(char.IsLetterOrDigit));

			int length = t.Length;
			if (length == 0)
			{
				return true;
			}

			int mid = length / 2;
			int start = 0;
			int end = length - 1;

			for (int i = 0; i < mid; i++)
			{
				if (t[start] != t[end])
				{
					return false;
				}
				start++;
				end--;
			}
			return true;
		}
	}
}

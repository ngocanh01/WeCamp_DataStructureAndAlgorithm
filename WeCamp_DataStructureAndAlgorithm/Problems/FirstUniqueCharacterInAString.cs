namespace WeCamp_DataStructureAndAlgorithm.Problems
{
	public static class FirstUniqueCharacterInAString
	{
		public static int FirstUniqChar(string s)
		{
			if (string.IsNullOrEmpty(s)) return -1;

			Dictionary<char, int> charCount = new Dictionary<char, int>();
			for (int i = 0; i < s.Length; i++)
			{
				if (charCount.ContainsKey(s[i])) charCount[s[i]]++;
				else charCount[s[i]] = 1;
			}

			for (int i = 0; i < s.Length; i++)
			{
				if (charCount[s[i]] == 1) return i;

			}

			return -1;
		}
	}
}

namespace WeCamp_DataStructureAndAlgorithm.Problems
{
	public static class FindTheDifference
	{
		public static char Solution(string s, string t)
		{			
			var dic = new Dictionary<char, int>();
			for (int i = 0; i < s.Length; i++)
			{
				if (dic.ContainsKey(s[i]))
				{
					dic[s[i]]++;
				}
				else
				{
					dic[s[i]] = 1;
				}
			}

			for (int i = 0; i < t.Length; i++)
			{
				if (dic.ContainsKey(t[i]) && dic[t[i]] > 0)
				{
					dic[t[i]]--;
				}
				else
				{
					return t[i];
				}
			}
			return 'z';			
		}
	}
}

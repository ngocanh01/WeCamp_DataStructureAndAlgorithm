namespace WeCamp_DataStructureAndAlgorithm.Problems
{
	public static class ValidAnagram
	{
		public static bool Solution(string s, string t)
		{
			if (s.Length != t.Length)
			{
				return false;
			}
			Dictionary<char, int> dic = new Dictionary<char, int>();

			foreach (char i in s)
			{
				if (dic.ContainsKey(i))
				{
					dic[i] += 1;
				}
				else
				{
					dic.Add(i, 1);
				}
			}

			foreach (char i in t)
			{
				if (dic.ContainsKey(i) && dic[i] > 0)
				{
					dic[i] -= 1;
				}
				else
				{
					return false;
				}
			}

			return true;
		}
	}
}

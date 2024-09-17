namespace WeCamp_DataStructureAndAlgorithm.Problems
{
	public static class GroupAnagrams
	{
		public static IList<IList<string>> Solution(string[] strs)
		{
			var grouped = new Dictionary<string, List<string>>();

			foreach (var str in strs)
			{
				char[] charArray = str.ToCharArray();
				Array.Sort(charArray);
				string sortedStr = new string(charArray);

				if (!grouped.ContainsKey(sortedStr))
					grouped[sortedStr] = new List<string>();

				grouped[sortedStr].Add(str);
			}
			return new List<IList<string>>(grouped.Values);
		}
	}
}

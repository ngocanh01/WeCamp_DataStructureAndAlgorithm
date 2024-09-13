namespace WeCamp_DataStructureAndAlgorithm.Problems
{
	public static class TwoSum
	{
		public static int[] Solution(int[] nums, int target)
		{
			var dic = new Dictionary<int, int>();

			for (int i = 0; i < nums.Length; i++)
			{
				int minus = target - nums[i];
				if (dic.ContainsKey(minus))
				{
					return new int[] { dic[minus], i };
				}
				dic[nums[i]] = i;
			}
			return new int[] { };
		}
	}
}

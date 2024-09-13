namespace WeCamp_DataStructureAndAlgorithm.Problems
{
	public static class MajorityElement
	{
		public static int Solution(int[] nums)
		{
			var dic = new Dictionary<int, int>();
			int mid = nums.Length / 2;

			foreach (int i in nums)
			{
				if (dic.ContainsKey(i)) dic[i]++;
				
				else dic[i] = 1;
				
				if (dic[i] > mid) return i;				
			}
			return 0;
		}
	}
}

namespace WeCamp_DataStructureAndAlgorithm.Problems
{
	public static class MonotonicArray
	{
		public static bool Solution(int[] nums)
		{
			bool isIncrease = false, isDecrease = false;

			for (int i = 0; i < nums.Length - 1; i++)
			{
				if (nums[i] < nums[i + 1])
				{
					isIncrease = true;
				}
				if (nums[i] > nums[i + 1])
				{
					isDecrease = true;
				}
			}
			if (isIncrease && isDecrease)
			{
				return false;
			}
			return true;
		}
	}
}

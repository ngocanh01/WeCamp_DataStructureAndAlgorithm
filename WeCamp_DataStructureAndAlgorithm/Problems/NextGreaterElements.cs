namespace WeCamp_DataStructureAndAlgorithm.Problems
{
	public static class NextGreaterElementsII
	{
		public static int[] Solution(int[] nums)
		{
			Stack<int> stack = new Stack<int>();
			int[] res = new int[nums.Length];
			Array.Fill(res, -1);

			for (int i = 0; i < nums.Length; i++)
			{
				while (stack.Count > 0 && nums[stack.Peek()] < nums[i])
				{
					res[stack.Pop()] = nums[i];
				}
				stack.Push(i);
			}

			for (int i = 0; i < nums.Length; i++)
			{
				while (stack.Count > 0 && nums[stack.Peek()] < nums[i])
				{
					res[stack.Pop()] = nums[i];
				}
			}

			return res;
		}
	}
}

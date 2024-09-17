namespace WeCamp_DataStructureAndAlgorithm.Problems
{
	public static class CheckValid
	{
		public static bool[] Solution(string input)
		{
			bool[] result = new bool[input.Length];
			for(int i = 0; i < input.Length; i++)
			{
				if (input[i] == '<' && i == 0)
				{
					result[i] = true;
					continue;
				}
				if (input[i] == '<' && result[i - 1] == true)
				{
					result[i] = true;
					continue;
				}
				if (input[i] == '>' && i == input.Length - 1)
				{
					result[i] = true;
					continue ;
				}
				if (input[i] == '^' || input[i] == 'v')
				{
					result[i] = true;
					continue ;
				}
				else
				{
					result[i] = false;
				}
			}
			return result;
		}
	}
}

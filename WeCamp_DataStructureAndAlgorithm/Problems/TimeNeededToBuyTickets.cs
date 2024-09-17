namespace WeCamp_DataStructureAndAlgorithm.Problems
{
	public static class TimeNeededToBuyTickets
	{
		public static int TimeRequiredToBuy(int[] tickets, int k)
		{
			int kValue = tickets[k];
			int count = 0;
			for (int i = 0; i < tickets.Length; i++)
			{
				int tempTime = 0;
				int currentValue = tickets[i];
				if (i <= k)
				{
					tempTime = currentValue < kValue ? currentValue : kValue;
				}
				else if (i > k)
				{
					tempTime = currentValue < kValue ? currentValue : kValue - 1;
				}
				count += tempTime;
			}
			return count;
		}
	}
}

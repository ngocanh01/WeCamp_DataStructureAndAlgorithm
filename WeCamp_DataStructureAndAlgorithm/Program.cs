using WeCamp_DataStructureAndAlgorithm.Problems;

namespace WeCamp_DataStructureAndAlgorithm
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			string s = "abcd", t = "abcde";
			Console.WriteLine($"Find the different: {FindTheDifference.Solution(s, t)}");
			
			string s = "ABFCACDB";
			Console.WriteLine($"Minimum String Length After Removing Substrings: {MinimumStringLengthAfterRemovingSubstrings.Solution(s)}");
			*/
			string s = "anagram", t = "nagaram";
			Console.WriteLine($"Valid Anagram: {ValidAnagram.Solution(s, t)}");
		}
	}
}

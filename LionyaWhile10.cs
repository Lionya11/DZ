using System;
					
public class Program
{
	public static void Main(string[] args)
	{
		int k = 0;
		int curr = 3;
		int N = Convert.ToInt32(Console.ReadLine());
		while(curr < N)
		{
		    k++;
			curr *= 3;
		}
		Console.WriteLine(k);
	}
}

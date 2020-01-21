using System;
					
public class Program
{
	public static void Main(string[] args)
	{
		int A = Convert.ToInt32(Console.ReadLine());
			int N = Convert.ToInt32(Console.ReadLine());
			int a = A;
			for(int i = 2; i <= N; i++)
				a = a * A;
			Console.WriteLine(a);
	}
}

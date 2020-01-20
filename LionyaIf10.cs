using System;
					
public class Program
{
	public static void Main()
	{
		int a = int.Parse(Console.ReadLine()); 
		int b = int.Parse(Console.ReadLine());

		if (a == b){
		a = 0;
		b = 0;	
		Console.WriteLine(a);
		Console.WriteLine(b);

		}
		else{
		Console.WriteLine(a+(a+b));
		Console.WriteLine(b+(a+b));

		}
	}
}

using System;

public class Shape
{
	public static void SquareRec()
	{
		Console.WriteLine();
		Console.Write("How long do you want this to be, Max 100: ");
		int length = Convert.ToInt16(Console.ReadLine());
		Console.WriteLine();
		Console.Write("And how tall? Max: 100: ");
		int height = Convert.ToInt16(Console.ReadLine());
		Console.WriteLine();
		Console.Write("Also what character do you want?: ");
		var item = Console.ReadKey(false).KeyChar;
        Console.WriteLine(" ");
        Console.WriteLine("Press Enter to continue");
        Console.ReadKey(true);
        Console.WriteLine();
		for (int i = 0; i < height; i++)
		{
			Console.WriteLine();
			for (int j = 0; j < length; j++)
			{
				Console.Write(item);
			}
		}
		Console.WriteLine(" ");
		Console.WriteLine("Press Enter to continue");
		Console.ReadKey(true);
		Console.WriteLine();
    }
}

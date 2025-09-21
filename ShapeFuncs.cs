using System;

public class Shape
{
    // Square and Rectangle
    public static int SquareRec()
	{
		Console.WriteLine();
		Console.Write("How long do you want this to be, Max 100: ");
		int length = Convert.ToInt16(Console.ReadLine());
		if (length > 100 || length < 1) { Console.WriteLine("Invalid length inputs"); return 1; }
        Console.WriteLine();
		Console.Write("And how tall? Max: 100: ");
		int height = Convert.ToInt16(Console.ReadLine());
		Console.WriteLine();
		if (height > 100 || height < 1) { Console.WriteLine("Invalid height inputs"); return 1; }
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
		return 0;
	}
	// hexagon to be made
	public static int Hexagon()
	{
		Console.WriteLine();
		Console.Write("How long do you want each side to be, Max 50: ");
		int side = Convert.ToInt16(Console.ReadLine());
		if (side > 50 || side < 1) { Console.WriteLine("Invalid side inputs"); return 1; }
        Console.WriteLine();
		Console.Write("What character do you want?: ");
		var item = Console.ReadKey(false).KeyChar;
		Console.WriteLine(" ");
		Console.WriteLine("Press Enter to continue");
		Console.ReadKey(true);
		Console.WriteLine();

		// this hexagon is a pain in the ass
		// so first im gonna make like an array map that maps out the array for the hexagon so later i can loop over it and just print it
		
        return 0;
	}
}

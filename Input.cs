using System;
public class Input
{
    public static void Question(string quest)
	{
		string helpMsg = "Commands:" +
				"\n/help: brings up help menu" +
				"\n/exit: exits out of the program" +
				"\nShapes:" +
				"\nType 1: Square," +
				"\nType 2: Hexagon";
		Console.WriteLine(quest);
	Console.WriteLine();
		string Field = Console.ReadLine();
		try
		{
			int FieldId = Convert.ToInt16(Field);
			switch (FieldId)
			{
				case 1:
					Shape.SquareRec();
					break;
				case 2:
					Shape.Hexagon();
					break;
				default:
					Console.WriteLine("Shape does not exist");
					Console.WriteLine();
					break;
			}
			Input.Question("What shape would you like to make?\ntype /help for more info or type /exit to exit this program now");
		}
		catch
		{
			switch (Field)
			{
				case "/help":
					Console.WriteLine();
					Console.WriteLine(helpMsg);
					Console.WriteLine();
					Input.Question("What shape would you like to make?\ntype /help for more info or type /exit to exit this program now");
					break;
				case "/exit":
					Environment.Exit(0);
					break;
				default:
					Console.WriteLine();
					Console.WriteLine("Command does not exist");
					Console.WriteLine();
					Input.Question("What shape would you like to make?\ntype /help for more info or type /exit to exit this program now");
					break;
			}
		
		}
	}
}

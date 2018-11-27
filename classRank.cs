using System;



public class ClassRank
{
	public static void Main()
	{
		int rank;
		string stringRank;
		string answer;

		Console.Out.WriteLine("\nPlease enter your class rank: ");
		stringRank = Console.ReadLine();
		rank = Convert.ToInt32(stringRank);

		Console.Out.WriteLine("\nType in yes if you would like to use a nested if structure. Type no if you would like to use a switch statement: ");
		answer = Console.ReadLine();
		if (String.Compare(answer, "no", true) == 0)
		{
			Console.Out.WriteLine(getRankSwitch(rank));
		}
		else
		{
			Console.Out.WriteLine(getRankIf(rank));
		}
	}

	public static String getRankSwitch(int number)
	{
		string message;

		switch(number)
		{
			case 1:
				message = "You're a Freshman";
				break;
			case 2:
				message = "You're a Softmore";
				break;
			case 3:
				message = "You're a Junior";
				break;
			case 4:
				message = "You're a Senior";
				break;
			default:
				message = "An error has occured.";
				break;
		}
		return message;
	}

	public static String getRankIf(int number)
	{
		string message = null;

		if (number == 1)
			message = "You're a Freshman";
		if (number == 2)
			message = "You're a Softmore";
		if (number == 3)
			message = "You're a Junior";
		if (number == 4)
			message = "You're a Senior";

		return message;
	}
}
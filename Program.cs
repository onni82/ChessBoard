/*
 * NET24
 * ONNI BUCHT
 * CHAS ACADEMY
 * PROGRAMMERING MED C# OCH .NET
 * LAB 2
 */
using System;

namespace ChessBoard
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//unicode to show the squares, and setting a unicode standard output
			Console.OutputEncoding = System.Text.Encoding.Unicode;

			Console.WriteLine("Skriv antal rader: ");

			// checks if an int variable for the amount of rows can be created, based on user input ◼︎
			if (int.TryParse(Console.ReadLine(), out int rows))
			{
				Console.WriteLine("Skriv antal kolumner: ");

				// checks if an int variable for the amount of columns, based on user input ◻︎
				if (int.TryParse(Console.ReadLine(), out int cols))
				{
					// loop through each row
					for (int i = 0; i < rows; i++)
					{
						// loop through each column
						for (int j = 0; j < cols; j++)
						{
							// check if it is an even or an odd position (to make it checkered)
							if ((i+j) % 2 == 0)
							{
								Console.Write("◼︎");
							}
							else
							{
								Console.Write("◻︎");
							}
						}
						// move to the next line after completing the row
						Console.WriteLine();
					}
				}
				else
				{
					Console.WriteLine("Du matade inte in ett tal.");
				}
			}
			else
			{
				Console.WriteLine("Du matade inte in ett tal.");
			}
		}
	}
}

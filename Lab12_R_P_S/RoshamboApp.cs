using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyLibrary;

namespace Lab12_R_P_S
{
	public class RoshamboApp
	{
		public RoshamboApp()
		{
			DoWork();
		}

		public void DoWork()
		{
			int playerWins = 0;
			int vvWins = 0;
			int ccWins = 0;

			bool again = true;

			CallousCarnivores cc = null;
			ValiantVegans vv = null;

			RoshamboPlayer rp = new RoshamboPlayer();
			rp.name = string.Empty;

			Console.WriteLine("Welcome to Rock Paper Scissors!\n");

			string name = InputHandlers.GetString("Enter your name: ");

			while (again)
			{
				try
				{
					rp.name = name;

					string str = "Would you like to play against the ";
					str += "Valiant Vegans or the Callous Carnivores? (vv/cc): ";
					string team = InputHandlers.GetString(str);

					if (team != "vv" && team != "cc")
					{
						Console.WriteLine("");
						continue;
					}

					Console.WriteLine();

					rp.value = SelectRPS();

					if (team == "vv")
					{
						vv = new ValiantVegans();
						vv.name = "Valiant Vegans";
						vv.GenerateRoshambo();

						int i = GetWinner(rp.value, vv.value, rp.name, vv.name);
						if (i > 0)
						{
							playerWins++;
						}
						else if(i < 0)
						{
							vvWins++;
						}
					}
					else
					{
						cc = new CallousCarnivores();
						cc.name = "Callous Carnivores";
						cc.GenerateRoshambo();

						int i = GetWinner(rp.value, cc.value, rp.name, cc.name);
						if (i > 0)
						{
							playerWins++;
						}
						else if(i < 0)
						{
							ccWins++;
						}
					}

					Console.WriteLine();
				}
				catch(Exception ex)
				{
					Console.WriteLine(ex.Message);
					Console.WriteLine("Instantiation of a new class, might cause an out of memory error...");
					Console.WriteLine("Because I have to many open visual studio projects and chrome tabs.");
				}

				again = InputHandlers.Continue("Play again? (y/n): ");
			}

			Console.WriteLine($"\nWins - {rp.name}: {playerWins}\tCallous Carnivores: {ccWins}\tValiant Vegans: {vvWins}\n");

			Console.WriteLine("Goodbye!");
		}

		//private Player.Roshambo SelectRPS()
		private string SelectRPS()
		{
			string selection = InputHandlers.GetString(
				"Rock, paper or scissors? (Enter r,p or s.): ");

			if (selection == "r")
			{
				//return Player.Roshambo.Rock;
				return "Rock";
			}
			else if (selection == "p")
			{
				//return Player.Roshambo.Paper;
				return "Paper";
			}
			else
			{
				//return Player.Roshambo.Scissors;
				return "Scissors";
			}
		}

		//private int GetWinner(Player.Roshambo us, Player.Roshambo them, string player, string enemy)
		private int GetWinner(string us, string them, string player, string enemy)
		{
			Console.WriteLine($"{player}: {us}");
			Console.WriteLine($"{enemy}: {them}");

			//if ((us == Player.Roshambo.Paper && them == Player.Roshambo.Rock) || 
			//	(us == Player.Roshambo.Rock && them == Player.Roshambo.Scissors) || 
			//	(us == Player.Roshambo.Scissors && them == Player.Roshambo.Paper))
			if ((us == "Paper" && them == "Rock") || 
				(us == "Rock" && them == "Scissors") || 
				(us == "Scissors" && them == "Paper"))
			{
				Console.WriteLine($"{player} wins!");
				return 1; // For player win.
			}
			else if (us == them)
			{
				Console.WriteLine("Draw!");
				return 0;
			}
			else
			{
				Console.WriteLine($"The {enemy} win!");
				return -1; // For enemy win.
			}
		}
	}
}

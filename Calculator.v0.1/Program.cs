using System;

namespace Calculator.v0._1
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("For Armenian Language Type 1.");
			Console.WriteLine("For English Type 2");

			int lang = Convert.ToInt32(Console.ReadLine());
			bool language = lang == 1;
			while (true)
			{
				if (language == true)
				{


					Console.WriteLine("Sexmir ENTER");
					Console.ReadKey();
					Console.WriteLine("Grir Arajin Tivy");
					decimal firstNumber = Convert.ToDecimal(Console.ReadLine());
					Console.WriteLine("Grir Erkrord Tivy");
					decimal secondNumber = Convert.ToDecimal(Console.ReadLine());
					Console.WriteLine("Grir Nshany ` +,-,*,/:");
					var symbol = Console.ReadLine();
					{
						if (symbol == "+")
						{
							decimal sum = firstNumber + secondNumber;
							Console.WriteLine($"Patasxan` {firstNumber} {symbol} {secondNumber} = {sum} : ");
						}

						if (symbol == "-")
						{
							decimal sum = firstNumber - secondNumber;
							Console.WriteLine($"Patasxan` {firstNumber} {symbol} {secondNumber} = {sum} : ");
						}
						if (symbol == "*")
						{
							decimal sum = firstNumber * secondNumber;
							Console.WriteLine($"Patasxan` {firstNumber} {symbol} {secondNumber} = {sum} : ");
						}
						if (symbol == "/")
						{
							decimal sum = firstNumber / secondNumber;
							Console.WriteLine($"Patasxan` {firstNumber} {symbol} {secondNumber} = {sum} : ");
						}
						if (symbol == "%")
						{
							decimal sum = firstNumber % secondNumber;
							Console.WriteLine($"Patasxan` {firstNumber} {symbol} {secondNumber} = {sum} : ");
						}
						Console.WriteLine("Noric Sexmir ENTER skselu hamar");



					}

				}


				else
				{
					Console.WriteLine("Press ENTER:");
					Console.ReadKey();
					Console.WriteLine("Type First Number:");
					decimal firstNumber = Convert.ToDecimal(Console.ReadLine());
					Console.WriteLine("Type Second Number:");
					decimal secondNumber = Convert.ToDecimal(Console.ReadLine());
					Console.WriteLine("Type Symbol ` +,-,*,/,%");
					var symbol = Console.ReadLine();
					{
						if (symbol == "+")
						{
							decimal sum = firstNumber + secondNumber;
							Console.WriteLine($"Answer` {firstNumber} {symbol} {secondNumber} = {sum} : ");
						}

						if (symbol == "-")
						{
							decimal sum = firstNumber - secondNumber;
							Console.WriteLine($"Answer` {firstNumber} {symbol} {secondNumber} = {sum} : ");
						}
						if (symbol == "*")
						{
							decimal sum = firstNumber * secondNumber;
							Console.WriteLine($"Answer` {firstNumber} {symbol} {secondNumber} = {sum} : ");
						}
						if (symbol == "/")
						{
							decimal sum = firstNumber / secondNumber;
							Console.WriteLine($"Answer` {firstNumber} {symbol} {secondNumber} = {sum} : ");
						}
						if (symbol == "%")
						{
							decimal sum = firstNumber % secondNumber;
							Console.WriteLine($"Patasxan` {firstNumber} {symbol} {secondNumber} = {sum} : ");
						}
						Console.WriteLine("Again Press ENTER for Start it again");
					}
				}

				Console.ReadKey();
			}


		}

	}
}




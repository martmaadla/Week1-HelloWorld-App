using System;

namespace HelloWord
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Kes sa oled, mis on sinu nimi?");
			string Username;
			Username = Console.ReadLine();

			Console.WriteLine("Tere, "  + Username);

			Console.Read();
		}
	}
}
Märt
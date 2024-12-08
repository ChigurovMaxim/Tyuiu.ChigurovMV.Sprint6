using System.IO;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string resStr = "";

			using (StreamReader sr = new StreamReader(@"C:\DataSprint6\InPutDataFileTask6V20.txt"))
			{
				string line;
				do
				{
					line = sr.ReadLine();
					string[] strings = line.Trim().Split(' ');
					foreach (string s in strings)
					{

					}
					Console.Write(line + " ");
					Console.Write(strings.Length);
					Console.WriteLine();
				}
				while (sr.EndOfStream == false);
			}
		}
	}
}

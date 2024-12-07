﻿using System.IO;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string path = @"C:\DataSprint6\InPutDataFileTask7V24.csv";
			int rows = File.ReadLines(path).Count();
			string[] strings = File.ReadAllText(path).Split("\n");
			int columns = strings[0].Split(';').Length;
			int[,] matrix = new int[rows, columns];

			using (StreamReader stream = new StreamReader(path))
			{
				string line;
				int count = 0;
				while ((line = stream.ReadLine()) != null)
				{
					string[] row = line.Split(';');
					for (int i = 0; i < columns; i++)
					{
						matrix[count, i] = Convert.ToInt32(row[i]);
					}
					count++;
				}
			}

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					Console.Write(matrix[i, j] + "\t");
				}
				Console.WriteLine();
			}

		}
	}
}

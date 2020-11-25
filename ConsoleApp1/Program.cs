using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Common;


namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int x;
			int y;
			Console.WriteLine("Введите Х");
			x = int.Parse(Console.ReadLine());
			FigureLogic figureLogic = new FigureLogic();
			List<Function> figura = FigureLogic.input();
			for (int i = 0; i < figura.Count; i++)
			{
				Console.WriteLine(figura[i].Show());
				figura[i].Func(x);
				Console.WriteLine("y = {0}", figura[i].y);
			}
		
		}
	}
}

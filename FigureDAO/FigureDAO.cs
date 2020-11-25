using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DAL
{
    public class FigureDAO : IFigureDAO
    {

		public List<Function> input()
		{
			using (StreamReader input = new StreamReader("input.txt"))
			{
				char[] splits = { '\n', ' ', '\t' };
				List<Function> func = new List<Function>();
				while (!input.EndOfStream)
				{
					string[] tmp = input.ReadLine().Split(splits, StringSplitOptions.RemoveEmptyEntries);
					if (tmp.Length == 4)
					{
						func.Add(new Kub(int.Parse(tmp[0]), int.Parse(tmp[1]), int.Parse(tmp[2])));
					}
					else if(tmp.Length == 3)
					{
						if (tmp[3] == "Line")
						{
							func.Add(new Line(int.Parse(tmp[0]), int.Parse(tmp[1])));
						}
						if (tmp[3] == "Hyperbola")
						{
							func.Add(new Hyperbola(int.Parse(tmp[0]), int.Parse(tmp[1])));
						}
					}
				}
				return func;
			}
		}



	}
}

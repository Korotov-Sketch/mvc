using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
	public class Kub : Function
	{
		public Kub(int a, int b, int c)
					: base(a, b)
		{
			this.c = c;
		}
        public override void Show()
        {
            Console.Write("Куб a={0},b={1},c={2} y = a * x * x + b * x + c;", a,b,c);
        }

        public int c;

		public override void Func(int x)
		{
			y = a * x * x + b * x + c;
		}
	}
}

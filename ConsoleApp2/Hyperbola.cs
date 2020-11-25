using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
	public class Hyperbola : Function
	{
		public Hyperbola(int a, int b)
			:base(a,b)
		{
			this.a = a;
			this.b = b;
		}
		
		public override void Show()
        {
            Console.Write("Гипербола a={0},b={1} y = (a / x) + b;", a,b);
        }
		
		public override void Func(int x)
		{
			y = (a / x) + b;
		}
	}
}

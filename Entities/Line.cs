using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
	public class Line : Function
	{
		public Line(int a, int b)
				:base(a, b)
		{
			this.a = a;
			this.b = b;
		}
        public override string Show()
        {
			return $"Линия a={a},b={b} y = a * x + b";
        }

        public override void Func(int x)
		{
			y = a * x + b;
		}
	}
}

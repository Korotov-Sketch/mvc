using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common

{
	public class Kub : Function
	{
		public Kub(int a, int b, int c)
					: base(a, b)
		{
			this.c = c;
		}
        public override string Show()
        {
			return $"Куб a={a},b={b},c={c} y = a * x * x + b * x + c";
        }

        public int c;

		public override void Func(int x)
		{
			y = a * x * x + b * x + c;
		}
	}
}

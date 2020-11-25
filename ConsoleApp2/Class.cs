using System;

namespace MyProgram
{
	abstract public class Function : IComparable
	{
		public int a;
		public int b;
		public double y;
		abstract public void Func(int x);
		public Function(int a, int b)
		{
			this.a = a;
			this.b = b;
		}
        abstract public void Show();
       
        public int CompareTo(object obj)
		{
			Function b = (Function)obj;
			if (this.a>b.a) {
				return 1;
			}
			else {
				if (this.a== b.a)
				{
					return 0;
				}

				else
				{
					return -1;
				}

			}
		}
	}
}
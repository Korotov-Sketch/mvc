using System;

namespace Common

{
	abstract public class Function 
	{
		public int a;
		public int b;
		public int c;
		public double y;
		abstract public void Func(int x);
		public Function(int a, int b)
		{
			this.a = a;
			this.b = b;
		}
		public Function(int a, int b, int c)
		{
			this.a = a;
			this.b = b;
			this.c = c;
		}
		abstract public string Show();
       
        
	}
}
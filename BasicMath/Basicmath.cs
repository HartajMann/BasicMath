using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMath
{
	public class Basicmath:Math
	{
		public virtual double add(double x, double y)
		{
			return x + y;
		}

		public virtual double subtract(double x, double y)
		{
			return x - y;
		}
		public virtual double multiply(double x, double y)
		{
			return x * y;
		}
		public virtual double divide(double x, double y)
		{
			if (y == 0)
			{
				throw new ArithmeticException("Cant divide by zero");
			}
			return x / y;
		}
	}
}

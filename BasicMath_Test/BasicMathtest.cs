using BasicMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMath_Test
{
	public class BasicMathtest
	{
		private double x;
		private double y;
		private BasicMath.Math math;

		[SetUp]
		public void SetUp()
		{
			x = 49.67;
			y = 35.67;
			math = new Basicmath();
		}
		[Test]
		public void Test_AddMethod() {
			double expected = 85.34;
			double actual = math.add(x, y);
			Assert.AreEqual(expected, actual, 0.001, "Addition Failed");
		}
		[Test]
		public void Test_SubMethod()
		{
			double expected = 14;
			double actual = math.subtract(x, y);
			Assert.AreEqual(expected, actual, 0.001, "Subtraction Failed");
		}
		[Test]
		public void Test_MultiMethod()
		{
			double expected = 1771.728;
			double actual = math.multiply(x, y);
			Assert.AreEqual(expected, actual, 0.001, "Multiplication Failed");
		}
		[Test]
		public void Test_DivideMethod()
		{
			double expected = 1.3924;
			double actual = math.divide(x, y);
			Assert.AreEqual(expected, actual, 0.001, "Divide Failed");
		}
	}
}

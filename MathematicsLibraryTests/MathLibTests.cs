
using MathematicsLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsLibrary.Tests {

	[TestClass()]
	public class MathLibTests {

		MathLib mathlib;
		double errorFactor;

		[TestInitialize]
		public void Initialization() {
			mathlib = new MathLib();
			errorFactor = 0.0000001;
		}

		[TestMethod()]
		public void AddTest() {
			Assert.AreEqual(4.5, mathlib.Add(1.5, 3.0), errorFactor);
			Assert.AreEqual(9, mathlib.Add(4.5, 4.5), errorFactor);
			Assert.AreEqual(1.4, mathlib.Add(2.7, -1.3), errorFactor);
		}

		[TestMethod()]
		public void SubtractTest() {
			Assert.AreEqual(4.2, mathlib.Subtract(7.4, 3.2), errorFactor);
			Assert.AreEqual(-7.8, mathlib.Subtract(-9.3, -1.5), errorFactor);
			Assert.AreEqual(23.8, mathlib.Subtract(20.1, -3.7), errorFactor);
		}

		[TestMethod()]
		public void MultiplyTest() {
			Assert.AreEqual(2.76, mathlib.Multiply(1.2, 2.3), errorFactor, "1.2*2.3");
			Assert.AreEqual(-35.9784, mathlib.Multiply(4.56, -7.89), errorFactor, "4.56*-7.89");
			Assert.AreEqual(83.810205, mathlib.Multiply(-12.345, -6.789), errorFactor, "-12.345*-6.789");
		}

		[TestMethod()]
		public void DivideTest() {
			Assert.AreEqual(2, mathlib.Divide(4.0, 2.0), errorFactor);
		}

		[TestMethod()]
		public void SquareTest() {
			Assert.AreEqual(16, mathlib.Square(4), errorFactor);
		}

		[TestMethod()]
		public void InverseTest() {
			Assert.AreEqual(4, mathlib.Inverse(0.25), errorFactor);
		}

		[TestMethod()]
		public void NegateTest() {
			Assert.AreEqual(6, mathlib.Negate(-6), errorFactor);
		}
	}
}
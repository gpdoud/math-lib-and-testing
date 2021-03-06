﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsLibrary {

	public class MathLib {

		public double Add(double a, double b) {
			return a + b;
		}
		public double Subtract(double a, double b) {
			return a - b;
		}
		public double Multiply(double a, double b) {
			return a * b;
		}
		public double Divide(double a, double b) {
			return a / b;
		}
		public double Square(double a) {
			return Multiply(a, a);
		}
		public double Inverse(double a) {
			return Divide(1, a);
		}
		public double Negate(double a) {
			return Multiply(a, -1);
		}
	}
}

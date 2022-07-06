using System;

namespace AreaLibrary {
	public class Area {//фигуры или другие методы вычисления площади можно добавить методами расширения

		public static bool IsRectangular(double a, double b, double c) {
			double max = Math.Max(Math.Max(a, b), c);
			if (max * max * 2 == a * a + b * b + c * c) {
				return true;
			}
			else {
				return false;
			}
		}

		public static double TriangleByThreeSides(double a, double b, double c) {
			if (IsRectangular(a, b, c)) {
				return Math.Min(Math.Min(a, b), c) * (a + b + c - Math.Min(Math.Min(a, b), c) - Math.Max(Math.Max(a, b), c)) / 2;
			}
			else {
				double p = (a + b + c) / 2;
				return Math.Sqrt(p*(p - a)*(p - b)*(p-c));
			}
		}

		public static double Circle(double r) {
			return Math.PI * r * r;
		}
	}
}

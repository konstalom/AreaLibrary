using NUnit.Framework;
using System;
using AreaLibrary;

namespace AreaLibraryTests {
	public class Tests {
		[SetUp]
		public void Setup() {
		}

		[Test]
		public void IsRectangularTrueTest() {
			int x = 3;
			int y = 4;
			int z = 5;
			bool expected = true;

			bool actual = Area.IsRectangular(x, y, z);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void IsRectangularFalseTest() {
			int x = 5;
			int y = 7;
			int z = 10;
			bool expected = false;

			bool actual = Area.IsRectangular(x, y, z);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void RectangularTriangleTest() {
			int x = 3;
			int y = 4;
			int z = 5;
			double expected = 6;

			double actual = Area.TriangleByThreeSides(x, y, z);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void NotRectangularTriangleTest() {
			int x = 2;
			int y = 3;
			int z = 4;
			double expected = 2.9047375096555625;

			double actual = Area.TriangleByThreeSides(x, y, z);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void CircleTest() {
			int r = 1;
			double expected = Math.PI;

			double actual = Area.Circle(r);

			Assert.AreEqual(expected, actual);
		}
	}
}
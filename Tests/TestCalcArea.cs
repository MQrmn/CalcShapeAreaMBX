namespace Tests
{
    [TestClass]
    public class TestAreaCalc
    {
        [TestMethod]
        public void CalcCircle()
        {
            var radius = 3;
            var expectedArea = 28.27433f;

            var shapeAreaCalculator = new ShapeAreaCalculator();
            var actualArea = shapeAreaCalculator.CalcArea(radius);

            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }

        [TestMethod]
        public void CalcTriangle()
        {
            var side1 = 3;
            var side2 = 3;
            var side3 = 3;

            var shapeAreaCalculator = new ShapeAreaCalculator();

            var expectedArea = 3.89711f;
            var actualArea = shapeAreaCalculator.CalcArea(side1, side2, side3);

            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }

        [TestMethod]
        public void CheckIsRectangular()
        {
            var side1 = 3;
            var side2 = 5;
            var side3 = 4;

            var shapeAreaCalculator = new ShapeAreaCalculator();
            var actualArea = shapeAreaCalculator.IsRectangularTriangle(side1, side2, side3);

            Assert.IsTrue(actualArea);
        }
    }
}
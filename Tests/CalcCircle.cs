namespace Tests
{
    [TestClass]
    public class CalcCircle
    {
        [TestMethod]
        public void RunCalcCircleTest()
        {
            var radius = 3;
            var expectedArea = 28.274334f;

            var shapeAreaCalculator = new ShapeAreaCalculator();
            var actualArea = shapeAreaCalculator.CalcArea(radius);

            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}
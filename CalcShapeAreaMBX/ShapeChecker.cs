namespace CalcShapeAreaMBX
{
    public class ShapeChecker
    {
        public bool IsRectangularTriangle(float side1, float side2, float side3)
        {
            var sideLenghts = new List<float>() { side1, side2, side3 };
            return IsRectangularTriangle(sideLenghts);
        }

        public bool IsRectangularTriangle(List<float> sideLenghts)
        {
            Triangle triangle = new Triangle(sideLenghts);
            return triangle.IsRectangular();
        }
    }
}

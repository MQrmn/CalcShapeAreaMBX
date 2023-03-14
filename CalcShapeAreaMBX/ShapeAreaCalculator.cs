namespace CalcShapeAreaMBX
{
    public class ShapeAreaCalculator
    {

        public float CalcArea(float radius)
        {
            var fabric = new CircleFabric();
            var circle = fabric.Create(radius);
            return circle.GetArea();
        }

        public float CalcArea(float side1, float side2, float side3)
        {
            var sideLenghts = new List<float>() { side1, side2, side3 };
            return CalcArea(sideLenghts);
        }

        public float CalcArea(List<float> sideLenghts)
        {
            var fabric = new PoligonFabric();
            var shape = fabric.GetShape(sideLenghts);
            return shape.GetArea();
        }
    }
}
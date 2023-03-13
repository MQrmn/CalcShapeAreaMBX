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

        public float CalcArea(float[] sideLenghts, float[] corners)
        {
            var fabric = new PoligonFabric();
            var shape = fabric.GetShape(sideLenghts, corners);
            return shape.GetArea();
        }
    }
}
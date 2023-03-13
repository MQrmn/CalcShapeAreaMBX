namespace CalcShapeAreaMBX
{
    internal class CircleFabric : ShapeFabric
    {
        internal Shape Create(float radius)
        {
            return new Circle(radius);
        }
    }
}

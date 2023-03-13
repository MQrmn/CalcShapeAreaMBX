namespace CalcShapeAreaMBX
{
    internal class CircleFabric
    {
        internal Shape Create(float radius)
        {
            return new Circle(radius);
        }
    }
}

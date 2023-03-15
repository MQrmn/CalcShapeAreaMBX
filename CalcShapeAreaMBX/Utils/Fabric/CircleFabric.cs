namespace CalcShapeAreaMBX
{
    internal class CircleFabric
    {
        internal Shape Create(float radius)
        {
            CheckForPositive(radius);
            return new Circle(radius);
        }

        private void CheckForPositive(float radius)
        {
            if (radius < 0) throw new ArgumentException("The number is negative");
        }
    }
}

namespace CalcShapeAreaMBX
{
    internal class Triangle : Polygon
    {
        public Triangle(float[] sideLenghts, float[] corners) : base(sideLenghts, corners)
        {
        }

        public override float GetArea()
        {
            throw new NotImplementedException();
        }
    }
}

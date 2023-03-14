namespace CalcShapeAreaMBX
{
    internal class Square : Polygon
    {
        public Square(float[] sideLenghts, float[] corners) : base(sideLenghts, corners)
        {
        }

        public override float GetArea()
        {
            throw new NotImplementedException();
        }
    }
}

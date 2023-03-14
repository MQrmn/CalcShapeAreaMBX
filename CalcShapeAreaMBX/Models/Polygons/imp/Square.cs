namespace CalcShapeAreaMBX
{
    internal class Square : Polygon
    {
        public Square(List<float> sideLenghts) : base(sideLenghts)
        {
        }

        internal override float GetArea()
        {
            throw new NotImplementedException();
        }
    }
}

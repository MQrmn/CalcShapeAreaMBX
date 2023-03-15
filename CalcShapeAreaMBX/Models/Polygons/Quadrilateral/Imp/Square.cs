namespace CalcShapeAreaMBX
{
    internal class Square : Quadrilateral
    {
        public Square(List<float> sideLenghts, List<float> angles) : base(sideLenghts, angles)
        {
            _sideLenghts = sideLenghts;
            _angles = angles;
        }

        internal override float GetArea()
        {
            return (float)Math.Pow(_sideLenghts.First(), 2);
        }
    }
}

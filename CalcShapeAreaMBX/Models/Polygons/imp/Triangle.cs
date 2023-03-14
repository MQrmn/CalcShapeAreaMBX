namespace CalcShapeAreaMBX
{
    internal class Triangle : Polygon
    {
        internal Triangle(List<float> sideLenghts) : base(sideLenghts)
        {
        }

        internal override float GetArea()
        {
            var halfPerimeter = _sideLenghts.Sum() * 0.5;

            var area = (float)Math.Sqrt( halfPerimeter
                                        * (halfPerimeter - _sideLenghts[0])
                                        * (halfPerimeter - _sideLenghts[1])
                                        * (halfPerimeter - _sideLenghts[2])
                                        );

            return area;
        }

        internal bool IsRectangular()
        {
            return false;
        }
    }
}

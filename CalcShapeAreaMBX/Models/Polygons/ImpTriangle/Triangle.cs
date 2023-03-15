namespace CalcShapeAreaMBX
{
    internal class Triangle : Polygon
    {
        internal Triangle(List<float> sideLenghts)
        {
            _sideLenghts = sideLenghts;
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
            var hypotenuseSide = _sideLenghts.Max();
            var legSides = (from s in _sideLenghts where s != hypotenuseSide select s).ToList();

            if (legSides.Count() != 2) return false;

            return Math.Pow(hypotenuseSide, 2) == Math.Pow(legSides[0], 2) + Math.Pow(legSides[1], 2);

        }
    }
}

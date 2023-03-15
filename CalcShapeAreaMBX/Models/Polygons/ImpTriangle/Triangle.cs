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
            var maxSideIndex = _sideLenghts.Max();
            _sideLenghts.Remove(maxSideIndex);

            var isRectangular = Math.Pow(maxSideIndex, 2) == Math.Pow(_sideLenghts[0], 2) + Math.Pow(_sideLenghts[1], 2);

            return isRectangular;
        }
    }
}

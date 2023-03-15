namespace CalcShapeAreaMBX
{
    internal abstract class Quadrilateral : Polygon
    {
        private protected List<float> _angles;

        public Quadrilateral(List<float> sideLenghts, List<float> angles)
        {
            _sideLenghts = sideLenghts;
            _angles = angles;
        }
    }
}

namespace CalcShapeAreaMBX
{
    internal abstract class Polygon : Shape
    {
        private protected List<float> _sideLenghts;
        internal Polygon(List<float> sideLenghts)
        {
            _sideLenghts = sideLenghts;
        }
    }
}
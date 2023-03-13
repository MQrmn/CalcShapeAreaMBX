namespace CalcShapeAreaMBX
{
    internal abstract class Polygon : Shape
    {
        private float[] _sideLenghts;
        private float[] _corners;
        public Polygon(float[] sideLenghts, float[] corners)
        {
            _sideLenghts = sideLenghts;
            _corners = corners;
        }
    }
}

namespace CalcShapeAreaMBX
{
    internal class PoligonFabric
    {
        internal Shape GetShape(float[] sideLenghts, float[] corners)
        {
            var sidesCount = sideLenghts.Length;
            var cornersCount = corners.Length;

            if (sidesCount != cornersCount)
                throw new Exception();
            else if (sidesCount < 3)
                throw new Exception();
            else
                return CreateShape(sidesCount, sideLenghts, corners);
        }

        private Shape CreateShape(int sidesCount, float[] sideLenghts, float[] corners)
        {
            if (sidesCount > 4)
                throw new Exception();
            if (sidesCount == 4)
                throw new Exception();
            else
                return new Triangle(sideLenghts, corners);
        }
    }
}

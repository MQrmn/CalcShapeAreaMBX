namespace CalcShapeAreaMBX
{
    internal class PoligonFabric
    {
        internal Shape GetShape(float[] sideLenghts, float[] corners)
        {
            var sidesCount = sideLenghts.Length;
            var cornersCount = corners.Length;

            CheckParamsCount(sidesCount, cornersCount);
            CheckByPositive(sideLenghts);
            CheckByPositive(corners);

            return CreateShape(sidesCount, sideLenghts, corners);
        }

        private Shape CreateShape(int sidesCount, float[] sideLenghts, float[] corners)
        {
            if (sidesCount == 4)
                throw new Exception();
            else
                return new Triangle(sideLenghts, corners);
        }

        private void CheckParamsCount(int sidesCount, int cornersCount)
        {
            if (sidesCount != cornersCount)
                throw new Exception();
            if (sidesCount < 3)
                throw new Exception();
            if (sidesCount > 4)
                throw new Exception();
        }

        private void CheckByPositive(float[] floats)
        {
            foreach(var s in floats) 
            {
                if (s < 0) throw new Exception();
            }
        }
    }
}

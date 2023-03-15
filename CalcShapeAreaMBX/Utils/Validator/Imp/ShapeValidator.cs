namespace CalcShapeAreaMBX
{
    internal class ShapeValidator
    {
        internal void CheckShape(float radius)
        {
            CheckForPositive(new List<float> { radius });
        }

        // Checking without taking angle parameters
        internal void CheckShape(List<float> sideLenghts)
        {
            var sidesCount = sideLenghts.Count;
            CheckArrLen(sidesCount);
            CheckForPositive(sideLenghts);
        }

        // Checking with taking angle parameters
        internal void CheckShape(List<float> sideLenghts, List<float> angles)
        {
            var sidesCount = sideLenghts.Count;
            var anglesCount = angles.Count;

            if (sidesCount == anglesCount)
                CheckArrLen(sidesCount);
            else
                throw new ArgumentException("The number of sides does not match the number of angles");

            CheckForPositive(sideLenghts);
            CheckForPositive(angles);
        }

        // Checking size of arrays
        private void CheckArrLen(int sidesCount)
        {
            if (sidesCount < 3)
                throw new ArgumentException("The number of sides is less than 3");
            if (sidesCount > 4)
                throw new ArgumentException("Number of sides greater than 4");
        }

        // Checking values for positivity
        private void CheckForPositive(List<float> floats)
        {
            foreach (var s in floats)
            {
                if (s < 0) throw new ArgumentException("The number is negative");
            }
        }
    }
}

namespace CalcShapeAreaMBX
{
    internal class ShapeValidator : IShapeValidator
    {
        // Checking one float
        public void ValidateShape(float radius)
        {
            CheckForPositive(new List<float> { radius });
        }

        // Checking without taking angle parameters
        public void ValidateShape(List<float> sideLenghts)
        {
            var sidesCount = sideLenghts.Count;
            ValidateArrLen(sidesCount);
            CheckForPositive(sideLenghts);
        }

        // Checking with taking angle parameters
        public void ValidateShape(List<float> sideLenghts, List<float> angles)
        {
            var sidesCount = sideLenghts.Count;
            var anglesCount = angles.Count;

            if (sidesCount == anglesCount) ValidateArrLen(sidesCount);
            else throw new CalcShapeAreaException("The number of sides does not match the number of angles");

            CheckForPositive(sideLenghts);
            CheckForPositive(angles);
        }

        // Checking size of arrays
        private void ValidateArrLen(int sidesCount)
        {
            if (sidesCount < 3) throw new CalcShapeAreaException("The number of sides is less than 3");
            if (sidesCount > 4) throw new CalcShapeAreaException("Number of sides greater than 4");
        }

        // Checking values for positivity
        private void CheckForPositive(List<float> floats)
        {
            foreach (var s in floats)
            {
                if (s < 0) throw new CalcShapeAreaException("The number is negative");
            }
        }
    }
}

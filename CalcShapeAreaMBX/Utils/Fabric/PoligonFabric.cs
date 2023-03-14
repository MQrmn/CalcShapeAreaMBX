namespace CalcShapeAreaMBX
{
    internal class PoligonFabric
    {
        enum ShapeTypes
        {
            Triangle,
            Square
        }

        // Top level method included checking parameters, choosing, creating shape
        internal Shape GetShape(float[] sideLenghts, float[] corners)
        {
            var sidesCount = sideLenghts.Length;
            var cornersCount = corners.Length;

            CheckParamsCount(sidesCount, cornersCount);
            CheckForPositive(sideLenghts);
            CheckForPositive(corners);

            var shapeType = ChooseShape(sidesCount, sideLenghts, corners);

            return CreateShape(shapeType, sideLenghts, corners);
        }

        // Creating shape by passed shape type
        private Shape CreateShape(ShapeTypes type, float[] sideLenghts, float[] corners)
        {
            return type switch
            {
                ShapeTypes.Square => new Square(sideLenghts, corners),
                _ => new Triangle(sideLenghts, corners)
            };
        }

        // Choosing shape type
        private ShapeTypes ChooseShape(int sidesCount, float[] sideLenghts, float[] corners)
        {
            if (sidesCount == 4)
                throw new Exception();
            else
                return ShapeTypes.Triangle;
        }

        // Checking size of arrays
        private void CheckParamsCount(int sidesCount, int cornersCount)
        {
            if (sidesCount != cornersCount)
                throw new Exception();
            if (sidesCount < 3)
                throw new Exception();
            if (sidesCount > 4)
                throw new Exception();
        }

        // Checking values for positivity
        private void CheckForPositive(float[] floats)
        {
            foreach(var s in floats) 
            {
                if (s < 0) throw new Exception();
            }
        }
    }
}

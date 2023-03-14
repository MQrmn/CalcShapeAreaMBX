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
        internal Shape GetShape(List<float> sideLenghts)
        {
            var sidesCount = sideLenghts.Count;

            CheckArrLen(sidesCount);
            CheckForPositive(sideLenghts);

            var shapeType = ChooseShape(sidesCount, sideLenghts);

            return CreateShape(shapeType, sideLenghts);
        }

        // Choosing shape type
        private ShapeTypes ChooseShape(int sidesCount, List<float> sideLenghts)
        {
            return sidesCount switch
            {
                4 => ChooseQuadrilateral(sideLenghts),
                _ => ShapeTypes.Triangle
            };
        }

        // Creating shape by passed shape type
        private Shape CreateShape(ShapeTypes type, List<float> sideLenghts)
        {
            return type switch
            {
                ShapeTypes.Square => new Square(sideLenghts),
                _ => new Triangle(sideLenghts)
            };
        }

        private ShapeTypes ChooseQuadrilateral(List<float> sideLenghts)
        {
            return ShapeTypes.Square;
        }

        // Checking size of arrays
        private void CheckArrLen(int sidesCount)
        {
            if (sidesCount < 3)
                throw new Exception();
            if (sidesCount > 4)
                throw new Exception();
        }

        // Checking values for positivity
        private void CheckForPositive(List<float> floats)
        {
            foreach(var s in floats) 
            {
                if (s < 0) throw new Exception();
            }
        }
    }
}

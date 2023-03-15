namespace CalcShapeAreaMBX
{
    internal class ShapeFabric
    {
        enum ShapeTypes
        {
            Undefined,
            Triangle,
            Square
        }

        internal Shape GetShape(float radius)
        {
            CheckForPositive(new List<float> { radius });
            return new Circle(radius);
        }

        // Returns figures without taking angle parameters
        internal Shape GetShape(List<float> sideLenghts)
        {
            var sidesCount = sideLenghts.Count;
            CheckArrLen(sidesCount);
            CheckForPositive(sideLenghts);

            var shapeType = SelectShape(sidesCount, sideLenghts);
            if (shapeType == ShapeTypes.Undefined)
                throw new ArgumentException("Shape type is undefined");

            return CreateShape(shapeType, sideLenghts);
        }

        // Returns figures with taking angle parameters
        internal Shape GetShape(List<float> sideLenghts, List<float> angles)
        {
            var sidesCount = sideLenghts.Count;
            var anglesCount = angles.Count;

            if (sidesCount == anglesCount)
                CheckArrLen(sidesCount);
            else
                throw new ArgumentException("The number of sides does not match the number of angles");

            CheckForPositive(sideLenghts);
            CheckForPositive(angles);

            var shapeType = SelectShape(sidesCount, sideLenghts, angles);

            if (shapeType == ShapeTypes.Undefined)
                throw new ArgumentException("Shape type is undefined");

            return CreateShape(shapeType, sideLenghts);
        }

        // Choosing shape type
        private ShapeTypes SelectShape(int sidesCount, List<float> sideLenghts, List<float> angles = null)
        {
            return sidesCount switch
            {
                4 => SelectQuadrilateral(sideLenghts, angles),
                3 => ShapeTypes.Triangle,
                _ => ShapeTypes.Undefined
            };
        }

        // Creating shape by passed shape type
        private Shape CreateShape(ShapeTypes type, List<float> sideLenghts, List<float> angles = null)
        {
            return type switch
            {
                ShapeTypes.Square => new Square(sideLenghts),
                _ => new Triangle(sideLenghts)
            };
        }

        // Chosing a quadrilateral shape 
        private ShapeTypes SelectQuadrilateral(List<float> sideLenghts, List<float> angles)
        {
            var selector = new ShapeSelector();
            var type = selector.GetShapeType(sideLenghts, angles);

            return type switch
            {
                1 => ShapeTypes.Square,
                _ => ShapeTypes.Undefined
            };
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
            foreach(var s in floats) 
            {
                if (s < 0) throw new ArgumentException("The number is negative");
            }
        }
    }
}

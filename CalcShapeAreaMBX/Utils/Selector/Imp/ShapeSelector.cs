namespace CalcShapeAreaMBX
{
    internal class ShapeSelector : IShapeSelector
    {
        internal enum ShapeTypes
        {
            Undefined,
            Circle,
            Triangle,
            Square
        }

        public ShapeTypes GetShapeType(float radius)
        {
            return ShapeTypes.Circle;
        }

        // Returns figures without taking angle parameters
        public ShapeTypes GetShapeType(List<float> sideLenghts)
        {
            var sidesCount = sideLenghts.Count;

            return SelectShape(sidesCount, sideLenghts);
        }

        // Returns figures with taking angle parameters
        public ShapeTypes GetShapeType(List<float> sideLenghts, List<float> angles)
        {
            var sidesCount = sideLenghts.Count;

            return SelectShape(sidesCount, sideLenghts, angles);
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

        // Chosing a quadrilateral shape 
        private ShapeTypes SelectQuadrilateral(List<float> sideLenghts, List<float> angles = null)
        {
            if (IsSquare(sideLenghts, angles)) return ShapeTypes.Square;
            
            return ShapeTypes.Undefined;
        }

        // Checking is sahpe a square
        private bool IsSquare(List<float> sideLenghts, List<float> angles)
        {
            var rightAngles = from a in angles where a == 90 select a;
            if (rightAngles.Count() < 4) return false;
            var maxSide = angles.Max();
            var identSides = from s in sideLenghts where s == maxSide select s;
            if (identSides.Count() < 4) return false;

            return true;
        }

    }
}

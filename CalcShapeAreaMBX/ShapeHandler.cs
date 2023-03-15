using System.ComponentModel.DataAnnotations;

namespace CalcShapeAreaMBX
{
    public class ShapeHandler
    {
        private IShapeValidator _validator = new ShapeValidator();
        private static IShapeSelector _selector = new ShapeSelector();
        private static ShapeFabric _fabric = new ShapeFabric(_selector);

        // Calc circle area
        public float CalcArea(float radius)
        {
            try
            {
                _validator.ValidateShape(radius);
                var circle = _fabric.GetShape(radius);
                return circle.GetArea();

            }
            catch (CalcShapeAreaException e)
            {
                Console.WriteLine(e.Message);
            }

            return 0;
        }

        // Calc triangle area
        public float CalcArea(float side1, float side2, float side3)
        {
            var sideLenghts = new List<float>() { side1, side2, side3 };
            return CalcArea(sideLenghts);
        }

        // Calc triangle area
        public float CalcArea(List<float> sideLenghts)
        {
            try
            {
                _validator.ValidateShape(sideLenghts);
                var shape = _fabric.GetShape(sideLenghts);
                return shape.GetArea();
            }
            catch (CalcShapeAreaException e)
            {
                Console.WriteLine(e.Message);
            }

            return 0;
        }

        // Calc same poligon area except triangle
        public float CalcArea(List<float> sideLenghts, List<float> angles)
        {
            try
            {
                _validator.ValidateShape(sideLenghts, angles);
                var shape = _fabric.GetShape(sideLenghts, angles);
                return shape.GetArea();
            }
            catch (CalcShapeAreaException e)
            {
                Console.WriteLine(e.Message);
            }

            return 0;
        }
        // Is triangle Rectangular
        public bool IsRectangularTriangle(float side1, float side2, float side3)
        {
            var sideLenghts = new List<float>() { side1, side2, side3 };
            return IsRectangularTriangle(sideLenghts);
        }
        // Is triangle Rectangular
        public bool IsRectangularTriangle(List<float> sideLenghts)
        {
            try
            {
                _validator.ValidateShape(sideLenghts);
                var triangle = new Triangle(sideLenghts);
                return triangle.IsRectangular();
            }
            catch (CalcShapeAreaException e)
            {
                Console.WriteLine(e.Message);
            }

            return false;
        }
    }
}
using System.ComponentModel.DataAnnotations;

namespace CalcShapeAreaMBX
{
    public class ShapeAreaCalculator
    {
        private IShapeValidator _validator = new ShapeValidator();
        private static IShapeSelector _selector = new ShapeSelector();
        private static ShapeFabric _fabric = new ShapeFabric(_selector);

        // Calc circle area
        public float CalcArea(float radius)
        {

            float area = 0f;
            try
            {
                _validator.ValidateShape(radius);
                var circle = _fabric.GetShape(radius);
                area = circle.GetArea();

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            return area;
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
            float area = 0f;

            try
            {
                _validator.ValidateShape(sideLenghts);
                var shape = _fabric.GetShape(sideLenghts);
                area = shape.GetArea();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            return area;
        }

        // Calc same poligon area except triangle
        public float CalcArea(List<float> sideLenghts, List<float> angles)
        {
            float area = 0f;

            //try
            //{
                _validator.ValidateShape(sideLenghts, angles);
                var shape = _fabric.GetShape(sideLenghts, angles);
                area = shape.GetArea();
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            return area;
        }
    }
}
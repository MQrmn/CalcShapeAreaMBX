using System.ComponentModel.DataAnnotations;

namespace CalcShapeAreaMBX
{
    public class ShapeHandler
    {
        private IShapeValidator _validator = new ShapeValidator();
        private static IShapeSelector _selector = new ShapeSelector();
        private static ShapeFabric _fabric = new ShapeFabric(_selector);

        /// <summary>
        /// Calculating the area of a circle
        /// <returns>float</returns>
        /// <param name="radius">float</param>
        /// </summary>
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

        /// <summary>
        /// Calculating the area of a triangle
        /// <returns>float</returns>
        /// <param name="side1">float</param>
        /// <param name="side2">float</param>
        /// <param name="side3">float</param>
        /// </summary>
        public float CalcArea(float side1, float side2, float side3)
        {
            var sideLenghts = new List<float>() { side1, side2, side3 };
            return CalcArea(sideLenghts);
        }

        /// <summary>
        /// Calculating the area of a triangle
        /// <returns>float</returns>
        /// <param name="sideLenghts">List<float></param>
        /// </summary>
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

        /// <summary>
        /// Calculation of the area of various figures except for a circle and a triangle
        /// <returns>float</returns>
        /// <param name="sideLenghts">List<float></param>
        /// <param name="angles">List<float></param>
        /// </summary>
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
        /// <summary>
        /// Checking if a triangle is a right triangle
        /// <returns>bool</returns>
        /// <param name="side1">float</param>
        /// <param name="side2">float</param>
        /// <param name="side3">float</param>
        /// </summary>
        public bool IsRectangularTriangle(float side1, float side2, float side3)
        {
            var sideLenghts = new List<float>() { side1, side2, side3 };
            return IsRectangularTriangle(sideLenghts);
        }
        /// <summary>
        /// Checking if a triangle is a right triangle
        /// <returns>bool</returns>
        /// <param name="sideLenghts">List<float></param>
        /// </summary>
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
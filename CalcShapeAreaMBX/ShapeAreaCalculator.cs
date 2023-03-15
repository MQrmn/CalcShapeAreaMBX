namespace CalcShapeAreaMBX
{
    public class ShapeAreaCalculator
    {

        public float CalcArea(float radius)
        {
            var fabric = new ShapeFabric();
            float area = 0f;
            try
            {
                var circle = fabric.GetShape(radius);
                area = circle.GetArea();

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            return area;
        }

        public float CalcArea(float side1, float side2, float side3)
        {
            var sideLenghts = new List<float>() { side1, side2, side3 };
            return CalcArea(sideLenghts);
        }

        public float CalcArea(List<float> sideLenghts)
        {
            float area = 0f;
            var fabric = new ShapeFabric();

            try
            {
                var shape = fabric.GetShape(sideLenghts);
                area = shape.GetArea();

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            return area;
        }
    }
}
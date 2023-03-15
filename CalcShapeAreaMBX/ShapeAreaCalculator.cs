namespace CalcShapeAreaMBX
{
    public class ShapeAreaCalculator
    {

        public float CalcArea(float radius)
        {
            var fabric = new CircleFabric();
            float area = 0f;
            try
            {
                var circle = fabric.Create(radius);
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
            var fabric = new PoligonFabric();

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
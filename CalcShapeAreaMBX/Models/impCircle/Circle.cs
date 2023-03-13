namespace CalcShapeAreaMBX
{
    internal class Circle : Shape
    {
        private float _radius;
        public Circle(float radius)
        {
            _radius = radius;
        }

        public override float GetArea()
        {
            return (float)(Math.PI * Math.Pow((double)_radius, 2));
        }
    }
}

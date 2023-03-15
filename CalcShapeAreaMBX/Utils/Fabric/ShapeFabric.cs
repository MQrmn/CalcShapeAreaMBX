namespace CalcShapeAreaMBX
{
    internal class ShapeFabric
    {
        private IShapeSelector _selector;
        public ShapeFabric(IShapeSelector? selector)
        {
            _selector = selector;
        }

        public Shape? GetShape(float radius)
        {
            var shapeType = _selector.GetShapeType(radius);

            return CreateShape(shapeType, new List<float> { radius });
        }

        public Shape? GetShape(List<float> sideLenghts)
        {
            var shapeType = _selector.GetShapeType(sideLenghts);

            return CreateShape(shapeType, sideLenghts);
        }

        public Shape? GetShape(List<float> sideLenghts, List<float> angles)
        {
            var shapeType = _selector.GetShapeType(sideLenghts);

            return CreateShape(shapeType, sideLenghts, angles);
        }



        private Shape? CreateShape(ShapeSelector.ShapeTypes shapeType, List<float> param1, object param2 = null)
        {
            return shapeType switch
            {
                ShapeSelector.ShapeTypes.Triangle => new Triangle(param1),
                ShapeSelector.ShapeTypes.Circle => new Circle(param1[0]),
                _ => null
            };
        }
    }
}

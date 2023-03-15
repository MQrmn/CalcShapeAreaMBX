using static CalcShapeAreaMBX.ShapeSelector;

namespace CalcShapeAreaMBX
{
    internal interface IShapeSelector
    {
        public ShapeTypes GetShapeType(float radius);
        public ShapeTypes GetShapeType(List<float> sideLenghts);
        public ShapeTypes GetShapeType(List<float> sideLenghts, List<float> angles);

    }
}

namespace CalcShapeAreaMBX
{
    internal interface IShapeValidator
    {
        public void ValidateShape(float radius);
        public void ValidateShape(List<float> sideLenghts);
        public void ValidateShape(List<float> sideLenghts, List<float> angles);
    }
}

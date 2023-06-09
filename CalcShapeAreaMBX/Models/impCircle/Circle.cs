﻿namespace CalcShapeAreaMBX
{
    internal class Circle : Shape
    {
        private float _radius;
        internal Circle(float radius)
        {
            _radius = radius;
        }

        internal override float GetArea()
        {
            return (float)(Math.PI * Math.Pow((double)_radius, 2));
        }
    }
}

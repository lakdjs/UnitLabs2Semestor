using System;

namespace InterfaceTetragonSystem
{
    public class Parallelogram : ITetragon
    {
        protected float SideA;
        protected float SideB;
        protected float Angle;
        public Parallelogram(float sideA, float sideB, float angle)
        {
            SideA = sideA;
            SideB = sideB;
            Angle = angle;
        }
        public float CountPerimeter()
        {
            return (SideA + SideB) * 2;
        }

        public float CountArea()
        {
            return SideA * SideB * (float)Math.Sin(Angle);
        }
    }
}
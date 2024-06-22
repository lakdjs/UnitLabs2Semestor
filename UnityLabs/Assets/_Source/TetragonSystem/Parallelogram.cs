using System;

namespace TetragonSystem
{
    public class Parallelogram : ATetragon
    {
        public Parallelogram(float sideA, float sideB, float angle) : base(sideA, sideB, angle)
        {
        }

        public override float CountPerimeter()
        {
            return (SideA + SideB) * 2;
        }

        public override float CountArea()
        {
            return SideA * SideB * (float)Math.Sin(Angle);//S = a * b * sin a
        }
    }
}
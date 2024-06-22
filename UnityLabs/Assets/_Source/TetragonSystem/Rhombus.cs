using System;

namespace TetragonSystem
{
    public class Rhombus : Parallelogram
    {
        public Rhombus(float sideA, float sideB, float angle) : base(sideA, sideB, angle)
        {
            SideA = sideA;
            SideB = sideA;
        }
        
    }
}
using UnityEngine;

namespace InterfaceTetragonSystem
{
    public class ConvexTetragon : ITetragon
    {
        protected float SideA;
        protected float SideB;
        protected float SideC;
        protected float SideD;
        protected float Angle;
        public ConvexTetragon(float sideA, float sideB, float sideC, float sideD, float angle)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            SideD = sideD;
            Angle = angle;
        }
        public float CountPerimeter()
        {
            return SideA + SideB + SideC + SideD;
        }

        public float CountArea()
        {
            float halfP = this.CountPerimeter() / 2;
            return Mathf.Sqrt(halfP*((halfP-SideA)*(halfP-SideB)*(halfP-SideC)*(halfP-SideD)));//formula Brahmagupti
        }
    }
}
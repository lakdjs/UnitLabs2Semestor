using System;
using UnityEngine;

namespace TetragonSystem
{
    public class ConvexTetragon : ATetragon
    {
        protected float SideC;
        protected float SideD;
        public ConvexTetragon(float sideA, float sideB, float sideC, float sideD, float angle) : base(sideA, sideB, angle)
        {
            SideC = sideC;
            SideD = sideD;
        }

        public override float CountPerimeter()
        {
            return SideA + SideB + SideC + SideD;
        }

        public override float CountArea()
        {
            float halfP = this.CountPerimeter() / 2;
            return Mathf.Sqrt(halfP*((halfP-SideA)*(halfP-SideB)*(halfP-SideC)*(halfP-SideD)));//formula Brahmagupti
        }
    }
}
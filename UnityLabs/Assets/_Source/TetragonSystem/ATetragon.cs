using System;
using UnityEngine;

namespace TetragonSystem
{
    public abstract class ATetragon
    {
        protected float SideA;
        protected float SideB;
        protected float Angle;
        public ATetragon(float sideA, float sideB, float angle)
        {
            SideA = sideA;
            SideB = sideB;
            Angle = angle;
        }

        public abstract float CountPerimeter();

        public abstract float CountArea();
    }
}

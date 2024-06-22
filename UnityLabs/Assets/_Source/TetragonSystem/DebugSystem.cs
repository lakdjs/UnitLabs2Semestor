using System;
using UnityEngine;

namespace TetragonSystem
{
    public class DebugSystem : MonoBehaviour
    {
        private ATetragon[] _tetragons =
        {
            new Square(10,10,90),
            new Rhombus(10,10,30),
            new Rectangle(10,9,90),
            new Parallelogram(10,8,45),
            new ConvexTetragon(10,9,8,7,30)
        };

        private void Awake()
        {
            foreach (ATetragon tetragon in _tetragons)
            {
                Debug.Log("Area"+ tetragon.CountArea());
                Debug.Log("Perimetr"+tetragon.CountPerimeter());
            }
            
        }
    }
}
namespace InterfaceTetragonSystem

{
    public class Rhombus : Parallelogram
    {
        public Rhombus(float sideA, float sideB, float angle) : base(sideA, sideB, angle)
        {
            SideB = sideA;
        }
    }
}
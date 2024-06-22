namespace InterfaceTetragonSystem
{
    public class Square : Parallelogram
    {
        public Square(float sideA, float sideB, float angle) : base(sideA, sideB, angle)
        {
            SideB = sideA;
            Angle = 90;
        }
    }
}
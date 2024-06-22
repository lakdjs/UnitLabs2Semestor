namespace InterfaceTetragonSystem

{
    public class Rectangle : Parallelogram
    {
        public Rectangle(float sideA, float sideB, float angle) : base(sideA, sideB, angle)
        {
            Angle = 90;
        }
    }
}
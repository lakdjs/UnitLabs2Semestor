namespace TetragonSystem
{
    public class Square : Parallelogram
    {
        public Square(float sideA, float sideB, float angle) : base(sideA, sideB, angle)
        {
            SideA = sideA;
            SideB = sideA;
            Angle = 90;
        }
        
    }
}
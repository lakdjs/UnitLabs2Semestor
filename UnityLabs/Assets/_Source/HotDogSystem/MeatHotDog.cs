namespace HotDogSystem
{
    public class MeatHotDog : ABaseHotDog
    {
        public MeatHotDog(string name, int weight, int cost) : base(name, weight)
        {
            _cost = cost;
        }

        public override int GetCost()
        {
            return _cost;
        }
    }
}
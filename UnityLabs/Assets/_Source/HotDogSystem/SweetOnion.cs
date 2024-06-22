namespace HotDogSystem
{
    public class SweetOnion : HotDogDecorator
    {
        public SweetOnion(string name, ABaseHotDog hotDog, int weight, int cost) : base(name, hotDog, weight)
        {
            _cost = cost;
        }

        public override int GetCost()
        {
            return HotDog.GetCost() + _cost;
        }
    }
}
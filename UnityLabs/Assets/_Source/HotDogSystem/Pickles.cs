namespace HotDogSystem
{
    public class Pickles : HotDogDecorator
    {
        public Pickles(string name, ABaseHotDog hotDog, int weight, int cost) : base(name, hotDog, weight)
        {
            _cost = cost;
        }
        public override int GetCost()
        {
            return HotDog.GetCost() + _cost;
        }
    }
}
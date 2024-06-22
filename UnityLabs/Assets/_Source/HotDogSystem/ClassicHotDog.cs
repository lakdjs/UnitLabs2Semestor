namespace HotDogSystem
{
    public class ClassicHotDog : ABaseHotDog
    {
        public ClassicHotDog(string name, int weight, int cost) : base(name, weight)
        {
            _cost = cost;
        }
        
        public override int GetCost()
        {
            return _cost;
        }
    }
}
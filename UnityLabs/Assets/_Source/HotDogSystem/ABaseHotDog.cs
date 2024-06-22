namespace HotDogSystem
{
    public abstract class ABaseHotDog
    {
        protected string _name;
        protected int _weight;
        protected int _cost;
        
        public ABaseHotDog(string name, int weight)
        {
            _name = name;
            _weight = weight;
        }
        
        public string GetName() => _name;
        public int GetWeight() => _weight;
        public abstract int GetCost();
    }
}
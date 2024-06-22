namespace HotDogSystem
{
    public class HotDogDecorator : ABaseHotDog
    {
        protected ABaseHotDog HotDog;
        public  HotDogDecorator(string name, ABaseHotDog hotDog, int weight) : base(name, weight)
        {
            HotDog = hotDog;
        }

        public override int GetCost()
        {
            return HotDog.GetCost();
        }
    }
}
using UnityEngine;

namespace HotDogSystem
{
    public class CesarHotDog : ABaseHotDog
    {
        public CesarHotDog(string name, int weight, int cost) : base(name, weight)
        {
            _cost = cost;
        }
        
        public override int GetCost()
        {
            return _cost;
        }
    }
}
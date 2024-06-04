using UnityEngine;

namespace PlayerSystem
{
    public class SwordAttackStrategy: IAttackStrategy
    {
        public void Attack()
        {
            Debug.Log("Sword");
        }
    }
}
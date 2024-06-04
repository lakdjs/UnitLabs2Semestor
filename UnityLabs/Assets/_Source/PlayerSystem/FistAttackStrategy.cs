using UnityEngine;

namespace PlayerSystem
{
    public class FistAttackStrategy: IAttackStrategy
    {
        public void Attack()
        {
            Debug.Log("Fist");
        }
    }
}
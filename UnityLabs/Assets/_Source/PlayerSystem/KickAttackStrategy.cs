using UnityEngine;

namespace PlayerSystem
{
    public class KickAttackStrategy: IAttackStrategy
    {
        public void Attack()
        {
            Debug.Log("Kick");
        }
    }
}
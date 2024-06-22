using UnityEngine;

namespace EnemySystem
{
    public abstract class ABaseEnemy: MonoBehaviour
    {
        public abstract Animator Animator { get; set; }
        protected abstract void CurEnemyAttack();
        public void Attack()
        {
            CurEnemyAttack();
        }
    }
}
using UnityEngine;

namespace EnemySystem
{
    public class MeleeEnemy: ABaseEnemy
    {
        [field: SerializeField] public override Animator Animator { get; set; }
        private void OnEnable()
        {
            Attack();
        }

        protected override void CurEnemyAttack()
        {
            Animator.SetTrigger("MeleeAttack");
            Debug.Log("Melee attacks");
        }
    }
}
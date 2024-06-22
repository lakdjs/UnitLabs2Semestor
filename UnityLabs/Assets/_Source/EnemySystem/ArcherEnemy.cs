using System;
using UnityEngine;
using PlayerSystem;

namespace EnemySystem
{
    public class ArcherEnemy: ABaseEnemy
    {
        [field: SerializeField] public override Animator Animator { get; set; }

        private void OnEnable()
        {
            SetAttack();
        }

        protected override void CurEnemyAttack()
        {
            Debug.Log("Archer attacks");
            Animator.SetTrigger("ArcherAttack");
        }

        private void SetAttack()
        {
            AttackPerformer.OnAttack += CurEnemyAttack;
        }
    }
}
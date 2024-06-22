using System;
using Unity.VisualScripting;

namespace PlayerSystem
{
    public class AttackPerformer
    {
        public static event Action OnAttack; 
        private IAttackStrategy _attackStrategy;

        public AttackPerformer(IAttackStrategy attackStrategy)
        {
            SetStrategy(attackStrategy);
        }

        public void SetStrategy(IAttackStrategy newStrategy)
        {
            _attackStrategy = newStrategy;
            PerformAttack();
        }

        public void PerformAttack()
        {
            _attackStrategy.Attack();
            OnAttack?.Invoke();
        }
    }
}
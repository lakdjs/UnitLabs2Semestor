using System;
using System.Collections;
using UnityEngine;

namespace EnemySystem
{
    public class ShooterEnemy : ABaseEnemy
    {
        [field: SerializeField] public override Animator Animator { get; set; }
        
        [SerializeField] private Transform firePoint;
        [SerializeField] private GameObject bullet;
        
        private ShootingSystem _shootingSystem;
        private bool _isReadyToAttack = false;
        public ShooterEnemy(ShootingSystem shootingSystem)
        {
            _shootingSystem = shootingSystem;
        }

        public void OnEnable()
        {
            _isReadyToAttack = true;
            CurEnemyAttack();
        }

        public void OnDisable()
        {
            _isReadyToAttack = false;
        }

        protected override void CurEnemyAttack()
        {
            if (_isReadyToAttack)
            {
                _shootingSystem.Shoot();
                Debug.Log("Shooter Attacks");
            }
        }
        IEnumerator Timer()
        {
            yield return new WaitForSeconds(1);
            CurEnemyAttack();
            StartCoroutine(Timer());
        }
    }
}
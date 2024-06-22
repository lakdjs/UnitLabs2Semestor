using System;
using EnemySystem;
using PlayerSystem;
using UnityEngine;
using UnityEngine.Serialization;
using Button = UnityEngine.UI.Button;

namespace Core
{
    public class Bootstrapper: MonoBehaviour
    {
        [SerializeField] private Button fistButton;
        [SerializeField] private Button swordButton;
        [SerializeField] private Button kickButton; 
        [SerializeField] private EnemyPool enemyPool;
        [SerializeField] private Transform spawnPoint;
        private AttackPerformer _attackPerformer;
        private IAttackStrategy _fistAttack;
        private IAttackStrategy _swordAttack;
        private IAttackStrategy _kickAttack;
        private EnemySetter _enemySetter;
        
        private void Awake()
        {
            SetUp();
        }

        private void SetUp()
        {
            enemyPool.Initialize();
            _enemySetter = new EnemySetter(enemyPool);
            fistButton.onClick.AddListener (() => _enemySetter.ChangeActiveEnemy(typeof(MeleeEnemy), spawnPoint));
            swordButton.onClick.AddListener (() => _enemySetter.ChangeActiveEnemy(typeof(ShooterEnemy), spawnPoint));
            kickButton.onClick.AddListener (() => _enemySetter.ChangeActiveEnemy(typeof(ArcherEnemy), spawnPoint));
            _fistAttack = new FistAttackStrategy();
            _swordAttack = new SwordAttackStrategy();
            _kickAttack = new KickAttackStrategy();
            _attackPerformer = new AttackPerformer(_fistAttack);
            fistButton.onClick.AddListener (() => _attackPerformer.SetStrategy(_fistAttack));
            swordButton.onClick.AddListener (() => _attackPerformer.SetStrategy(_swordAttack));
            kickButton.onClick.AddListener (() => _attackPerformer.SetStrategy(_kickAttack));
        }
    }
}
using System;
using UnityEngine;

namespace EnemySystem
{
    public class EnemySetter
    {
        private ABaseEnemy _currEnemy;
        private EnemyPool _enemyPool;
        private GameObject _activeEnemy;

        public EnemySetter(EnemyPool enemyPool)
        {
            _enemyPool = enemyPool;
            _activeEnemy = null;
        }
        public void ChangeActiveEnemy(Type newEnemy, Transform spawnPoint)
        {
            if (_activeEnemy != null)
            {
                _enemyPool.ReturnToPool(_activeEnemy);
            }
            if(_enemyPool.TryGetFromPool(out GameObject enemyInstance, newEnemy))
            {
                enemyInstance.transform.position = spawnPoint.position;
                _activeEnemy = enemyInstance;
            }
        }
    }
}
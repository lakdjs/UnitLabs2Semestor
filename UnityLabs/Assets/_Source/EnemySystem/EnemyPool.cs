﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace EnemySystem
{
    public class EnemyPool : MonoBehaviour
    {
        [SerializeField]private List<GameObject> enemies;
        private List<GameObject> _enemiesList;

        public void Initialize()
        {
            _enemiesList = new List<GameObject>();
            foreach (GameObject enemy in enemies)
            { 
                Instantiate(enemy, transform);
                ReturnToPool(enemy);
            }
        }
        public bool TryGetFromPool(out GameObject enemyInstance, Type enemyClass)
        {
            enemyInstance = null;
            if (_enemiesList.Count > 0)
            {
                foreach (var enemy in _enemiesList)
                {
                    enemy.TryGetComponent(out ABaseEnemy enemyType);
                    if (enemyType != null && enemyType.GetType() == enemyClass)
                    {
                        enemy.SetActive(true);
                        enemyInstance = enemy;
                        _enemiesList.Remove(enemy);
                      
                        return true;
                    }
                }
            }
            return false;
        }

        public void ReturnToPool(GameObject enemyInstance)
        {
            enemyInstance.SetActive(false);
            _enemiesList.Add(enemyInstance);
        }
    }
}
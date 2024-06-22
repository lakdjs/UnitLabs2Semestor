using UnityEngine;

namespace EnemySystem
{
    public class ShootingSystem
    {
        private Transform _firePoint;
        private GameObject _bullet;
        public ShootingSystem(Transform firePoint, GameObject bullet)
        {
            _firePoint = firePoint;
            _bullet = bullet;
        }
        public void Shoot()
        {
            GameObject bullet = GameObject.Instantiate(_bullet);
        }
    }
}
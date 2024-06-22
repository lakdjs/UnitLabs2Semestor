using UnityEngine;

namespace Core
{
    public class SpawnCommand : ICommand
    {
        private GameObject _prefab;
        private GameObject _spawnedPrefab;

        public SpawnCommand(GameObject prefab)
        {
            _prefab = prefab;
        }
        
        public void Invoke(Vector3 position)
        {
            _spawnedPrefab = Object.Instantiate(_prefab, position, Quaternion.identity);
            Debug.Log("Spawn");
        }

        public void Undo()
        {
            if (_spawnedPrefab != null)
            {
                GameObject.Destroy(_spawnedPrefab);
            }
        }
    }
}
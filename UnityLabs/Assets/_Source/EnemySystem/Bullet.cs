using System;
using System.Collections;
using UnityEngine;

namespace EnemySystem
{
    public class Bullet: MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private Rigidbody rigidbody;

        private void Update()
        {
            Fly();
        }
        private void Fly()
        {
            rigidbody.AddForce(-transform.right * speed * Time.deltaTime, ForceMode.Impulse);
            StartCoroutine(DestroyTime());

        }
        private IEnumerator DestroyTime()
        {
            yield return new WaitForSeconds(2);
            Destroy(gameObject);
        }
    }
}
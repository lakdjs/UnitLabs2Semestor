using UnityEngine;

namespace CharacterMovementSystem
{
    public class Movement : MonoBehaviour
    {
        [SerializeField] private float speed;
        private Vector2 _pointToMove;
        private Transform _currPos;


        public void Construct(Transform currPos)
        {
            _currPos = currPos;
            _pointToMove = currPos.position;
        }
        private void Update()
        {
            transform.position = Vector2.MoveTowards(_currPos.position, _pointToMove, speed * Time.deltaTime);
        }

        public void SetCurrPos(Vector2 pos)
        {
            _currPos.position = pos;
        }

        public void SetPointToMove(Vector2 pos)
        {
            _pointToMove = pos;
        }
    }
}

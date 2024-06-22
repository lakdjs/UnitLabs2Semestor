using CharacterMovementSystem;
using UnityEngine;

namespace Core
{
    public class MoveCommand : ICommand
    {
        private Movement _movement;

        public MoveCommand(Movement movement)
        {
            _movement = movement;
        }
        
        public void Invoke(Vector3 position)
        {
            _movement.SetCurrPos(_movement.transform.position);
            _movement.SetPointToMove(position);
            Debug.Log("Move");
        }

        public void Undo()
        {
            _movement.SetCurrPos(_movement.transform.position);
            _movement.SetPointToMove(_movement.transform.position);
        }
    }
}
using System;
using CharacterMovementSystem;
using InputSystem;
using UnityEngine;
using UnityEngine.UIElements;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private MouseButton moveButton;
        [SerializeField] private MouseButton spawnButton;
        [SerializeField] private MouseButton undoButton;
        [SerializeField] private InputListener inputListener;
        [SerializeField] private Movement movement;
        [SerializeField] private GameObject prefabToSpawn;

        private MoveCommand _moveCommand;
        private SpawnCommand _spawnCommand;

        private CommandInvoker _commandInvoker;
        private void Awake()
        {
           SetUp();
        }

        private void SetUp()
        {
            movement.Construct(movement.gameObject.transform);
            _commandInvoker = new CommandInvoker();
            _moveCommand = new MoveCommand(movement);
            _spawnCommand = new SpawnCommand(prefabToSpawn);
            inputListener.Construct(_commandInvoker,moveButton,spawnButton, undoButton, _moveCommand, _spawnCommand);
        }
    }
}
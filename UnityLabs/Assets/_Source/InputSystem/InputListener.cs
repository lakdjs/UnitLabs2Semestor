using System;
using Core;
using UnityEngine;
using UnityEngine.UIElements;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        private MouseButton _moveButton;
        private MouseButton _spawnButton;
        private MouseButton _undoButton;
        private CommandInvoker _commandInvoker;
        private MoveCommand _moveCommand;
        private SpawnCommand _spawnCommand;
        private RaycastHit _hit;

        public void Construct(CommandInvoker commandInvoker,
            MouseButton moveButton,
            MouseButton spawnButton, 
            MouseButton undoButton,
            MoveCommand moveCommand,
            SpawnCommand spawnCommand)
        {
            _commandInvoker = commandInvoker;
            _moveButton = moveButton;
            _spawnButton = spawnButton;
            _undoButton = undoButton;
            _moveCommand = moveCommand;
            _spawnCommand = spawnCommand;
        }

        private void Update()
        {
            CheckMove();
            CheckSpawn();
            CheckUndo();
        }

        private void CheckMove()
        {
            if (Input.GetMouseButtonDown((int)_moveButton))
            {
                Debug.Log((int)_moveButton);
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out _hit))
                {
                    
                }
                Debug.Log($"{_hit.point}");
               // RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                _commandInvoker.Execute(_hit.point,_moveCommand);
            }
        }
        private void CheckSpawn()
        {
            if (Input.GetMouseButtonDown((int)_spawnButton))
            {
                Debug.Log((int)_spawnButton);
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out _hit))
                {
                    
                }
                Debug.Log($"{_hit.point}");
               // RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                _commandInvoker.Execute(_hit.point,_spawnCommand);
            }
        }

        private void CheckUndo()
        {
            if (Input.GetMouseButtonDown((int)_undoButton))
            {
                Debug.Log("Undo");
               _commandInvoker.Undo();
            }
        }
    }
}
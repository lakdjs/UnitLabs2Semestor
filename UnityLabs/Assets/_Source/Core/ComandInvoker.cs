using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class CommandInvoker
    {
        private const int COMMANDQUANTITY = 10;
        private Queue<ICommand> _commandsToExecute = new Queue<ICommand>();
        private List<ICommand> _executedCommands = new List<ICommand>();

        public void Execute(Vector3 position, ICommand commandToDo)
        {
            if (_commandsToExecute.Count >= COMMANDQUANTITY)
            {
                Undo();
                return;
            }
            _commandsToExecute.Enqueue(commandToDo);
            while (_commandsToExecute.Count > 0)
            {
                ICommand command = _commandsToExecute.Dequeue();
                command.Invoke(position);
                _executedCommands.Add(command);
            }
        }

        public void Undo()
        {
            if (_commandsToExecute.Count <= 0)
            {
                return;
            }

            ICommand command = _executedCommands[0];  
            _executedCommands.RemoveAt(0);
            command.Undo();
        }
    }
}
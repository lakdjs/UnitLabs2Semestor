using UnityEngine;

namespace Core
{
    public interface ICommand
    {
        void Invoke(Vector3 position);
        void Undo();
    }
}
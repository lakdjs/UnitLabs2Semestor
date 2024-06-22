using UnityEngine;

namespace HotDogSystem.HotDogData
{
    [CreateAssetMenu(fileName = "HotDogSO", menuName = "SO/HotDogDataSO")]
    public class HotDogDataSO: ScriptableObject
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public int Weight { get; private set; }
        [field: SerializeField] public int Cost { get; private set; }
    }
}
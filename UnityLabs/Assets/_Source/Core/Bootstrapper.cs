using System;
using HotDogSystem;
using HotDogSystem.HotDogData;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private HotDogDataSO classicHotDogData;
        [SerializeField] private HotDogDataSO cesarHotDogData;
        [SerializeField] private HotDogDataSO meatHotDogData;

        private ABaseHotDog _classicHotDog;
        private ABaseHotDog _cesarHotDog;
        private ABaseHotDog _meatHotDog;
        private HotDogDecorator _sweetOnion;
        private HotDogDecorator _pickles;

        private void Awake()
        {
            SetUp();
        }

        private void SetUp()
        {
            _classicHotDog = new ClassicHotDog(classicHotDogData.Name, classicHotDogData.Weight, classicHotDogData.Cost);
            _cesarHotDog = new CesarHotDog(cesarHotDogData.Name, cesarHotDogData.Weight, cesarHotDogData.Cost);
            _meatHotDog = new MeatHotDog(meatHotDogData.Name, meatHotDogData.Weight, meatHotDogData.Cost);
            _sweetOnion = new SweetOnion("со сладким луком",_classicHotDog, 10, 30);
            _pickles = new Pickles("с маринованными огурцами",_classicHotDog,20,50);
            
            Debug.Log($"{_classicHotDog.GetName()}" + $"весит {_classicHotDog.GetWeight()}" + $"стоит {_classicHotDog.GetCost()}");
            Debug.Log($"{_classicHotDog.GetName() + _sweetOnion.GetName()}"
                      + $"весит {_classicHotDog.GetWeight() + _sweetOnion.GetWeight()}" 
                      + $"стоит { _sweetOnion.GetCost()}");
            Debug.Log($"{_classicHotDog.GetName() + _pickles.GetName()}"
                      + $"весит {_classicHotDog.GetWeight() + _pickles.GetWeight()}" 
                      + $"стоит { _pickles.GetCost()}");
        }
    }
}

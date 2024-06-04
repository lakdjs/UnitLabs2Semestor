using System;
using PlayerSystem;
using UnityEngine;
using UnityEngine.Serialization;
using Button = UnityEngine.UI.Button;

namespace Core
{
    public class Bootstrapper: MonoBehaviour
    {
        [SerializeField] private Button fistButton;
        [SerializeField] private Button swordButton;
        [SerializeField] private Button kickButton; 
        private AttackPerformer _attackPerformer;
        private IAttackStrategy _fistAttack;
        private IAttackStrategy _swordAttack;
        private IAttackStrategy _kickAttack;
        
        private void Awake()
        {
            SetUp();
        }

        private void SetUp()
        {
            _fistAttack = new FistAttackStrategy();
            _swordAttack = new SwordAttackStrategy();
            _kickAttack = new KickAttackStrategy();
            _attackPerformer = new AttackPerformer(_fistAttack);
            fistButton.onClick.AddListener (() => _attackPerformer.SetStrategy(_fistAttack));
            swordButton.onClick.AddListener (() => _attackPerformer.SetStrategy(_swordAttack));
            kickButton.onClick.AddListener (() => _attackPerformer.SetStrategy(_kickAttack));
        }
    }
}
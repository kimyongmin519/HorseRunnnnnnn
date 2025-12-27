using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;

namespace Code.Horse
{
    public class Horse : MonoBehaviour
    {
        [field:SerializeField] public int Number { get; private set; }
        
        private readonly int _idleHash = Animator.StringToHash("Idle");
        private readonly int _runHash = Animator.StringToHash("Run");
        public Animator Animator { get; private set; }
        public HorseMovement Mover { get; private set; }
        private TextMeshPro _numberText;

        private void Awake()
        {
            Animator = GetComponent<Animator>();
            Mover = GetComponent<HorseMovement>();
            
            Mover.SetDir(Vector3.forward);

            _numberText = GetComponentInChildren<TextMeshPro>();
        }

        private void Start() => _numberText.SetText(Number.ToString());

        private void Update()
        {
            float getSpeed = Mover.GetSpeed();

            if (getSpeed == 0)
            {
                Animator.speed = 1;
                Animator.SetBool(_runHash, false);
                Animator.SetBool(_idleHash, true);
            }
            else
            {
                Animator.speed = getSpeed / 15;
                Animator.SetBool(_idleHash, false);
                Animator.SetBool(_runHash, true);
            }
        }
    }
}

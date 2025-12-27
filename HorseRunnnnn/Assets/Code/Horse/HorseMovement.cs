using System;
using UnityEngine;

namespace Code.Horse
{
    public class HorseMovement : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        [SerializeField] private float _speed = 0;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void SetSpeed(float speed)
        {
            _speed = speed;
        }

        private void FixedUpdate()
        {
            _rigidbody.linearVelocity = Vector3.forward  * _speed;
        }
    }
}

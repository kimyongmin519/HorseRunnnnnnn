using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Code.Horse
{
    public class HorseMovement : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        private float _speed;
        private Vector3 _dir;

        public static float MinSpeed;
        public static float MaxSpeed;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Start() => StartCoroutine(RoutineSpeed());

        public void SetSpeed(float speed)
        {
            _speed = speed;
        }
        public void SetDir(Vector3 dir)
        {
            _dir = dir;
        }

        private void FixedUpdate()
        {
            Vector3 v = _rigidbody.linearVelocity;
            
            v.x = _dir.x * _speed;
            v.z = _dir.z * _speed;
            
            _rigidbody.linearVelocity = v;
        }

        public float GetSpeed()
        {
            return _speed;
        }

        private IEnumerator RoutineSpeed()
        {
            SetSpeed(Random.Range(MinSpeed, MaxSpeed));
            yield return new WaitForSeconds(Random.Range(1f,2f));
            StartCoroutine(RoutineSpeed());
        }
    }
}

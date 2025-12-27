using System;
using Unity.Cinemachine;
using UnityEngine;

namespace Code
{
    public class RaceCamera : MonoBehaviour
    {
        [SerializeField] private Transform[] horses;
        private CinemachineCamera _cineCam;

        private Transform _target;

        private void Awake()
        {
            _cineCam = GetComponent<CinemachineCamera>();
        }

        private void Start()
        {
            _target = horses[0];
        }

        private void LateUpdate()
        {
            foreach (var horse in horses)
            {
                if (_target.transform.position.z < horse.transform.position.z)
                {
                    _target = horse;
                }
            }
            _cineCam.Follow = _target;
        }
    }
}

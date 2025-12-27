using System;
using Code.Horse;
using UnityEngine;

namespace Code
{
    public class RaceManager : MonoBehaviour
    {
        public static RaceManager Instance { get; private set; }

        [SerializeField] private float minSpeed;
        [SerializeField] private float maxSpeed;

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
            else
                Destroy(gameObject);
        }

        private void Start()
        {
            HorseMovement.MinSpeed = minSpeed;
            HorseMovement.MaxSpeed = maxSpeed;
        }
    }
}

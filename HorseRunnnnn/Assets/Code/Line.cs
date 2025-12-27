using System;
using UnityEngine;

namespace Code
{
    public class Line : MonoBehaviour
    {
        protected Rigidbody Rigidbody;

        private void Awake()
        {
            Rigidbody = GetComponent<Rigidbody>();
        }

        protected virtual void OnCollisionEnter(Collision other)
        {
            if (other.transform.TryGetComponent(out Horse.Horse horse))
            {
                Rigidbody.useGravity = true;
            }
        }
    }
}

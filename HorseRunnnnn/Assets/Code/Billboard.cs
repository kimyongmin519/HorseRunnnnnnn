using System;
using UnityEngine;

namespace Code
{
    public class Billboard : MonoBehaviour
    {
        private Transform _camTrm;

        private void LateUpdate()
        {
            _camTrm = Camera.main.transform;
            
            transform.LookAt(_camTrm);
        }
    }
}

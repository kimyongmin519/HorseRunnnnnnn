using UnityEngine;

namespace Code
{
    public class ClearLine : Line
    {
        protected override void OnCollisionEnter(Collision other)
        {
            if (other.transform.TryGetComponent(out Horse.Horse horse))
            {
                Rigidbody.useGravity = true;
            }
        }
    }
}

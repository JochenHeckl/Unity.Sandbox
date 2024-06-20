using UnityEngine;

namespace Colliders
{
    public class InteractionManager : MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
        {
            var rigidbody = other.GetComponent<Rigidbody>();

            if (rigidbody != null)
            {
                rigidbody.useGravity = false;
                rigidbody.linearVelocity = Vector3.zero;
            }
        }
    }
}

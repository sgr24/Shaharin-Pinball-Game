using UnityEngine;

public class BounceObject : MonoBehaviour
{
    public float explosionStrength = 100;

    void OnCollisionEnter(Collision _other)
    {
        _other.rigidbody.AddExplosionForce(explosionStrength, this.transform.position, 5);
    }
}
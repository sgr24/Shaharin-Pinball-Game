using UnityEngine;

public class Example : MonoBehaviour
{
    public Transform ball;
    private Vector3 startingPos;

    private void Start()
    {
        startingPos = ball.position;
    }

    private void OnCollisionEnter(Collision _other)
    {
        if (_other.gameObject.tag == "Ball")
        {
            Debug.Log("hello");
            _other.rigidbody.velocity = Vector3.zero;
            _other.transform.position = startingPos;
        }
    }
}
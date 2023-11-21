using UnityEngine;

public class CodeTranslation : MonoBehaviour
{
    public string inputButtonName = "Pull";
    public float distance = 50f;
    public float speed = 1f;
    public GameObject ball;
    public float power = 2000f;
    private bool ready = false;
    private bool fire = false;
    private float moveCount = 0f;

    private void OnCollisionEnter(Collision _other)
    {
        if (_other.gameObject.tag == "Ball")
        {
            ready = true;
        }
    }

    private void Update()
    {
        if (Input.GetButton(inputButtonName))
        {
            // As the button is held down, slowly move the piece
            if (moveCount < distance)
            {
                transform.Translate(0, 0, -speed * Time.deltaTime);
                moveCount += speed * Time.deltaTime;
                fire = true;
            }
        }
        else if (moveCount > 0)
        {
            // Shoot the ball
            if (fire && ready)
            {
                ball.transform.TransformDirection(Vector3.forward * 10);
                ball.GetComponent<Rigidbody>().AddForce(0, 0, moveCount * power);
                fire = false;
                ready = false;
            }
            // Once we have reached the starting position fire off!
            transform.Translate(0, 0, 20 * Time.deltaTime);
            moveCount -= 20 * Time.deltaTime;
        }
        // Just ensure we don't go past the end
        if (moveCount <= 0)
        {
            fire = false;
            moveCount = 0;
        }
    }
}
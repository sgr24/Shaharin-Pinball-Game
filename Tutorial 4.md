# Pinball Game Tutorial

I used the template from https://www.youtube.com/watch?v=HObTp3JM_Qw

## 4. Making Out Of Bounds Border and making it functional

Start by placing a cube in the scene;
- Game Object --> 3D object --> Cube

Resize the cube to cover the whole length if not slightly wider than the whole pinball board and make it longer to create the border

Re-position the Main Camera so it does not show the cube that you have just made since the only purpose of the cube that you have created was to detect the ball if it goes off the board, make sure that the camera only shows the main board instead of the board as well as the cube that you have made

The code that will detect when the ball goes out of bounds will have 2 features:

The first one detects the velocity of the ball;

,,,

    _other.rigidbody.velocity = Vector3.zero;

,,,

The second one detects the starting position of the ball, so when the ball falls it resets the ball back into the spring lane;

,,,

    private Vector3 startingPos;

    private void Start()
    {
        startingPos = ball.position;
    }

,,,

Therefore for the entire code to work smoothly, we would have to first detect the ball, then follow up with detecting the ball and where to reset the ball to when the ball falls out of bounds

,,,

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

,,,

Finally going back to the inspector tab, click and drag the ball object name from the hierarchy to the Ball section within the public script that is in the inspector tab

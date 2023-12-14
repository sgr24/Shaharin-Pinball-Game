# Pinball Game Tutorial

I used the template from https://www.youtube.com/watch?v=gAlJN8VGo94

## 2. Making the spring, and making it functional

Duplicate the right side of your boundary and create a new area slot to sling the ball up the board using the spring, make sure the ball fits within the new area, and create a gap so the ball can exit the new sling area to the main board

Now create a cube: Game Object --> 3D Object --> Cube

Now size the cube to the size you want it to look like and place it within the new sling area that you have just created, make sure the cube is small enough to move up and down the sling area freely

Resize the plane or the board so it covers the new sling area

Click on the cube

Drag the PullSpring script onto the cube, this will apply the code to the object

The public code is what allows you to edit the strength of the spring, as well as how far it travels down to shoot the ball up and how fast the spring should move;

,,,

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
    
,,,

The way the spring will stop the ball from rolling back within its lane is through collision as well as a rigid body;

,,,

    private void OnCollisionEnter(Collision _other)
    {
        if (_other.gameObject.tag == "Ball")
        {
            ready = true;
        }
    }

,,,

To ensure the spring does not fall off the board, put in a stop towards the edge of the box, where it maximises the movement, so the spring cannot go back any further by writing the following within the script;

,,,

        if (moveCount <= 0)
        {
            fire = false;
            moveCount = 0;
        }

,,,

For the spring to work properly, we will write something that will allow the ball to shoot upwards like a cannon as soon as the spring is let go:

,,,

            if (fire && ready)
            {
                ball.transform.TransformDirection(Vector3.forward * 10);
                ball.GetComponent<Rigidbody>().AddForce(0, 0, moveCount * power);
                fire = false;
                ready = false;
            }
            transform.Translate(0, 0, 20 * Time.deltaTime);
            moveCount -= 20 * Time.deltaTime;

,,,

Finally, before editing the strength of the spring, we will add controls to the spring so it can be controlled by either a keyboard or mouse:

,,,

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

,,,

Now onto editing the movement of the spring, we will type out how far the spring is allowed to move back, its speed as well as its strength alongside allowing it to identify what object the spring is shooting

Change the digits to the following figures within the pull spring script in the inspect tab:
- Distance --> 1.8
- Speed --> 1.5
- Power --> 1500

For the ball, grab the ball from your hierarchy and drop it onto the ball section within the open script

Finally set the ball to a ball tag on the top of the inspector page

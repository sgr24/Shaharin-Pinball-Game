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

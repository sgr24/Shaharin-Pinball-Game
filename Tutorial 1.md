# Pinball Game Tutorial

I used this code from https://www.youtube.com/watch?v=gAlJN8VGo94 & https://www.youtube.com/watch?v=HObTp3JM_Qw

## 1. Making the paddle and getting it to work

Start by clicking game object --> 3D Objects --> Cube

Place the cube towards the bottom of the plane, and resize it to make it longer to your liking

Right-click on a space on the assets lists, go on create and create all the materials needed, from textures to colour

Take and hold the black material colour and let go to colour the cube

Click on the shape that you have just created, click on add component --> Hinge Joint

Drag the flipper script and give it to the flipper that you have just made, what you will realise is that there is an orange arrow within the sprite, that orange arrow is what will hold the object in place depending on where on the shape you place it on

,,,

    public class Flipper : MonoBehaviour

,,,

This allows you to publicly edit specific changes that you want to make to the flipper

,,,

    private new HingeJoint hingeJoint;

    private void Awake()
    {
        hingeJoint = GetComponent<HingeJoint>();
        hingeJoint.useSpring = true;
    }

,,,

Head to the Hinge joint section within the inspector tab:

As for the anchor;

                    - the x-axis will be -0.5, y-axis will be 0
For the Axis;

            - the x-axis will be 0, y-axis will be 1


This will allow the hinge to be fixated into the back end of the paddle, allowing it to swing up and down when needed

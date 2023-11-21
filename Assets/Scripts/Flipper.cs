using UnityEngine;

public class Flipper : MonoBehaviour
{
    // Parameters
    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float flipperStrength = 10f;
    public float flipperDamper = 1f;
    public string inputButtonName = "LeftPaddle";

    private new HingeJoint hingeJoint;

    private void Awake()
    {
        hingeJoint = GetComponent<HingeJoint>();
        hingeJoint.useSpring = true;
    }

    private void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = flipperStrength;
        spring.damper = flipperDamper;

        if (Input.GetButton(inputButtonName))
        {
            spring.targetPosition = pressedPosition;
        }
        else
        {
            spring.targetPosition = restPosition;
        }

        hingeJoint.spring = spring;
        hingeJoint.useLimits = true;
        JointLimits limits = hingeJoint.limits;
        limits.min = restPosition;
        limits.max = pressedPosition;
        hingeJoint.limits = limits;
    }
}
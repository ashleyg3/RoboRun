using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leg : MonoBehaviour
{
    private HingeJoint2D jointRef;
    private JointMotor2D motorRef;
    public bool isFront;
    public bool isTop;
    // Start is called before the first frame update
    private KeyCode A;
    private KeyCode B;
    public float speed = 200;

    void Start()
    {
        jointRef = GetComponent<HingeJoint2D>();
        motorRef = jointRef.motor;        
        if (isFront) {
            if (isTop) {
                A = KeyCode.UpArrow;
                B = KeyCode.DownArrow;
            } else {
                A = KeyCode.LeftArrow;
                B = KeyCode.RightArrow;
            }
        } else {
            if (isTop) {
                A = KeyCode.W;
                B = KeyCode.S;
            } else {
                A = KeyCode.A;
                B = KeyCode.D;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(A)) {    
            JointMotor2D newMotor = motorRef;
            newMotor.motorSpeed = 50f;
            jointRef.motor = newMotor;
        }   

        if (Input.GetKey(B)) {
            JointMotor2D newMotor = motorRef;
            newMotor.motorSpeed = -50f;
            jointRef.motor = newMotor;
        }

        if (Input.GetKeyUp(A)) {
            JointMotor2D newMotor = motorRef;
            newMotor.motorSpeed = 0f;
            jointRef.motor = newMotor;
        }

        if (Input.GetKeyUp(B)) {
            JointMotor2D newMotor = motorRef;
            newMotor.motorSpeed = 0f;
            jointRef.motor = newMotor;
        }
    }
}

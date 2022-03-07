using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    //wheel colliders
    public WheelCollider wheelFL;
    public WheelCollider wheelFR;
    public WheelCollider wheelBL;
    public WheelCollider wheelBR;
    //torque values
    public float engineTorque;
    public float brakeTorque;
    //steering angle
    public float maxSteeringAngle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Vertical") > 0)
        {
            wheelFL.motorTorque = engineTorque * Input.GetAxis("Vertical");
            wheelFR.motorTorque = engineTorque * Input.GetAxis("Vertical");
            wheelBL.motorTorque = engineTorque * Input.GetAxis("Vertical");
            wheelBR.motorTorque = engineTorque * Input.GetAxis("Vertical");
        }
        if(Input.GetAxis("Vertical") < 0)
        {
            wheelFL.motorTorque = brakeTorque * Input.GetAxis("Vertical");
            wheelFR.motorTorque = brakeTorque * Input.GetAxis("Vertical");
            wheelBL.motorTorque = brakeTorque * Input.GetAxis("Vertical");
            wheelBR.motorTorque = brakeTorque * Input.GetAxis("Vertical");
        }
        wheelFL.steerAngle = maxSteeringAngle * Input.GetAxis("Horizontal");
        wheelFR.steerAngle = maxSteeringAngle * Input.GetAxis("Horizontal");
        
    }
}

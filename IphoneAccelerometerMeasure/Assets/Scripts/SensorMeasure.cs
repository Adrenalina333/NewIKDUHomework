using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.IO;


public class SensorMeasure : MonoBehaviour
{

    Vector3 dataAccelerometer = Input.acceleration;

    private void Update()
    { 

        float tempx = Input.acceleration.x;
        Debug.Log(tempx);

        float tempy = Input.acceleration.y;
        Debug.Log(tempy);

        float tempz = Input.acceleration.z;
        Debug.Log(tempz);

    }

    private void Start()
    {
       
        /*
        if (Accelerometer.current != null)
        {
            InputSystem.EnableDevice(Accelerometer.current);
            Debug.Log("Accelerometer enabled!");
        }
        */
    }
    public static Vector3 ReadValue()
    {
        return Input.accelereomter.ReadValue();
    }
    
    
}

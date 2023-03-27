using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SensorReader : MonoBehaviour
{ 

    private void Update()
    {
        Vector3 dir = Vector3.zero;

        if (dir.sqrMagnitude > 1)
        {
            dir.Normalize();
        }

        float tempx = Input.acceleration.x;
        Debug.Log(tempx);

        float tempy = Input.acceleration.y;
        Debug.Log(tempy);

        
    }

    private void Start()
    { 
        if (Accelerometer.current == null)
        {
            InputSystem.EnableDevice(Accelerometer.current);
            Debug.Log("Accelerometer enabled!");
        }
    }
    public static Vector3 ReadValue()
    {
        return Accelerometer.current.acceleration.ReadValue();
    }
}

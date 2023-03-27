using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SensorReader : MonoBehaviour
{


    private void Update()
    {
        Vector3 accelerometerdata = Input.acceleration;

        float tempx = Input.acceleration.x;
        Debug.Log(tempx);

        float tempy = Input.acceleration.y;
        Debug.Log(tempy);

        float tempz = Input.acceleration.z;
        Debug.Log(tempz);

        string dataString = string.Format("{0},{1},{2}", accelerometerdata.x, accelerometerdata.y, accelerometerdata.z);


    }
}
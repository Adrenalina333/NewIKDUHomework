using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;

public class ButtonBehavior : MonoBehaviour
{
    public Button StartButton;

    public Button StopButton;

    public float logging = 10f;

    public bool isPressed = false;

    private string filePath;

    private StreamWriter writer;
    
    void Start ()
    {

         filePath = @"C:\Users\Adeli\CSV_DATA\AccelerometerData" + ".csv";
            writer = new StreamWriter(filePath);
            writer.WriteLine("X,Y,Z");
    }

   void Update()
    {
        if (isPressed == true)
        {

            Vector3 accelerometerdata = Input.acceleration;

            string dataString = string.Format("{0},{1},{2}", accelerometerdata.x, accelerometerdata.y, accelerometerdata.z);

            writer.WriteLine(dataString);

            Debug.Log(dataString);

            Invoke("ButtonFalse", logging);

        }
    }

    void ButtonFalse()
    {
        isPressed = false;
        writer.Close();
    }

}

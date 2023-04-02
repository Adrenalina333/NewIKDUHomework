using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;
using Unity.Android.Gradle;

public class ButtonBehavior : MonoBehaviour
{
    public Button MeasureButton;

    //public float logging = 10f;

    public bool isPressed = false;

    private string filePath;

    private StreamWriter writer;

    void Start()
    {

        filePath = @"C:\Users\Adeli\CSV_DATA\AccelerometerData" + System.DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv";
        writer = new StreamWriter(filePath);
        writer.WriteLine("X;Y;Z");
    }

    void Update()
    {
        if (isPressed)
        {

            Vector3 accelerometerdata = Input.acceleration;

            string dataString = string.Format("{0},{1},{2}", accelerometerdata.x, accelerometerdata.y, accelerometerdata.z);

            if( accelerometerdata.y < -0.95f)
            {
                writer.WriteLine(dataString);

                Debug.Log(dataString);

            }
            
            if( accelerometerdata.y > 0)
            {
                ButtonPressed();
            }

        }

    }

    public void ButtonPressed()
    {
        if (isPressed)
        {
            isPressed = false;
        }
        else
        {
            isPressed = true;
        }

    }


}

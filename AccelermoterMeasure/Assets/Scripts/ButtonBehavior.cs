using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Xml;
using System.Xml.Serialization;

public class ButtonBehavior : MonoBehaviour
{
    public Button MeasuringButton;
    public TextMeshProUGUI ValueText;

    public bool IsPressed = false;

    public string strData;

    public string line;

    private string _dataPath;

    private string _state;
    
    private string _textFile;

    private string _xmlLevelProgress;

    private string value;

    /*
    void Start ()
    {
        Initialize();
    }
    
    void Awake()
    {
        _dataPath = Application.persistentDataPath + "/Sensor_Data/";

        Debug.Log(_dataPath);

        _textFile = _dataPath + "Save_Data.csv";

        //_xmlLevelProgress = _dataPath + "Progress_Data.xml";
    }

    
    public void Initialize()
    {
        NewDirectory();
    }
    */


    //string value, bool IsPressed, string datapath

    public void PrintingValues(string s)
    {
        if (IsPressed == true)
        {
            value = SensorReader.ReadValue().ToString();

            Debug.Log(value);
            
            //valueText.text = SensorReader.ReadValue().ToString());


            /*
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@datapath, true))
                {
                    file.WriteLine(value);
                    Debug.Log("We are writing a value: " + value);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Exceeded limit :", ex);
            }
            */

        }
        //else if((line = reader.ReadLine()) = true)
        //{
        //    strData = line.Split(",");
        //}

            //ValueText.text = SensorReader.ReadValue().ToString();

            //create a csv writer to put the value into a file
            //Only write to csv if there are less than a set amount of values in a lis

    }

    public void ButtonPressed()
    {
        if(IsPressed == true)
        { 
            IsPressed = false;

            //set to false by knowing the values of the phone when it is laying down
        }
        else if(IsPressed == false)
        {
            IsPressed = true;
        }

    }

    /*
    public void NewDirectory()
    {
        if(Directory.Exists(_dataPath))
        {
            Debug.Log("Directory already exists...");
            return;
        }

        Directory.CreateDirectory(_dataPath);
        Debug.Log("New directory created!");
    }
    */

}

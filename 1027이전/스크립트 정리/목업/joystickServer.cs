using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine;

public class joystickServer : MonoBehaviour
{


    public string value ;
    public string getKey;
    public string getControl;
    public bool open = true;       //아두이노 연결 안되도 일단은 되게하는 변수.

    SerialPort sp = new SerialPort("COM4", 9600);


    public void Start()
    {

        sp.Open();

        sp.ReadTimeout = 1;



    }
   


    // Update is called once per frame

    public void Update()
    {

        if (sp.IsOpen)

        {

            try

            {

              
                value = sp.ReadLine();
                print(value);
                getKey = value.Substring(0, 1);   //첫번째 키 
                getControl = value.Substring(1, 1);   //"두"번째 키 
                Debug.Log(getKey + "<<");
                Debug.Log(getControl + "<<v2");
                sp.BaseStream.Flush();
                

            }

            catch (System.Exception)

            {



            }
        
        }


    }
}

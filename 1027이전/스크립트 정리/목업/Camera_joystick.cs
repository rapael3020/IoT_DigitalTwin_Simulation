using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_joystick : MonoBehaviour
{
    public Camera FirstCamera;
    public Camera SecondCamera;
    public Camera ThirdCamera;
    bool maincam;
    string n;
    string before;
    string now;
    bool delay;
    joystickServer js;
    // Start is called before the first frame update
    void Start()
    {
        FirstCamera.enabled = true;
        SecondCamera.enabled = false;
        ThirdCamera.enabled = false;
        n = "1";
        showFirst();
        js = GameObject.FindGameObjectWithTag("server1").GetComponent<joystickServer>() as joystickServer;

    }
    public void showFirst()
    {
        FirstCamera.enabled = true;
        SecondCamera.enabled = false;
        ThirdCamera.enabled = false;
    }
    public void showSecond()
    {
        FirstCamera.enabled = false;
        SecondCamera.enabled = true;
        ThirdCamera.enabled = false;
    }
    public void showThird()
    {
        FirstCamera.enabled = false;
        SecondCamera.enabled = false;
        ThirdCamera.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
      
        js.getControl = now;    //1,2만 들어와.
        if (n != before && js.getKey=="d")
        {
            if (n == "1" && (before == "2" || before == "3"))         //main
            {
                Invoke("showFirst", 0.5f);

                if (Input.GetKey(KeyCode.M))    //조이스틱 오른쪽이면
                {
                    n = "2";
                    before = "1";
                }
                else if (Input.GetKey(KeyCode.N))//조이스틱 왼쪽이면
                {
                    n ="3";
                    before = "1";
                }
            }



            else if (n == "2" && (before == "1" || before == "3"))    //sub1
            {
                Invoke("showSecond", 0.5f);

                if (Input.GetKey(KeyCode.M))
                {
                    before = "2";
                    n = "3";
                }
                else if (Input.GetKey(KeyCode.N))
                {
                    before = "2";
                    n = "1";
                }

            }
            else if (n == "3" && (before == "2" || before == "1"))
            {
                Invoke("showThird", 0.5f);


                if (Input.GetKey(KeyCode.M))
                {
                    n = "1";
                    before = "3";
                }
                else if (Input.GetKey(KeyCode.N))
                {
                    n = "2";
                    before = "3";

                }
            }

        }
    }
}

 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorial_Arm_p1 : MonoBehaviour
{

    joystickServer js;
    int ifput_q = 0;
   int dontpop = 1;
    private float speed2 = 5.0f;
    private float b;
    bool col=false;
    private float timeSpan = 0f;
    float invokeSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        js = GameObject.FindGameObjectWithTag("server1").GetComponent<joystickServer>() as joystickServer;
    }

    void popup2()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_2();
    }
    void invoke_popupgood()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_good();
    }
    void close()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
    }
    void startp2()
    {
        GameObject.FindGameObjectWithTag("p2").GetComponent<tutorial_Arm_p2>().enabled = true;
    }



    // Update is called once per frame
    public  void Update()
    {
        float angle2 = GameObject.FindGameObjectWithTag("p1").transform.eulerAngles.z; 
      


        //30도 이상이 움직이면 튜토리얼 1이 시작된다. 
       // float angle = transform.eulerAngles.z;     //오일러 각이 우리가 아는 각이다. 

        if (angle2 >= 180f)
        {
            angle2 -= 360f;
        }

        if (Input.GetKey(KeyCode.Q)||js.getKey=="a")
        {
            ifput_q = 1;
        }

        if (dontpop == 1)
        {
            popup2();
            if (Input.GetKey(KeyCode.F)||js.getKey=="f")
            {
                close();//GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
                dontpop += 1;
            }

        }

      //  Debug.Log("p1==>" + angle2);
            if ((angle2 <= 10 && angle2 >=-20) && ifput_q==1) //조건을 만족시.
        {
            Play();
        }
        else
        {
            if (dontpop == 2 && ifput_q == 1)
            {
                Invoke("invoke_popupgood", invokeSpeed);  //   GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_good();

                   if (Input.GetKey(KeyCode.F)|| js.getKey=="f")
                     {
                    Invoke("close", invokeSpeed); // GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();

                    ifput_q = 2;
                  
                }
            }else if (ifput_q == 2)
            {
                Invoke("startp2", 1);      //2번 활성화.


                GameObject.FindGameObjectWithTag("p1").GetComponent<tutorial_Arm_p1>().enabled = false;     //팝업 끝내고 비활성화. 그럼 1번은 작업이 끝이겟죠?
            }

            //연결 팝업시 클로즈는 1초 그다음 스크립트활성화는 2초 주자.
        }
        
        //Debug.Log(angle);
       
    }

    void Play()
    {
        b = Input.GetAxis("Vertical");
        float z1 = speed2 * 3 * Time.deltaTime;
        float z2 = -speed2 * 3 * Time.deltaTime;
        

                if (Input.GetKey(KeyCode.LeftArrow) || (js.getKey == "a" && js.getControl == "1"))
            {
               
                if (b >= 0)
                {
                    this.transform.Rotate(0, 0, z1);
                }
                else
                {
                    this.transform.Rotate(0, 0, z2);
                }

            }

            if (Input.GetKey(KeyCode.RightArrow) || (js.getKey == "a" && js.getControl == "2"))
            {

                if (b >= 0)
                {
                    this.transform.Rotate(0, 0, z2);
                }
                else
                {
                    this.transform.Rotate(0, 0,z1);
                }

            
            }

           

        }

       
    }
    


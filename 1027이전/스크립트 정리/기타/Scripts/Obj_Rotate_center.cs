using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj_Rotate_center : MonoBehaviour
{
    joystickServer js;
    void Start()
    {
        js = GameObject.FindGameObjectWithTag("server1").GetComponent<joystickServer>() as joystickServer;      //서버연결

    }

    private float speed2 = 5.0f;
    private float b;
    public float minVertical = 45.0f;
    public float Vertical = -45.0f;

    void left()
    {
        if (Input.GetKey(KeyCode.U) || (js.getKey == "c" && js.getControl == "1"))
        {    //기둥 왼쪽으로 30도 

            this.transform.Rotate(0, speed2 * 6 * Time.deltaTime, 0);

        }
    }
    void right()
    {
        if (Input.GetKey(KeyCode.I) || (js.getKey=="c" && js.getControl=="2"))
        {    //기둥 오른쪽으로 -30도

            this.transform.Rotate(0, -speed2 * 6 * Time.deltaTime, 0);
        }
    }
    // Update is called once per frame
    void Update()                               //회전 각도 -45 45 제한 걸기 필요.
    {

        float angle = this.transform.eulerAngles.y;     //오일러 각이 우리가 아는 각이다. 
        float ang = this.transform.rotation.y;
        if (angle > 180f) angle -= 360f;
        //  Debug.Log("오일러 "+angle);
        // Debug.Log(b);  
        // Debug.Log("쿼터니언"+ang);

        if (angle < 30f && angle > -30f)
        {
            left();
            right();
            
        }
        else    //제한범위 밖이면 
        {
            if (angle > 30f)//왼쪽으로 30도가 넘으면 I 키를 눌러서 오른쪽으로 옮기게
            {
                if (Input.GetKey(KeyCode.I) || (js.getKey == "c" && js.getControl == "2"))
                {

                    this.transform.Rotate(0, -speed2 * 6 * Time.deltaTime, 0);
                }
            }


            if (angle < -30f) //오른쪽으로 30도가 넘으면 U키를눌러서 왼쪽으로 옮기게
            {
                if (Input.GetKey(KeyCode.U) || (js.getKey == "c" && js.getControl == "1"))
                {    //임시로 기둥 돌리기

                    this.transform.Rotate(0, speed2 * 6 * Time.deltaTime, 0);

                }

            }


        }


    }
}

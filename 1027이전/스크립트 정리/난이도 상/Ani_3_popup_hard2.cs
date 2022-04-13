using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class Ani_3_popup_hard2 : MonoBehaviour
{
    joystickServer js;
    public Animator anim;

    void TriggerAni()
    {
        anim.SetTrigger("Active");
    }

    void go()
    {
        GameObject.FindGameObjectWithTag("p3").GetComponent<SceanManager>().ChangeFourthScean();
    }

    void invoke_popupgood()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_good();
    }
    void popup_ani_in_hard2()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_Ani_In_hard2();
    }
    void close()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
    }

    int popupcount = 0;

    private void Start()
    {
        js = GameObject.FindGameObjectWithTag("server1").GetComponent<joystickServer>() as joystickServer;      //서버연결
        Invoke("popup_ani_in_hard2", 1);
    }
    // Update is called once per frame
    void Update()
    {
        if (popupcount == 0)
        {
            if (Input.GetKey(KeyCode.F) || js.getKey == "f")
            {
                Invoke("close", 1);
                popupcount = 1;
                js.getKey = "no";

            }
        }
        else if (popupcount == 1)
        {
            Invoke("go", 1);
        }

    }
}

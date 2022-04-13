using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class Ani_6_popup_hard : MonoBehaviour
{
    joystickServer js;
    public Animator anim;

    void TriggerAni()
    {
        anim.SetTrigger("Active");
    }

    void invoke_popupgood()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_good();
    }
    void popup_ani_in_hard()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_Ani_In_hard3();
    }
    void close()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
    }

    int popupcount = 0;

    private void Start()
    {
        js = GameObject.FindGameObjectWithTag("server1").GetComponent<joystickServer>() as joystickServer;      //서버연결

        Invoke("popup_ani_in_hard", 1);
    }
    // Update is called once per frame
    void Update()
    {
        if (popupcount == 0)
        {
            if (Input.GetKey(KeyCode.F) || js.getKey == "f")
            {
                Invoke("close", 1);

                Invoke("TriggerAni", 2);

                popupcount = 1;
                js.getKey = "no";
            }
        }

    }
}

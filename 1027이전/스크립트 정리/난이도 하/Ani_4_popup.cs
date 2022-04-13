using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class Ani_4_popup : MonoBehaviour
{
    joystickServer js;
    public Animator anim;
    public Animator Cam;
    public Animator Oiltanker;

    void TriggerAni()
    {
        anim.SetTrigger("Active");
    }
    void TriggerAniCam()
    {
        Cam.SetTrigger("ActiveCam");
    }
    void TriggerAniOiltanker()
    {
        Cam.SetTrigger("Active_oiltanker");
    }


    void invoke_popupgood()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_good();
    }
    void popup_ani_out()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_Ani_out();
    }
    void popup_endSimul()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_endSimul();
    }
    void close()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
    }
  
    int popupcount = 0;
   
   void Start()
    {
        js = GameObject.FindGameObjectWithTag("server1").GetComponent<joystickServer>() as joystickServer;
        Invoke("popup_ani_out", 1);  
    }
    // Update is called once per frame
    void Update()
    {
        if (popupcount == 0)
        {
            if (Input.GetKey(KeyCode.F)||js.getKey=="f")
        {  
            Invoke("close", 1);
                Invoke("TriggerAni", 2);
                Invoke("TriggerAniCam",2);
                Invoke("TriggerAniOiltanker", 2);
                popupcount =1;
            
             }
        }
       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class Ani_3_popup : MonoBehaviour
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
    void popup_ani_in()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_Ani_In();
    }
    void close()
    {
        GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
    }
  
    int popupcount = 0;
   

   public void Start()
    {
        js = GameObject.FindGameObjectWithTag("server1").GetComponent<joystickServer>() as joystickServer;
        Invoke("popup_ani_in", 1);  
    }
    // Update is called once per frame
    void Update()
    {
        if (popupcount == 0)
        {
            if (Input.GetKey(KeyCode.F)|| js.getKey=="f")
        {  
            Invoke("close", 1);

                Invoke("TriggerAni",2);
               
                popupcount =1;
            
             }
        }
       
    }
}

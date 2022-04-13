using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Connection_Oil_tanker : MonoBehaviour
{
    private float GameTime = 11;
    public Text GameTimeText;
    bool pop = false;
    joystickServer js;
    void OnCollisionEnter(Collision collision)
    {

        void close()
        {
            GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
        }
        if (collision.collider.CompareTag("enemy") && pop == false)
        {
            //GameTimeText.text = "5초 뒤에 영상이 실행 됩니다.";

            GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_connection_hard();
            pop = true;
        }

        else if (collision.collider.CompareTag("enemy"))
        {
            SceneManager.LoadScene("02.Simulation_play");
        }
    }

    void Start()
    {
        js = GameObject.FindGameObjectWithTag("server1").GetComponent<joystickServer>() as joystickServer;      //서버연결
    }

    // Update is called once per frame
    void Update()
    {
        if (pop == true)
        {
            if (Input.GetKey(KeyCode.F)|| js.getKey=="f")
            {
                GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();       //팝업닫기
                Invoke("delay", 3);
                js.getKey = "no";
            }
        }
    }

    void delay()
    {
        SceneManager.LoadScene("03.Simulation_Animation");
    }
}
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
    void OnCollisionEnter(Collision collision)
    {

        void close()
        {
            GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();
        }
        if (collision.collider.CompareTag("enemy")&& pop==false)
        {
            //GameTimeText.text = "5초 뒤에 영상이 실행 됩니다.";
           
            GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupScript>().Popup_connection_hard();
            pop = true;   
        }
        
     
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pop == true)
        {
            if (Input.GetKey(KeyCode.F))
            {
                GameObject.FindGameObjectWithTag("popupSys").GetComponent<PopupSystem>().ClosePopup();       //팝업닫기
                Invoke("delay", 3);
            }
        }
    }

    void delay()
    {
        SceneManager.LoadScene("난이도상_연결");
    }
}
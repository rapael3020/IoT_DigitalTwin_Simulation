using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Connection_Oil_tanker_downVer : MonoBehaviour
{
    private float GameTime = 11;
    public Text GameTimeText;
    joystickServer js;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("enemy"))
        {
            GameTimeText.text = "5초 뒤에 영상이 실행 됩니다.";
            Invoke("delay", 5);
        }
        else if (collision.collider.CompareTag("enemy"))
        {
            SceneManager.LoadScene("tutorial");
        }
    }

    void Start()
    {
        js = GameObject.FindGameObjectWithTag("server1").GetComponent<joystickServer>() as joystickServer;      //서버연결
    }

    // Update is called once per frame
    void Update()
    {

    }

    void delay()
    {
        SceneManager.LoadScene("03.Simulation_Animation downVer");
    }
}
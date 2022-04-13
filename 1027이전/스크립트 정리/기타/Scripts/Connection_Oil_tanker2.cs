using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Connection_Oil_tanker2 : MonoBehaviour
{
    private float GameTime = 11;
    public Text GameTimeText;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("enemy"))
        {
            GameTimeText.text = "5초 뒤에 영상이 실행 됩니다.";
            Invoke("delay", 5);
        }
        else if (collision.collider.CompareTag("enemy"))
        {
            SceneManager.LoadScene("05.Simulation_play");
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void delay()
    {
        SceneManager.LoadScene("06.Simulation_Animation_Fixed");
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceanManager : MonoBehaviour
{
    joystickServer js;
    public GameObject ESC;
     void Start()
    {
        js = GameObject.FindGameObjectWithTag("server1").GetComponent<joystickServer>() as joystickServer;

    }
    public void ChangeFirstScean()
    {
        SceneManager.LoadScene("01.MainUI");
    }

    public void ChangeSecondScean()
    {
        SceneManager.LoadScene("02.Simulation_play_Fixed 1");
    }
    public void ChangeThirdScean()
    {
        SceneManager.LoadScene("03.Simulation_Animation");
    }
    public void ChangeFourthScean()
    {
        SceneManager.LoadScene("04.Simulation_Animation");
    }
    public void ChangeFifthScean()
    {
        SceneManager.LoadScene("05.Simulation_play_Fixed");
    }
    public void ChangeSixthScean()
    {
        SceneManager.LoadScene("06.Simulation_Animation_Fixed");
    }
    public void ChangeSeventhScean()
    {
        SceneManager.LoadScene("07.Simulation_Animation_Fixed");
    }
    public void ChangeEighthScean()
    {
        SceneManager.LoadScene("08.EndPage");
    }
    public void ChangeTutorial()
    {
        SceneManager.LoadScene("tutorial");
    }
    public void Change_p3downVer()
    {
        SceneManager.LoadScene("04.Simulation_Animation downVer");
    }
    public void ChangeMockup()
    {
        SceneManager.LoadScene("mockup");
    }


    public void Input_Continue()
    {
        ESC.SetActive(false);
    }
    public void Simul_Exit()
    {
        Application.Quit();
    }
    public void Update()
    {
        if (Input.GetButtonDown("Cancel")||js.getKey=="e")      //ESC버튼으로 메뉴창 끄고켜기
        {   if (ESC.activeSelf)
                ESC.SetActive(false);
        else
            ESC.SetActive(true);
            
        }

        
    }

}


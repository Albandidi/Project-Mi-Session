using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_Option :  MonoBehaviour
{

    public GameObject MenuUI;
    public static bool Pause_Game = false;

    //--------------------ESC MENU OPTION----------------------------------
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (Pause_Game)
            {
                Continue();
            }
            else
            {
                Pause();
            }
        }
    }
//--------------------------RESUME MENU OPTION--------------------------------------
    public void Continue()
    {
        MenuUI.SetActive(false);
        Time.timeScale = 1f;
        Pause_Game = false;
    }
//---------------------- TIME FREEZEGAME MENU OPTION--------------------------
    void Pause()
    {
        MenuUI.SetActive(true);
        Time.timeScale = 0f;
        Pause_Game = true;
    }
//-------------------------HOME MENU OPTION-------------------------------------
    public void LoadScene()
    {
        SceneManager.LoadScene("Menu");    
    }
//-------------------SORTIR DU MENU OPTION-------------------------------
    public void QuitGame()
    {
        Application.Quit();
        print("YOU ARE OUT");
    }
}

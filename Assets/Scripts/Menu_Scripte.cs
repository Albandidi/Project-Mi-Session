using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Scripte : MonoBehaviour
{

//------------------------PLAY MENU PRINCIPAL--------------------------
    public void PlayGame()
    {
        SceneManager.LoadScene("Game_Scene");
        Time.timeScale = 1f;
    }
//------------------------QUITTER MENU PRINCIPAL---------------------
    public void QuitGame()
    {
        Application.Quit();
        print("YOU ARE OUT");
    }

}

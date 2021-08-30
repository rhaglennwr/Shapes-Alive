using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    //public string newGameScene;
    
    public void LoadScene()
    {
        SceneManager.LoadScene("Scenes/ShapesAliveScene");
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
#if UNITY_EDITOR         
        UnityEditor.EditorApplication.isPlaying = false;                
#endif     
        Application.Quit();
    }
}

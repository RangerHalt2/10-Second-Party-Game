using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void StartButton(){
        SceneManager.LoadScene("defaultLevel");
    }

    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitButton(){
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class pauseSystem : MonoBehaviour
{

    public bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    public bool GetIsPaused(){
        return isPaused;
    }

    public void SetIsPaused(bool isPaused){
        this.isPaused = isPaused;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
           //pauseGame();
        }
    }

    public void pauseGame(){
        PlayerInput2.isPaused = !PlayerInput2.isPaused;
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;
    }
}

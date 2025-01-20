using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
//using UnityEditor.UI;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class scoreTracker : MonoBehaviour
{   

    public TMP_Text flowersCount;
    public TMP_Text seconds;
    private float timeLeft = 12f;

    private bool didOnce = false;

    public Canvas UILoss;
    public Canvas self;
    public Canvas Tutorial;
    public Canvas visuals;
    public audioManager audioManager;
    public void Setup(int score){
        didOnce = false;
        gameObject.SetActive(true);
        flowersCount.text = score.ToString() + "/3";
    }
    public void Awake(){

        didOnce = false;

    }
    public void SU(int score){
        flowersCount.text = score.ToString() + "/3";
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(timeLeft <= 10 && !didOnce){
            //Debug.Log("BG Music should Play and Visuals is set to display");
            Tutorial.gameObject.SetActive(false);
            visuals.gameObject.SetActive(true);
            audioManager.PlayBGMusic();
            didOnce = true;
        }

        

        if(timeLeft > 0)
            timeLeft -= Time.deltaTime;
        
        double roundTime = System.Math.Round(timeLeft, 2);

        

        seconds.text = roundTime.ToString();
        if(roundTime <= 0){//If the timer hit 0 then the loss screen should display
            audioManager.PlayLoss();
            self.gameObject.SetActive(false);
            UILoss.gameObject.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class tutorialTimer : MonoBehaviour
{   

    private float timeLeft = 2f;
    public TMP_Text seconds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeLeft > 0)
            timeLeft -= Time.deltaTime;
        
        double roundTime = System.Math.Round(timeLeft, 2);
        seconds.text = roundTime.ToString();
    }
}

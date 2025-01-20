using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateScore : MonoBehaviour
{

    public int score;

    public scoreTracker scoreTracker;

    public Canvas pickUpNotif;

    public Canvas UIWin;

    public audioManager audioManager;
    public pickUpAudio pickUpAudio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){

        pickUpNotif.gameObject.SetActive(true);

    }

    void OnTriggerExit2D(Collider2D other){

        pickUpNotif.gameObject.SetActive(false);

    }


    void OnTriggerStay2D(Collider2D collider){
        score = PlayerInput2.score;
        if(collider.gameObject.tag == "Player"){
            if(!Input.GetKey(KeyCode.E)) return;
            pickUpAudio.PickUp();
            score++;
            PlayerInput2.score = score;
            scoreTracker.SU(score);
            this.gameObject.SetActive(false);

            if(score >= 3){//If the score hits 3 then it should proceed to the win screen.
                scoreTracker.self.gameObject.SetActive(false);
                UIWin.gameObject.SetActive(true);
                audioManager.PlayVictory();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

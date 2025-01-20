using System.Collections;
using System.Collections.Generic;
//using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInput2 : MonoBehaviour
{
    public Animator animator;
    public scoreTracker scoreTracker;
    private Rigidbody2D rb;

    public static int score;
    public static bool isPaused;
    public Canvas winScreen;
    public Canvas lossScreen;
    public Canvas tutorial;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Start Ran");
        if(SceneManager.GetActiveScene().name == "defaultLevel"){
        rb = GetComponent<Rigidbody2D>();
        scoreTracker.Setup(0);
        score = 0;
        }
    }

    void Awake(){
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPaused) return;
        float moveX = Input.GetAxisRaw(PAP.axisXinput);
    
        if(!winScreen.gameObject.activeSelf && !lossScreen.gameObject.activeSelf && !tutorial.gameObject.activeSelf){
        
        animator.SetFloat(PAP.moveX, moveX);

        bool isMoving = !Mathf.Approximately(moveX, 0f);
    
        animator.SetBool(PAP.isMoving, isMoving);
        }
    }

    void FixedUpdate()
    {

        float forceX = animator.GetFloat(PAP.forceX);
        float impulseY = animator.GetFloat(PAP.impulseY);

        if(impulseY != 0){
            rb.AddForce(new Vector2(0, impulseY), ForceMode2D.Impulse);
        }

        if(forceX != 0 ){
            rb.AddForce(new Vector2(forceX, 0));
        }

    }
}

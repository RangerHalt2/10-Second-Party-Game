using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    [SerializeField]
    private AudioClip m_BgMusic;
    [SerializeField]
    private AudioClip a_Tutorial;
    [SerializeField]
    private AudioClip a_Victory;
    [SerializeField]
    private AudioClip a_Loss;
    [SerializeField]
    //private AudioClip a_PickUp;
    private AudioSource m_AudioSource;
    private static audioManager m_Instance;
    public static audioManager Instance
    {
        get{
            if(m_Instance == null){
                m_Instance = FindObjectOfType<audioManager>();
            }
            return m_Instance;
        }
    }
   private AudioSource audioSource;

   private void Awake(){
        if(m_Instance == null)
        {
            m_Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            //Destroy(gameObject);
        }
        m_AudioSource = GetComponent<AudioSource>();
        //Debug.Log("Tutorial Audio Played");
        PlayTutorialAudio();
        //PlayBGMusic();
   }

    public void PlayVictory(){
        m_AudioSource.clip = a_Victory;
        m_AudioSource.loop = false;
        m_AudioSource.Play();
    }
    public void PlayLoss(){
        m_AudioSource.clip = a_Loss;
        m_AudioSource.loop = false;
        m_AudioSource.Play();
    }
    public void PlayTutorialAudio(){
        m_AudioSource.clip = a_Tutorial;
        m_AudioSource.loop = true;
        m_AudioSource.Play();
    }
    public void PlayBGMusic(){
        m_AudioSource.clip = m_BgMusic;
        m_AudioSource.loop = false;
        m_AudioSource.Play();
    }

}

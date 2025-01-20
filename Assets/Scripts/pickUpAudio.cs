using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpAudio : MonoBehaviour
{
    [SerializeField]
    private AudioClip a_PickUp;

    private AudioSource m_AudioSource;
    private static pickUpAudio m_Instance;
    public static pickUpAudio Instance
    {
        get{
            if(m_Instance == null){
                m_Instance = FindObjectOfType<pickUpAudio>();
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
    }

    public void PickUp(){
        m_AudioSource.clip = a_PickUp;
        m_AudioSource.loop = false;
        m_AudioSource.Play();
    }

}

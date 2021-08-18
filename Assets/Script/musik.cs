using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musik : MonoBehaviour
{
    public AudioSource myAudioSource;
    public static GameObject audio;

    private void Awake()
    {
        if (audio)
        {
            Destroy(gameObject);
            return;
        }
        myAudioSource.Play(); 
        audio = gameObject; 
    }
   
}

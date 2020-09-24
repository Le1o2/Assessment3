using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip BackgroundM;
    public AudioClip NormalM;

    // Start is called before the first frame update
    void Start()
    {
        playMusic(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void playMusic()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = BackgroundM;
        audio.Play();
        if (Time.time == BackgroundM.length)
        {
            audio.clip = NormalM;
            audio.Play();
        }
    }
}

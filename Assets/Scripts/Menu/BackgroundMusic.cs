using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BackgroundMusic : MonoBehaviour
{
    public AudioClip[] listAudio;
    AudioSource audioSource;

    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.loop = false;
    }
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = getRandomClip();
            audioSource.Play();
        }
    }

    AudioClip getRandomClip()
    {
        return listAudio[Random.Range(0, listAudio.Length)];
    }

    
}

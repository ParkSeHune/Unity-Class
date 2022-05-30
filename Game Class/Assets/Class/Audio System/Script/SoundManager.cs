using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioManager;
    public AudioClip[] audioClip;

    public void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void SoundVoulume(float Value)
    {
        audioManager.volume = Value;
    }

    void Start()
    {
        audioManager.clip = audioClip[0];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            audioManager.clip = audioClip[0];
            audioManager.Play();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            audioManager.clip = audioClip[1];
            audioManager.Play();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            audioManager.clip = audioClip[2];
            audioManager.Play();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            audioManager.clip = audioClip[3];
            audioManager.Play();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioManager.clip = audioClip[4];
            audioManager.Play();
        }
    }
}

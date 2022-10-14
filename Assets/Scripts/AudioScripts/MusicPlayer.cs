using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private enum Theme
    {
        NONE,
        RETRO,
        MODERN,
        SUSPICIOUS
    }

    [SerializeField] private AudioClip[] audioClips;

    [SerializeField] private Theme theme;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnPlayTheme()
    {
        switch (theme)
        {
            case Theme.RETRO:
                audioSource.clip = audioClips[0];
                break;
            case Theme.MODERN:
                audioSource.clip = audioClips[1];
                break;
            case Theme.SUSPICIOUS:
                audioSource.clip = audioClips[2];
                break;
            default:
                return;
        }
        
        audioSource.Play();
    }
}

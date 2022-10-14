using UnityEngine;

public class SFXPlayer : MonoBehaviour
{
    private enum sfx
    {
        NONE,
        PRATT_INTRO,
        PRATT_COMPLETE,
        PRATT_STOMP,
        CLASSIC_COLLECT,
        CLASSIC_COMPLETE,
        CLASSIC_COMPLETE_ALT,
        CLASSIC_JUMP,
        CLASSIC_STOMP,
        BELL,
        BOOM,
        BREEZE,
        YES,
        CYBERPUNK1,
        CYBERPUNK2
    }

    [SerializeField] private AudioClip[] audioClips;

    [SerializeField] private sfx sound;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnPlayEffect()
    {
        if (sound == sfx.NONE)
            return;
        
        audioSource.clip = audioClips[(int)sound-1];
        audioSource.Play();
    }
}

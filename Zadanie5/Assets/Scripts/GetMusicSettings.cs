using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMusicSettings : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    private void Awake()
    {
        audioSource.mute = !(PassMusicSettings.MusicOn);
    }
}

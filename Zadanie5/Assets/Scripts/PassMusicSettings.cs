using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassMusicSettings : MonoBehaviour
{
    public static bool MusicOn = true;

    public void SetMusic(bool isMusicOn)
    {
        MusicOn = isMusicOn;
    }
}

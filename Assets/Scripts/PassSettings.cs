using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassSettings : MonoBehaviour
{
    public static bool MusicOn = true;
    public static string BlueName = "Blue Player";
    public static string RedName = "Red Player";

    public void SetMusic(bool isMusicOn)
    {
        MusicOn = isMusicOn;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private GameObject offImage;
    public static bool musicOn = true;

    public void PlayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void MuteButton()
    {
        musicOn = !musicOn;
        audioSource.mute = !musicOn;
        offImage.SetActive(!musicOn);
        transform.GetComponentInParent<PassMusicSettings>().SetMusic(musicOn);
    }
}

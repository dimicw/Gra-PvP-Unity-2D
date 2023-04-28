using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private GameObject offImage;
    [SerializeField] private GameObject redName;
    [SerializeField] private GameObject blueName;
    [SerializeField] private GameObject menu1;
    [SerializeField] private GameObject menu2;
    public static bool musicOn = true;

    public void PlayButton()
    {
        menu1.SetActive(false);
        menu2.SetActive(true);
    }

    public void BackButton()
    {
        menu1.SetActive(true);
        menu2.SetActive(false);
    }

    public void Play2Button()
    {
        PassSettings.RedName = redName.GetComponent<TMP_InputField>().text;
        PassSettings.BlueName = blueName.GetComponent<TMP_InputField>().text;
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
        transform.GetComponentInParent<PassSettings>().SetMusic(musicOn);
    }
}

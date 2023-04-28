using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    [SerializeField] private GameObject nameField;
    [SerializeField] private GameObject endScreen;
    [SerializeField] private GameObject bluePlayer;
    [SerializeField] private GameObject redPlayer;

    public void SetWinningName()
    {
        if(redPlayer.GetComponent<Health>().getHeath() == 0)
            nameField.GetComponent<TMP_Text>().text = PassSettings.BlueName;
        else if (bluePlayer.GetComponent<Health>().getHeath() == 0)
            nameField.GetComponent<TMP_Text>().text = PassSettings.RedName;
        endScreen.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}

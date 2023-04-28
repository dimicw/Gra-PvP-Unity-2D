using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetPlayerNames : MonoBehaviour
{
    [SerializeField] private GameObject redNameField;
    [SerializeField] private GameObject blueNameField;

    private void Awake()
    {
        string red = PassSettings.RedName;
        string blue = PassSettings.BlueName;

        if (red != "")
            redNameField.GetComponent<TMP_Text>().text = red;
        else
            redNameField.GetComponent<TMP_Text>().text = "Red Player";

        if (blue != "")
            blueNameField.GetComponent<TMP_Text>().text = blue;
        else
            blueNameField.GetComponent<TMP_Text>().text = "Blue Player";
    }
}

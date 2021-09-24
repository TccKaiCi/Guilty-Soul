using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManaged : MonoBehaviour
{
    public GameObject dialogBox;
    public Text dialogText;
    public KeyCode interacKey;

    public void ShowBox(string dialog)
    {
        dialogBox.SetActive(true);
        dialogText.text = dialog;
    }

    public void CloseDialog()
    {
        dialogBox.SetActive(false);
    }
}

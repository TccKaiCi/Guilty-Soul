using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogHolder : MonoBehaviour
{
    public string dialog;
    public KeyCode keyCode;
    public bool inRange;
    public bool isShow;

    DialogManaged dialogueManaged;

    // Start is called before the first frame update
    void Start()
    {
        dialogueManaged = FindObjectOfType<DialogManaged>();
    }

    private void Update()
    {
        if (inRange)
        {
            if (Input.GetKeyUp(keyCode))
            {
                if (isShow)
                {
                    dialogueManaged.CloseDialog();
                    isShow = false;
                }
                else
                {
                    dialogueManaged.ShowBox(dialog);
                    isShow = true;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            inRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            inRange = false;
            isShow = false;
            dialogueManaged.CloseDialog();
        }
    }
}

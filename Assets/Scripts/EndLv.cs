using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLv : MonoBehaviour
{
    public bool isEnd_lv = false;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            isEnd_lv = true;
            SceneController scn = new SceneController();
            scn.SceneGoto("Menu");
        }
    }
}

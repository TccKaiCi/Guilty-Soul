using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLv : MonoBehaviour
{
    public bool isEnd_lv = false;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {

        }
    }
}

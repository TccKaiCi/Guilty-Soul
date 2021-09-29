using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VisualName : MonoBehaviour
{
    private string nameVisual;
    void Start()
    {
        nameVisual = gameObject.GetComponentInParent<Player>().name;
        Debug.Log(nameVisual);
        gameObject.GetComponentInChildren<TextMeshPro>().text = nameVisual;
    }

}

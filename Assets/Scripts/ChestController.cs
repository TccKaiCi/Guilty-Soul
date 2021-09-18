using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    public bool isOpen = false;

    public void OpenChest()
    {
        if( !isOpen )
        {
            Debug.Log("Chest is open now...");
        }
    }
}

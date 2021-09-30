using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermySense : MonoBehaviour
{
    public bool target;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Lock Target" + collision.GetComponent<Player>().name);
            target = collision.GetComponent<Player>();
        }
    }
 
}

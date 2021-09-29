using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInSecond : MonoBehaviour
{
    [SerializeField] private float secondToDestroy = 1f;
    private void Start()
    {
        Destroy(gameObject, secondToDestroy);
    }
}

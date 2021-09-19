using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public Animator animator;
    public bool isInRange;
    public KeyCode interacKey;
    public UnityEvent interAction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interacKey))
            {
                if (animator.GetBool("IsOpen")) animator.SetBool("IsOpen", false);
                else
                {
                    animator.SetBool("IsOpen", true);
                }
                interAction.Invoke();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Toi Gan");
            isInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            animator.SetBool("IsOpen", false);
            Debug.Log("Di ra xa");
            isInRange = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public KeyCode pause;
    public KeyCode exit;
    public bool isPause;
    public void Start()
    {
    }
    public void Update()
    {
        if (Input.GetKeyDown(pause))
        {
            isPause = !isPause;
            if (isPause)
                Time.timeScale = 0;
            else Time.timeScale = 1;
        }
        if (Input.GetKeyDown(exit))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}

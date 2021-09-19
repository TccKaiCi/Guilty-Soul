using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{

    public Button btn;

    public void changeScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }

}

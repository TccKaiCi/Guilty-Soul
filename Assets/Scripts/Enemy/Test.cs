using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Test : MonoBehaviour
{
    string strOut;
    // Start is called before the first frame update
    void Start()
    {
        Enemy frog = new Frog();
        frog.health = 5;
        Enemys listE = new Enemys();
        listE.listEnemy.Add(frog);
        
        foreach (Frog p in listE.listEnemy)
        {
            strOut = string.Empty;
            strOut = JsonUtility.ToJson(p);
        }
        File.WriteAllText(Application.dataPath + "/SaveF.json", strOut);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class JSONReader : MonoBehaviour
{

    void Start()
    {
        /*     
        enemys = JsonUtility.FromJson<Enemys>(dataPath.text);

        foreach (Enemy employee in enemys.listEnemy)
        {
            Debug.Log("Found enemy: " + employee.name + " " + employee.health);
        }
*/
        Enemys enemys = new Enemys();

        Frog a1 = new Frog(2, "FrOG", 10);
        Enemy a2 = new Frog(4, "213213213", 10);
        Enemy a3 = new Frog(5, "222222222222", 10);

        enemys.listEnemy.Add(a1);
        enemys.listEnemy.Add(a2);
        enemys.listEnemy.Add(a3);


        foreach (Enemy i in enemys.listEnemy)
        {
            i.infor();
        }

        string strout = JsonUtility.ToJson(enemys, true);
        File.WriteAllText(Application.dataPath + "/Save.json", strout);

    }
}

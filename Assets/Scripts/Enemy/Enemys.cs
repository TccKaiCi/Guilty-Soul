using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Enemys : MonoBehaviour
{
    public List<Enemy> listEnemy = new List<Enemy>();

    public Frog findById_Frog(int id)
    {
        Frog result = new Frog();

        foreach (Enemy e in listEnemy)
        {
            Debug.Log(e.id);
            if (e.id == id)
            {
                result.id = e.id;
                result.name = e.name;
                result.health = e.health;

                return result;
            }
        }

        return null;
    }

    

    /**
    public Eagle findById_Eagle(int id)
    {
        Eagle result = new Eagle();

        foreach (Enemy e in listEnemy)
        {
            if (e.id == id)
            {
                result.id = e.id;
                result.name = e.name;
                result.health = e.health;
                result.armor = 

                return result;
            }
        }

        return null;
    }
    **/


}

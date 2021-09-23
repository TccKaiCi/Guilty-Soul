using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Player : MonoBehaviour
{
    public string name;
    public int health;
    public int mana;
    public Stats playerStat = new Stats();
    public TextAsset statFile;
    public int m_ghostTime;
    private int ghostTime;

    private void Awake()
    {
        ghostTime = m_ghostTime;
        GenerateStat();
        if(pl)
    }
   
    public class Stats
    {
        public string name;
        public int health;
        public int mana;
    }
   
    public void GenerateStat()
    {    
        playerStat = JsonUtility.FromJson<Stats>(statFile.text);
        health = playerStat.health;
        name = playerStat.name;
        mana = playerStat.mana;
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        
        if (col.CompareTag("Enemy"))
        {
            ghostTime--;
            if (ghostTime == 0)
            {
                health--;
                ghostTime = m_ghostTime;
            }
        }
        
    }
  
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Player : MonoBehaviour
{
    public string name;
    public int health;
    public int maxHeal;
    public int mana;
    public TextAsset statFile;
    public int m_ghostTime;
    private int ghostTime;
    public bool is_col = false;
    private void Awake()
    {
        maxHeal = health;
        ghostTime = m_ghostTime;
        GenerateStat();
       
    }
    private void Update()
    {
        DecreasHP(1);
    }

    public class Stats
    {
        public string name;
        public int health;
        public int mana;
    }
    public void GenerateStat()
    {
        Stats playerStat = new Stats();
        playerStat = JsonUtility.FromJson<Stats>(statFile.text);
        health = playerStat.health;
        name = playerStat.name;
        mana = playerStat.mana;
    }

    // use for enermy to deal extacly damage
    public void DecreasHP(int damePoint)
    {
        if (health < -8) health = 0;
        if (health > maxHeal+8) health = maxHeal;
        if (is_col)
        {
            ghostTime--;
            if (ghostTime == 0)
            {
                health = health -damePoint;       
                ghostTime = m_ghostTime;
            }
        }
    }
    //this 2 code funtiont just for test heal decreas not exist in logic gamne because Enermy deal dame not like Player self hurt like this
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Enemy"))
        is_col = true;
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Enemy"))
        is_col = false;
    }
}


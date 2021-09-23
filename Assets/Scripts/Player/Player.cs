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

    private void Awake()
    {
        GenerateStat();
    }
   
    [System.Serializable]
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
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

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
    private Transform lastBonFire;
    Stats playerStat = new Stats();
    SavePack sv = new SavePack();
    private void Start()
    {
        maxHeal = health;
        ghostTime = m_ghostTime;
        GenerateStat();
    }
    private void Update()
    {
        DecreasHP(1);
    }
    [System.Serializable] // khong co dong nay khoi 
    public class Stats
    {
        public string name;
        public int health;
        public int mana;
        public Stats(string name, int health, int mana)
        {
            this.name = name;
            this.health = health;
            this.mana = mana;
        }
        public Stats() { }
    }
    [System.Serializable]
    public class Spawn
    {
        public int id;
        public string description;
    }
    [System.Serializable]
    public class SavePack
    {
        public List<Stats> l_Stats = new List<Stats>();
        public List<Spawn> l_spawn = new List<Spawn>();
    }
    public void GenerateStat()
    {
        FileTool ft = new FileTool();
          sv= ft.JsonReader(statFile);
        int lenght = sv.l_Stats.Count-1;
        Debug.Log("lenght" + lenght);
        health = sv.l_Stats[lenght].health;// sau nay khi co bang chon save file se them doi so vao. tam thoi gio chon player dau tien trong list
        name = sv.l_Stats[lenght].name;
        mana = sv.l_Stats[lenght].mana;
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
                health = health - damePoint;       
                ghostTime = m_ghostTime;
            }
        }
    }
    //respawn
    public void saveButton()
    {
         Stats currentStat = new Stats(name,health,mana);
        sv.l_Stats.Add(currentStat);
        FileTool ft = new FileTool();
        ft.JsonWriter("data.json", sv);
        Debug.Log("save"+currentStat.health);
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


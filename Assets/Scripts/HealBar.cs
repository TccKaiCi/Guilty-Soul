using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealBar : MonoBehaviour
{
    public GameObject slotPrefab;
    public GameObject ant;
    public Transform slotPanel;
    public Player player;
    private int p_hp;
    public int c_mana;
    GameObject instance;
    public void Start()
    {
        //tham chieu player stat
        player = ant.GetComponent<Player>();
        //luu lai mau khoi dau
        p_hp = player.health;
        //tao mau
        drawHpbar();
    }
    private void Update()
    {
        HpchangeChecker();
    }

    public void HpchangeChecker()
    {
       
        if (p_hp != player.health)
        {
            reDraw();
            Debug.Log("change hp");
            drawHpbar();
            p_hp = player.health;
            
        }
    }
    public void drawHpbar()
    {
        
        for (int i = 0; i < player.health; i++)
        {
           var instance = Instantiate(slotPrefab);
            instance.transform.SetParent(slotPanel);
          
        }
    }
   public void reDraw()
    {
        foreach (Transform child in slotPanel)
        {
            GameObject.Destroy(child.gameObject);
        }
    }

}

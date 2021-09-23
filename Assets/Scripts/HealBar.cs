using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealBar : MonoBehaviour
{
    public GameObject slotPrefab;
    public GameObject ant;
    public Transform slotPanel;
    public Player player;
    public int c_hp;
    public int c_mana;
    public void Start()
    {

        player = ant.GetComponent<Player>();
        for (int i = 0; i < player.health; i++)
        {
            GameObject instance = Instantiate(slotPrefab);
            instance.transform.SetParent(slotPanel);
        }

    }
    private void Update()
    {
        Hpchange();
    }
    public void Hpchange()
    {
       
    }
}
